namespace QuanLyPhongKham
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_manage = new System.Windows.Forms.TabPage();
            this.lb_reason = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lb_times = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.tb_birthyear = new System.Windows.Forms.TextBox();
            this.lb_birthyear = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_month = new System.Windows.Forms.Label();
            this.lb_day = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lb_slash1 = new System.Windows.Forms.Label();
            this.lb_slash2 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_reason = new System.Windows.Forms.ComboBox();
            this.tab_manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_manage
            // 
            this.tab_manage.Controls.Add(this.combo_reason);
            this.tab_manage.Controls.Add(this.combo_gender);
            this.tab_manage.Controls.Add(this.lb_reason);
            this.tab_manage.Controls.Add(this.tb_date);
            this.tab_manage.Controls.Add(this.btn_del_all);
            this.tab_manage.Controls.Add(this.btn_update);
            this.tab_manage.Controls.Add(this.lb_times);
            this.tab_manage.Controls.Add(this.tb_phone);
            this.tab_manage.Controls.Add(this.lb_phone);
            this.tab_manage.Controls.Add(this.tb_addr);
            this.tab_manage.Controls.Add(this.lb_address);
            this.tab_manage.Controls.Add(this.lb_gender);
            this.tab_manage.Controls.Add(this.tb_birthyear);
            this.tab_manage.Controls.Add(this.lb_birthyear);
            this.tab_manage.Controls.Add(this.tb_id);
            this.tab_manage.Controls.Add(this.tb_name);
            this.tab_manage.Controls.Add(this.tb_search);
            this.tab_manage.Controls.Add(this.tb_year);
            this.tab_manage.Controls.Add(this.tb_month);
            this.tab_manage.Controls.Add(this.tb_day);
            this.tab_manage.Controls.Add(this.lb_name);
            this.tab_manage.Controls.Add(this.lb_id);
            this.tab_manage.Controls.Add(this.btn_load);
            this.tab_manage.Controls.Add(this.data_view);
            this.tab_manage.Controls.Add(this.lb_year);
            this.tab_manage.Controls.Add(this.lb_month);
            this.tab_manage.Controls.Add(this.lb_day);
            this.tab_manage.Controls.Add(this.btn_search);
            this.tab_manage.Controls.Add(this.btn_del);
            this.tab_manage.Controls.Add(this.btn_insert);
            this.tab_manage.Controls.Add(this.lb_slash1);
            this.tab_manage.Controls.Add(this.lb_slash2);
            this.tab_manage.Location = new System.Drawing.Point(4, 29);
            this.tab_manage.Name = "tab_manage";
            this.tab_manage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manage.Size = new System.Drawing.Size(835, 475);
            this.tab_manage.TabIndex = 0;
            this.tab_manage.Text = "Quản lý bệnh nhân";
            this.tab_manage.UseVisualStyleBackColor = true;
            // 
            // lb_reason
            // 
            this.lb_reason.AutoSize = true;
            this.lb_reason.Location = new System.Drawing.Point(3, 311);
            this.lb_reason.Name = "lb_reason";
            this.lb_reason.Size = new System.Drawing.Size(90, 20);
            this.lb_reason.TabIndex = 48;
            this.lb_reason.Text = "Lý do khám";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(90, 270);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(90, 26);
            this.tb_date.TabIndex = 47;
            // 
            // btn_del_all
            // 
            this.btn_del_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_all.Location = new System.Drawing.Point(717, 74);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(99, 38);
            this.btn_del_all.TabIndex = 46;
            this.btn_del_all.Text = "Xóa tất cả";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(120, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 34);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lb_times
            // 
            this.lb_times.AutoSize = true;
            this.lb_times.Location = new System.Drawing.Point(3, 273);
            this.lb_times.Name = "lb_times";
            this.lb_times.Size = new System.Drawing.Size(88, 20);
            this.lb_times.TabIndex = 44;
            this.lb_times.Text = "Ngày khám";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(213, 119);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(109, 26);
            this.tb_phone.TabIndex = 42;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(171, 122);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(41, 20);
            this.lb_phone.TabIndex = 41;
            this.lb_phone.Text = "SĐT";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(87, 232);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(235, 26);
            this.tb_addr.TabIndex = 40;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(6, 232);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(57, 20);
            this.lb_address.TabIndex = 39;
            this.lb_address.Text = "Địa chỉ";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(171, 198);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(67, 20);
            this.lb_gender.TabIndex = 37;
            this.lb_gender.Text = "Giới tính";
            // 
            // tb_birthyear
            // 
            this.tb_birthyear.Location = new System.Drawing.Point(87, 195);
            this.tb_birthyear.Name = "tb_birthyear";
            this.tb_birthyear.Size = new System.Drawing.Size(70, 26);
            this.tb_birthyear.TabIndex = 36;
            // 
            // lb_birthyear
            // 
            this.lb_birthyear.AutoSize = true;
            this.lb_birthyear.Location = new System.Drawing.Point(6, 198);
            this.lb_birthyear.Name = "lb_birthyear";
            this.lb_birthyear.Size = new System.Drawing.Size(75, 20);
            this.lb_birthyear.TabIndex = 35;
            this.lb_birthyear.Text = "Năm sinh";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(87, 119);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(70, 26);
            this.tb_id.TabIndex = 34;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(87, 157);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(235, 26);
            this.tb_name.TabIndex = 32;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(389, 22);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(255, 28);
            this.tb_search.TabIndex = 22;
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_year.Location = new System.Drawing.Point(203, 24);
            this.tb_year.Multiline = true;
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(58, 28);
            this.tb_year.TabIndex = 20;
            // 
            // tb_month
            // 
            this.tb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_month.Location = new System.Drawing.Point(139, 24);
            this.tb_month.Multiline = true;
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(34, 28);
            this.tb_month.TabIndex = 18;
            // 
            // tb_day
            // 
            this.tb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_day.Location = new System.Drawing.Point(75, 24);
            this.tb_day.Multiline = true;
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(34, 28);
            this.tb_day.TabIndex = 17;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(6, 160);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(57, 20);
            this.lb_name.TabIndex = 33;
            this.lb_name.Text = "Họ tên";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(6, 122);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(58, 20);
            this.lb_id.TabIndex = 31;
            this.lb_id.Text = "Mã HS";
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(354, 74);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(62, 38);
            this.btn_load.TabIndex = 30;
            this.btn_load.Text = "Xem";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click_1);
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Location = new System.Drawing.Point(328, 118);
            this.data_view.Name = "data_view";
            this.data_view.ReadOnly = true;
            this.data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_view.Size = new System.Drawing.Size(507, 357);
            this.data_view.TabIndex = 29;
            this.data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_CellClick);
            this.data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_CellContentClick);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_year.Location = new System.Drawing.Point(210, 5);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(32, 13);
            this.lb_year.TabIndex = 28;
            this.lb_year.Text = "Năm";
            // 
            // lb_month
            // 
            this.lb_month.AutoSize = true;
            this.lb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_month.Location = new System.Drawing.Point(134, 5);
            this.lb_month.Name = "lb_month";
            this.lb_month.Size = new System.Drawing.Size(43, 13);
            this.lb_month.TabIndex = 27;
            this.lb_month.Text = "Tháng";
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_day.Location = new System.Drawing.Point(75, 5);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(36, 13);
            this.lb_day.TabIndex = 26;
            this.lb_day.Text = "Ngày";
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(673, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 33);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(616, 74);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(68, 38);
            this.btn_del.TabIndex = 24;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(446, 74);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(138, 38);
            this.btn_insert.TabIndex = 23;
            this.btn_insert.Text = "Thêm bệnh nhân ";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // lb_slash1
            // 
            this.lb_slash1.AutoSize = true;
            this.lb_slash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash1.Location = new System.Drawing.Point(115, 24);
            this.lb_slash1.Name = "lb_slash1";
            this.lb_slash1.Size = new System.Drawing.Size(18, 25);
            this.lb_slash1.TabIndex = 21;
            this.lb_slash1.Text = "/";
            // 
            // lb_slash2
            // 
            this.lb_slash2.AutoSize = true;
            this.lb_slash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash2.Location = new System.Drawing.Point(179, 24);
            this.lb_slash2.Name = "lb_slash2";
            this.lb_slash2.Size = new System.Drawing.Size(18, 25);
            this.lb_slash2.TabIndex = 19;
            this.lb_slash2.Text = "/";
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tab_manage);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(2, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(843, 508);
            this.tab.TabIndex = 0;
            // 
            // combo_gender
            // 
            this.combo_gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.combo_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combo_gender.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.combo_gender.Location = new System.Drawing.Point(234, 195);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(88, 28);
            this.combo_gender.TabIndex = 50;
            // 
            // combo_reason
            // 
            this.combo_reason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_reason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_reason.FormattingEnabled = true;
            this.combo_reason.Items.AddRange(new object[] {
            "Mắt",
            "Cột sống"});
            this.combo_reason.Location = new System.Drawing.Point(90, 308);
            this.combo_reason.Name = "combo_reason";
            this.combo_reason.Size = new System.Drawing.Size(90, 28);
            this.combo_reason.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quản lý hồ sơ bệnh nhân";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_manage.ResumeLayout(false);
            this.tab_manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_manage;
        private System.Windows.Forms.TextBox tb_birthyear;
        private System.Windows.Forms.Label lb_birthyear;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_month;
        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lb_slash1;
        private System.Windows.Forms.Label lb_slash2;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_times;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Label lb_reason;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.ComboBox combo_reason;
    }
}

