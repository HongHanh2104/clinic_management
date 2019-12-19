using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index=-1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            createUI();
            setCurrentDate();
        }

        private void createUI()
        {
            this.data_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            /*
            this.tb_search.Location = scalePoint(this.tb_search.Location.X, this.tb_search.Location.Y);
            this.btn_search.Location = new Point(this.tb_search.Location.X + this.tb_search.Size.Width + 10, this.tb_search.Location.Y);
            this.btn_insert.Location = new Point(this.tb_search.Location.X + 50, this.btn_insert.Location.Y);
            this.btn_load.Location = new Point(this.btn_insert.Location.X - this.btn_load.Size.Width - 80, this.btn_load.Location.Y);
            this.btn_edit.Location = new Point(this.btn_insert.Location.X + this.btn_insert.Size.Width + 80, this.btn_edit.Location.Y);
            this.lb_id.Location = scalePoint(this.lb_id.Location.X, this.lb_id.Location.Y);
            this.tb_id.Location = scalePoint(this.tb_id.Location.X, this.tb_id.Location.Y);
            */
        }

        private void setCurrentDate()
        {
            DateTime today = DateTime.Today;
            
            string day = Convert.ToString(today.Day);
            string month = Convert.ToString(today.Month);
            string year = Convert.ToString(today.Year);
            tb_day.Text = day;
            tb_month.Text = month;
            tb_year.Text = year;
            
        }
        
        private Point scalePoint(int x, int y)
        {
            Size st = this.Size;
            int height = st.Height;
            int width = st.Width;

            double x_ratio = this.Width*1.0 / 755;
            double y_ratio = this.Height*1.0 / 480;
            int new_x = (int)((double)x * x_ratio);
            int new_y = (int)((double)y * y_ratio);
            Console.WriteLine(x*x_ratio);
            Console.WriteLine(new_x.ToString());
            return new Point(new_x, new_y);
        } 

        private void btn_load_Click_1(object sender, EventArgs e)
        {
            string query = "";
            int day = getIntDay(this.tb_day.Text);
            int month = getIntMonth(this.tb_month.Text);
            int year = getIntYear(this.tb_year.Text);
            
            bool checkDay = day != -1;
            bool checkMon = month != -1;
            bool checkYear = year != -1;

            
            if (checkYear)
            {
                if (checkMon)
                {
                    if (checkDay)
                    {
                        query = "select p.ID as 'ID', p.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Loại khám', m.ID as 'idm' from PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient) where year(m.dateCheckup) = " + year.ToString() + " and month(m.dateCheckup) = " + month.ToString() + " and day(m.dateCheckup) = " + day.ToString();
                    }
                    else
                    {
                        //Show data follow Year, Month
                        query = "select p.ID as 'ID', p.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Loại khám', m.ID as 'idm' from PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient) where year(m.dateCheckup) = " + year.ToString() + " and month(m.dateCheckup) = " + month.ToString();
                    }
                }
                else
                {
                    query = "select p.ID as 'ID', p.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Loại khám', m.ID as 'idm' from PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient) where year(m.dateCheckup) = " + year.ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("Cần nhập giá trị số ngày tháng năm để hiển thị!", "Lỗi");
                return;
            }

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                //string query = "select p.ID as 'ID', p.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Loại khám' from PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, Con);
                if (sqlDa == null)
                {
                    //Khong co du lieu theo yeu cau tim kiem
                    MessageBox.Show("Không có dữ liệu để xem!", "Xem");
                    return;
                }
                DataTable dttb = new DataTable();
                sqlDa.Fill(dttb);

                data_view.DataSource = dttb;
                data_view.Columns["ID"].Visible = false;
                data_view.Columns["idm"].Visible = false;
                if ((int)data_view.RowCount  == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    return;
                }
                Con.Close();
            }      
        }

        private int getIntDay(string strday)
        {
            bool day_check = checkNumber(strday);
            
            if(day_check == true && strday.Length <= 2)
            {
                return Convert.ToInt32(strday);
            }
            return -1;
        }

        private int getIntMonth(string strmonth)
        {
            bool month_check = checkNumber(strmonth);
            if (month_check == true && strmonth.Length <= 2)
            {
                return Convert.ToInt32(strmonth);
            }
            //MessageBox.Show("Tháng phải là giá trị số và có 2 giá trị!!!", "Lỗi");
            return -1;
        }

        private int getIntYear(string stryear)
        {
            bool year_check = checkNumber(stryear);
            if (year_check == true && stryear.Length == 4)
            {
                return Convert.ToInt32(stryear);
            }
            return -1;
        }

        private bool checkNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            Form insertForm = new InsertForm();
            insertForm.TopMost = true;
            insertForm.Show();

        }
        
        private void data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                tb_id.Text = "";
                tb_name.Text = "";
                tb_birthyear.Text = "";
                combo_gender.Text = "";
                tb_addr.Text = "";
                tb_phone.Text = "";
                tb_date.Text = "";
                combo_reason.Text = "";
                return;
            }

            DataGridViewRow row = data_view.Rows[index];

            tb_id.Text = row.Cells[1].Value.ToString();
            tb_name.Text = row.Cells[2].Value.ToString();
            int temp_birthyear = (int)row.Cells[3].Value;
            tb_birthyear.Text = temp_birthyear.ToString();
            combo_gender.Text = row.Cells[4].Value.ToString();
            tb_addr.Text = row.Cells[5].Value.ToString();
            tb_phone.Text = row.Cells[6].Value.ToString();
            tb_date.Text = Convert.ToString(row.Cells[7].Value);
            //date = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
            //tb_date.Text = date;
            //Console.WriteLine(date);
            combo_reason.Text = row.Cells[8].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                DataGridViewRow newDataRow = data_view.Rows[index];

                //To do: check date: <=today + format, gender in (Nam, Nu, Khac), reason in (Mat, Cot song), birthyear <= year now
                string id = newDataRow.Cells[0].Value.ToString();
                string idm = newDataRow.Cells[9].Value.ToString();
                string idhs = tb_id.Text;
                string name = tb_name.Text;
                string birthyear = tb_birthyear.Text;
                string gender = combo_gender.GetItemText(combo_gender.SelectedItem);
                string addr = tb_addr.Text;
                string phone = tb_phone.Text;
                string temp_date = tb_date.Text;
                string date = DateTime.ParseExact(temp_date, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
                string reason = combo_reason.GetItemText(combo_reason.SelectedItem);



                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    string query = "update PatientInformation set profileCode = '" + idhs + "', name = N'" + name + "', birthyear = " + birthyear + ", gender = N'" + gender + "', address1 = N'" + addr + "', phonenumber = '" + phone + "' where ID = " + id;
                    Console.WriteLine(query);
                    SqlCommand cmdP = new SqlCommand(query, Con);
                    var resP = cmdP.ExecuteNonQuery();
                    if (resP != null & (int)resP == 1)
                    {
                        Console.WriteLine("update P: " + ((Int32)resP).ToString());
                        string q = "update MedicalExamination set dateCheckup = '" + date + "', typeCheckup = N'" + reason + "' where idPatient = " + id + " and ID = " + idm;
                        SqlCommand cmdM = new SqlCommand(q, Con);
                        var resM = cmdM.ExecuteNonQuery();
                        if (resM != null & (int)resM == 1)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Cập nhật");
                            newDataRow.Cells[1].Value = idhs;
                            newDataRow.Cells[2].Value = name;
                            newDataRow.Cells[3].Value = birthyear;
                            newDataRow.Cells[4].Value = gender;
                            newDataRow.Cells[5].Value = addr;
                            newDataRow.Cells[6].Value = phone;
                            newDataRow.Cells[7].Value = temp_date;
                            newDataRow.Cells[8].Value = reason;

                        }
                        else
                            MessageBox.Show("Cập nhật thất bại!", "Cập nhật");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại!", "Cập nhật");
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Cần chọn hàng để xử lý!", "Cập nhật");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string str_search = tb_search.Text;
            if (str_search != "")
            {
                //Console.WriteLine(str_search);
                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    string query = "select p.ID as 'ID', p.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Loại khám', m.ID as 'idm' from PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, Con);
                    if (sqlDa == null)
                    {
                        //Khong co du lieu theo yeu cau tim kiem
                        MessageBox.Show("Không có dữ liệu để tìm kiếm!", "Tìm kiếm");
                        return;
                    }
                    DataTable dttb = new DataTable();
                    sqlDa.Fill(dttb);

                    dttb = searchInDataTable(str_search, dttb);
                    data_view.DataSource = dttb;
                    data_view.Columns["ID"].Visible = false;
                    data_view.Columns["idm"].Visible = false;
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập từ khóa để thực hiện tìm kiếm!", "Tìm kiếm");
            }
        }

        private DataTable searchInDataTable(string str_search, DataTable dttb)
        {
            string str_searchre = reformString(str_search);
            foreach (DataRow datarow in dttb.Rows)
            {
                //string cellname = datarow["Họ và tên"].ToString();
                string cellnamere = reformString(datarow["Họ và tên"].ToString());
                //string cellphone = datarow["Số điện thoại"].ToString();
                string cellphonere = reformString(datarow["Số điện thoại"].ToString());
                //Console.WriteLine("name: "+cellname);
                //Console.WriteLine("phone: " + cellphone);
                if (!searchString(str_searchre,cellnamere) & !searchString(str_searchre,cellphonere))
                {
                    datarow.Delete();
                }
            }
            dttb.AcceptChanges();
            return dttb;
        }

        private string reformString(string str_search)
        {
            str_search = removeDiacritics(str_search); 
            return str_search.ToLower();
        }

        private string removeDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        bool searchString(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            // create lps[] that will hold the longest 
            // prefix suffix values for pattern 
            int[] lps = new int[M];
            int j = 0; // index for pat[] 

            // Preprocess the pattern (calculate lps[] 
            // array) 
            computeLPSArray(pat, M, lps);

            int i = 0; // index for txt[] 
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    Console.Write("Found pattern "+ "at index " + (i - j));
                    return true;
                    j = lps[j - 1];
                }

                // mismatch after j matches 
                else if (i < N && pat[j] != txt[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
            return false;
        }

        void computeLPSArray(string pat, int M, int[] lps)
        {
            // length of the previous longest prefix suffix 
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0 

            // the loop calculates lps[i] for i = 1 to M-1 
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len]) 
                {
                    // This is tricky. Consider the example. 
                    // AAACAAAA and i = 7. The idea is similar 
                    // to search step. 
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        // Also, note that we do not increment 
                        // i here 
                    }
                    else // if (len == 0) 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
        private void data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_del_all_Click(object sender, EventArgs e)
        {
            string query = "";
            int day = getIntDay(this.tb_day.Text);
            int month = getIntMonth(this.tb_month.Text);
            int year = getIntYear(this.tb_year.Text);

            bool checkDay = day != -1;
            bool checkMon = month != -1;
            bool checkYear = year != -1;


            if (checkYear)
            {
                if (checkMon)
                {
                    if (checkDay)
                    {
                        query = "delete  from MedicalExamination  where year(dateCheckup) = " + year.ToString() + " and month(dateCheckup) = " + month.ToString() + " and day(dateCheckup) = " + day.ToString() + "; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination) ";
                    }
                    else
                    {
                        //Show data follow Year, Month
                        query = "delete  from MedicalExamination  where year(dateCheckup) = " + year.ToString() + " and month(dateCheckup) = " + month.ToString() +  "; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination) ";
                    }
                }
                else
                {
                    query = "delete from MedicalExamination where year(dateCheckup) = " + year.ToString() + "; delete  from PatientInformation where ID not in (select idPatient from MedicalExamination) ";

                }
            }
            else
            {
                MessageBox.Show("Cần nhập giá trị số ngày tháng năm để xóa!", "Lỗi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    //string query = "delete from MedicalExamination; delete from PatientInformation";
                    Console.WriteLine(query);
                    SqlCommand cmdP = new SqlCommand(query, Con);
                    var resP = cmdP.ExecuteNonQuery();
                    if (resP != null & (int)resP > 0)
                    {
                        index = -1;
                        tb_id.Text = "";
                        tb_name.Text = "";
                        tb_birthyear.Text = "";
                        combo_gender.Text = "";
                        tb_addr.Text = "";
                        tb_phone.Text = "";
                        tb_date.Text = "";
                        combo_reason.Text = "";
                        removeDataGridViewRow();
                        MessageBox.Show("Xóa dữ liệu thành công!", "Xóa");

                    }
                    else
                        MessageBox.Show("Xóa dữ liệu thất bại!", "Xóa");
                    Con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void removeDataGridViewRow()
        {
            for (int i = 0; i < data_view.RowCount; i++)
                data_view.Rows.RemoveAt(i);
            //data_view.Refresh();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && index >= 0)
            {
                DataGridViewRow newDataRow = data_view.Rows[index];

                string id = newDataRow.Cells[0].Value.ToString();
                string idm = newDataRow.Cells[9].Value.ToString();
                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    string query = "delete from MedicalExamination where ID = " + idm + "; delete from PatientInformation where ID = " + id;
                    Console.WriteLine(query);
                    SqlCommand cmdP = new SqlCommand(query, Con);
                    var resP = cmdP.ExecuteNonQuery();
                    if (resP != null & (int)resP >= 1)
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        data_view.Rows.RemoveAt(index);
                        index = -1;
                        tb_id.Text = "";
                        tb_name.Text = "";
                        tb_birthyear.Text = "";
                        combo_gender.Text = "";
                        tb_addr.Text = "";
                        tb_phone.Text = "";
                        tb_date.Text = "";
                        combo_reason.Text = "";
                    }
                    else
                        MessageBox.Show("Yêu cầu xóa thất bại!", "Thông báo");
                    Con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
