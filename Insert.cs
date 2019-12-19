using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //To do: check birthyear <= year now, date <= datenow
            string name = tb_name.Text;
            string id = tb_id.Text;
            string birth_year = tb_birth_year.Text;
            string str_date = tb_medi_day.Text + "/" + tb_medi_month.Text + "/" +  tb_medi_year.Text;
            DateTime medi_date = DateTime.ParseExact(str_date, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
           // Console.WriteLine(medi_date.ToString());
            if (!checkNumber(birth_year) | int.Parse(birth_year) > DateTime.Today.Year)
            {
                MessageBox.Show("Vui lòng nhập năm sinh thỏa mãn là số và không lớn hơn năm hiện tại!","Lỗi");
                return;
            }

            if (DateTime.Compare(medi_date, DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày khám phải nhỏ hơn ngày hiện tại", "Lỗi");
                return;
            }

            string gender = combo_gen.GetItemText(combo_gen.SelectedItem);
            string phone = tb_phone.Text;
            string addr = tb_addr.Text;
            string date = tb_medi_year.Text + "-" + tb_medi_month.Text + "-" + tb_medi_day.Text;
            DateTime datecheck = DateTime.Parse(date);
            string reason = combo_reason.GetItemText(combo_reason.SelectedItem);

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "insert into PatientInformation(profileCode,name,birthyear,gender,address1,phonenumber) values('" + id + "',N'" + name + "'," + birth_year + ",N'" + gender + "',N'" + addr + "','" + phone + "')" + "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, Con);
                var rowE = command.ExecuteScalar();
                if (rowE != null)
                {
                    //Console.WriteLine("ID patient: " + rowE.ToString());
                    string q = "insert into MedicalExamination(idPatient,dateCheckup,typeCheckup) values(" + rowE.ToString() + ",'" + date + "',N'" + reason + "')" + "SELECT CAST(scope_identity() AS int)";
                    SqlCommand cmd = new SqlCommand(q, Con);
                    var rowEffect = cmd.ExecuteScalar();
                    
                    if (rowEffect != null)
                        MessageBox.Show("Lưu thành công!", "Lưu");
                    else
                        // To-do xóa thằng ngoài: Vũ viết
                        MessageBox.Show("Không thể lưu dữ liệu!", "Lưu");

                }
                else
                    MessageBox.Show("Không thể lưu dữ liệu!", "Lưu");
                Con.Close(); 
            }

        }
        private bool checkNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }
    }

}
