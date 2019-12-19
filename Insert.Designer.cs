namespace QuanLyPhongKham
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.combo_gen = new System.Windows.Forms.ComboBox();
            this.lb_birth = new System.Windows.Forms.Label();
            this.tb_birth_year = new System.Windows.Forms.TextBox();
            this.lb_addr = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_reason = new System.Windows.Forms.Label();
            this.combo_reason = new System.Windows.Forms.ComboBox();
            this.lb_medi_date = new System.Windows.Forms.Label();
            this.tb_medi_day = new System.Windows.Forms.TextBox();
            this.tb_medi_month = new System.Windows.Forms.TextBox();
            this.tb_medi_year = new System.Windows.Forms.TextBox();
            this.lb_slash3 = new System.Windows.Forms.Label();
            this.lb_slash2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(14, 27);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Họ tên";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(115, 24);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(261, 30);
            this.tb_name.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(517, 24);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(148, 30);
            this.tb_id.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(409, 27);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(82, 20);
            this.lb_id.TabIndex = 2;
            this.lb_id.Text = "Mã hồ sơ";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(205, 80);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(76, 20);
            this.lb_gender.TabIndex = 4;
            this.lb_gender.Text = "Giới tính";
            // 
            // combo_gen
            // 
            this.combo_gen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_gen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gen.FormattingEnabled = true;
            this.combo_gen.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.combo_gen.Location = new System.Drawing.Point(287, 76);
            this.combo_gen.MaxDropDownItems = 3;
            this.combo_gen.Name = "combo_gen";
            this.combo_gen.Size = new System.Drawing.Size(89, 28);
            this.combo_gen.TabIndex = 4;
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth.Location = new System.Drawing.Point(15, 79);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(83, 20);
            this.lb_birth.TabIndex = 6;
            this.lb_birth.Text = "Năm sinh";
            // 
            // tb_birth_year
            // 
            this.tb_birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_birth_year.Location = new System.Drawing.Point(115, 77);
            this.tb_birth_year.Multiline = true;
            this.tb_birth_year.Name = "tb_birth_year";
            this.tb_birth_year.Size = new System.Drawing.Size(75, 30);
            this.tb_birth_year.TabIndex = 3;
            // 
            // lb_addr
            // 
            this.lb_addr.AutoSize = true;
            this.lb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addr.Location = new System.Drawing.Point(13, 135);
            this.lb_addr.Name = "lb_addr";
            this.lb_addr.Size = new System.Drawing.Size(64, 20);
            this.lb_addr.TabIndex = 8;
            this.lb_addr.Text = "Địa chỉ";
            // 
            // tb_addr
            // 
            this.tb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addr.Location = new System.Drawing.Point(115, 132);
            this.tb_addr.Multiline = true;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(550, 30);
            this.tb_addr.TabIndex = 6;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(518, 76);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(147, 30);
            this.tb_phone.TabIndex = 5;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(409, 79);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(44, 20);
            this.lb_phone.TabIndex = 10;
            this.lb_phone.Text = "SĐT";
            // 
            // lb_reason
            // 
            this.lb_reason.AutoSize = true;
            this.lb_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reason.Location = new System.Drawing.Point(412, 186);
            this.lb_reason.Name = "lb_reason";
            this.lb_reason.Size = new System.Drawing.Size(100, 20);
            this.lb_reason.TabIndex = 12;
            this.lb_reason.Text = "Lý do khám";
            // 
            // combo_reason
            // 
            this.combo_reason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_reason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_reason.FormattingEnabled = true;
            this.combo_reason.Items.AddRange(new object[] {
            "Mắt",
            "Cột sống"});
            this.combo_reason.Location = new System.Drawing.Point(517, 178);
            this.combo_reason.MaxDropDownItems = 3;
            this.combo_reason.Name = "combo_reason";
            this.combo_reason.Size = new System.Drawing.Size(147, 28);
            this.combo_reason.TabIndex = 10;
            // 
            // lb_medi_date
            // 
            this.lb_medi_date.AutoSize = true;
            this.lb_medi_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medi_date.Location = new System.Drawing.Point(13, 190);
            this.lb_medi_date.Name = "lb_medi_date";
            this.lb_medi_date.Size = new System.Drawing.Size(97, 20);
            this.lb_medi_date.TabIndex = 14;
            this.lb_medi_date.Text = "Ngày khám";
            // 
            // tb_medi_day
            // 
            this.tb_medi_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_medi_day.Location = new System.Drawing.Point(115, 186);
            this.tb_medi_day.Multiline = true;
            this.tb_medi_day.Name = "tb_medi_day";
            this.tb_medi_day.Size = new System.Drawing.Size(38, 30);
            this.tb_medi_day.TabIndex = 7;
            // 
            // tb_medi_month
            // 
            this.tb_medi_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_medi_month.Location = new System.Drawing.Point(179, 186);
            this.tb_medi_month.Multiline = true;
            this.tb_medi_month.Name = "tb_medi_month";
            this.tb_medi_month.Size = new System.Drawing.Size(38, 30);
            this.tb_medi_month.TabIndex = 8;
            // 
            // tb_medi_year
            // 
            this.tb_medi_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_medi_year.Location = new System.Drawing.Point(243, 186);
            this.tb_medi_year.Multiline = true;
            this.tb_medi_year.Name = "tb_medi_year";
            this.tb_medi_year.Size = new System.Drawing.Size(62, 30);
            this.tb_medi_year.TabIndex = 9;
            // 
            // lb_slash3
            // 
            this.lb_slash3.AutoSize = true;
            this.lb_slash3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash3.Location = new System.Drawing.Point(155, 186);
            this.lb_slash3.Name = "lb_slash3";
            this.lb_slash3.Size = new System.Drawing.Size(22, 31);
            this.lb_slash3.TabIndex = 18;
            this.lb_slash3.Text = "/";
            // 
            // lb_slash2
            // 
            this.lb_slash2.AutoSize = true;
            this.lb_slash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash2.Location = new System.Drawing.Point(219, 185);
            this.lb_slash2.Name = "lb_slash2";
            this.lb_slash2.Size = new System.Drawing.Size(22, 31);
            this.lb_slash2.TabIndex = 19;
            this.lb_slash2.Text = "/";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(179, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 46);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(402, 259);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 46);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_slash2);
            this.Controls.Add(this.lb_slash3);
            this.Controls.Add(this.tb_medi_year);
            this.Controls.Add(this.tb_medi_month);
            this.Controls.Add(this.tb_medi_day);
            this.Controls.Add(this.lb_medi_date);
            this.Controls.Add(this.combo_reason);
            this.Controls.Add(this.lb_reason);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.lb_addr);
            this.Controls.Add(this.tb_birth_year);
            this.Controls.Add(this.lb_birth);
            this.Controls.Add(this.combo_gen);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Name = "InsertForm";
            this.Text = "Thêm mới bệnh nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.ComboBox combo_gen;
        private System.Windows.Forms.Label lb_birth;
        private System.Windows.Forms.TextBox tb_birth_year;
        private System.Windows.Forms.Label lb_addr;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_reason;
        private System.Windows.Forms.ComboBox combo_reason;
        private System.Windows.Forms.Label lb_medi_date;
        private System.Windows.Forms.TextBox tb_medi_day;
        private System.Windows.Forms.TextBox tb_medi_month;
        private System.Windows.Forms.TextBox tb_medi_year;
        private System.Windows.Forms.Label lb_slash3;
        private System.Windows.Forms.Label lb_slash2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}