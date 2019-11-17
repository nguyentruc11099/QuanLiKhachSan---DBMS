namespace QuanLyKhachSan
{
    partial class QuanLyHoatDongDichVu_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Choose_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDVvaHD = new System.Windows.Forms.DataGridView();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchDV_ComboBox = new System.Windows.Forms.ComboBox();
            this.SearchDV_TextBox = new System.Windows.Forms.TextBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemDichVu_Panel = new System.Windows.Forms.Panel();
            this.ChonThemDichVu_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Them_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HienSoLanSuDung_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.ThemDichVu_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Them_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienSoLanSuDung_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvHD);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Choose_Button);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 205);
            this.panel2.TabIndex = 63;
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.TenKH,
            this.NgayThue,
            this.NgayTraPhong});
            this.dgvHD.Location = new System.Drawing.Point(26, 13);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(634, 124);
            this.dgvHD.TabIndex = 49;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHopDong";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // NgayThue
            // 
            this.NgayThue.DataPropertyName = "NgayThue";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            dataGridViewCellStyle13.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle13;
            this.NgayThue.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.DataPropertyName = "NgayDuKienTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày Hết Hạn Phòng";
            this.NgayTraPhong.Name = "NgayTraPhong";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(26, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 51);
            this.panel1.TabIndex = 50;
            this.panel1.Tag = "";
            // 
            // Search_ComboBox
            // 
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "Mã Hợp Đồng",
            "Mã Khách Hàng",
            "Ngày Thuê Phòng",
            "Ngày Dự Kiến Trả",
            "Tên Khách Hàng"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(159, 23);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // Choose_Button
            // 
            this.Choose_Button.Location = new System.Drawing.Point(543, 165);
            this.Choose_Button.Name = "Choose_Button";
            this.Choose_Button.Size = new System.Drawing.Size(75, 23);
            this.Choose_Button.TabIndex = 57;
            this.Choose_Button.Text = "Chọn";
            this.Choose_Button.UseVisualStyleBackColor = true;
            this.Choose_Button.Click += new System.EventHandler(this.Choose_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Lựa chọn hợp đồng tương ứng với khách hàng:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Edit_Button);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Save_Button);
            this.panel3.Controls.Add(this.HienSoLanSuDung_NumericUpDown);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvDVvaHD);
            this.panel3.Location = new System.Drawing.Point(16, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 209);
            this.panel3.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Dịch vụ tương ứng với hợp đồng đã chọn:";
            // 
            // dgvDVvaHD
            // 
            this.dgvDVvaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVvaHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.MaDV,
            this.TenDV,
            this.SoNgaySD,
            this.TienDichVu});
            this.dgvDVvaHD.Location = new System.Drawing.Point(10, 27);
            this.dgvDVvaHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDVvaHD.Name = "dgvDVvaHD";
            this.dgvDVvaHD.RowTemplate.Height = 24;
            this.dgvDVvaHD.Size = new System.Drawing.Size(660, 138);
            this.dgvDVvaHD.TabIndex = 61;
            this.dgvDVvaHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVvaHD_CellClick);
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHD";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.Name = "MaHopDong";
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.Name = "TenDV";
            // 
            // SoNgaySD
            // 
            this.SoNgaySD.DataPropertyName = "SoNgaySD";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.NullValue = null;
            this.SoNgaySD.DefaultCellStyle = dataGridViewCellStyle14;
            this.SoNgaySD.HeaderText = "Số Lần Sử Dụng";
            this.SoNgaySD.Name = "SoNgaySD";
            // 
            // TienDichVu
            // 
            this.TienDichVu.DataPropertyName = "GiaDV";
            this.TienDichVu.HeaderText = "Tiền Dịch Vụ Mỗi Ngày";
            this.TienDichVu.Name = "TienDichVu";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.SearchDV_ComboBox);
            this.panel4.Controls.Add(this.SearchDV_TextBox);
            this.panel4.Location = new System.Drawing.Point(12, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 44);
            this.panel4.TabIndex = 66;
            this.panel4.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tìm kiếm";
            // 
            // SearchDV_ComboBox
            // 
            this.SearchDV_ComboBox.FormattingEnabled = true;
            this.SearchDV_ComboBox.Items.AddRange(new object[] {
            "Mã Dịch Vụ",
            "Tên Dịch Vụ",
            "Giá Dịch Vụ"});
            this.SearchDV_ComboBox.Location = new System.Drawing.Point(3, 16);
            this.SearchDV_ComboBox.Name = "SearchDV_ComboBox";
            this.SearchDV_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchDV_ComboBox.TabIndex = 12;
            this.SearchDV_ComboBox.Text = "Mã Dịch Vụ";
            // 
            // SearchDV_TextBox
            // 
            this.SearchDV_TextBox.Location = new System.Drawing.Point(141, 16);
            this.SearchDV_TextBox.Name = "SearchDV_TextBox";
            this.SearchDV_TextBox.Size = new System.Drawing.Size(177, 20);
            this.SearchDV_TextBox.TabIndex = 10;
            this.SearchDV_TextBox.TextChanged += new System.EventHandler(this.SearchDV_TextBox_TextChanged);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.GiaDV});
            this.dgvDV.Location = new System.Drawing.Point(12, 6);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(487, 55);
            this.dgvDV.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Dịch Vụ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Dịch Vụ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Giá Dịch Vụ ";
            this.GiaDV.Name = "GiaDV";
            // 
            // ThemDichVu_Panel
            // 
            this.ThemDichVu_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemDichVu_Panel.Controls.Add(this.Them_NumericUpDown);
            this.ThemDichVu_Panel.Controls.Add(this.ChonThemDichVu_Button);
            this.ThemDichVu_Panel.Controls.Add(this.dgvDV);
            this.ThemDichVu_Panel.Controls.Add(this.panel4);
            this.ThemDichVu_Panel.Location = new System.Drawing.Point(12, 281);
            this.ThemDichVu_Panel.Name = "ThemDichVu_Panel";
            this.ThemDichVu_Panel.Size = new System.Drawing.Size(677, 113);
            this.ThemDichVu_Panel.TabIndex = 67;
            // 
            // ChonThemDichVu_Button
            // 
            this.ChonThemDichVu_Button.Location = new System.Drawing.Point(544, 78);
            this.ChonThemDichVu_Button.Name = "ChonThemDichVu_Button";
            this.ChonThemDichVu_Button.Size = new System.Drawing.Size(75, 23);
            this.ChonThemDichVu_Button.TabIndex = 67;
            this.ChonThemDichVu_Button.Text = "Thêm";
            this.ChonThemDichVu_Button.UseVisualStyleBackColor = true;
            this.ChonThemDichVu_Button.Click += new System.EventHandler(this.ChonThemDichVu_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(595, 172);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 70;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Them_NumericUpDown
            // 
            this.Them_NumericUpDown.Location = new System.Drawing.Point(392, 80);
            this.Them_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Them_NumericUpDown.Name = "Them_NumericUpDown";
            this.Them_NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Them_NumericUpDown.TabIndex = 68;
            this.Them_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HienSoLanSuDung_NumericUpDown
            // 
            this.HienSoLanSuDung_NumericUpDown.Location = new System.Drawing.Point(108, 173);
            this.HienSoLanSuDung_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HienSoLanSuDung_NumericUpDown.Name = "HienSoLanSuDung_NumericUpDown";
            this.HienSoLanSuDung_NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HienSoLanSuDung_NumericUpDown.TabIndex = 71;
            this.HienSoLanSuDung_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(502, 173);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Button.TabIndex = 68;
            this.Edit_Button.Text = "Thay đổi";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Số lần sử dụng";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(556, 662);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 69;
            this.Back_Button.Text = "Trở về ";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // QuanLyHoatDongDichVu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 699);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ThemDichVu_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHoatDongDichVu_Form";
            this.Text = "QuanLyHoatDongDichVu_Form";
            this.Load += new System.EventHandler(this.QuanLyHoatDongDichVu_Form_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ThemDichVu_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Them_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienSoLanSuDung_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Choose_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDVvaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDichVu;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.NumericUpDown HienSoLanSuDung_NumericUpDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchDV_ComboBox;
        private System.Windows.Forms.TextBox SearchDV_TextBox;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.Panel ThemDichVu_Panel;
        private System.Windows.Forms.NumericUpDown Them_NumericUpDown;
        private System.Windows.Forms.Button ChonThemDichVu_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}