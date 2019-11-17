namespace QuanLyKhachSan
{
    partial class QuanLyDatPhong_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChonPhong_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ChonPhong_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPhong_ComboBox = new System.Windows.Forms.ComboBox();
            this.SearchPhong_TextBox = new System.Windows.Forms.TextBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HopDongMoi_Panel = new System.Windows.Forms.Panel();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ThemNguoiDatvaPhongDat_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDat_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.NgayDuocDat_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.ChonPhong_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.HopDongMoi_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // ChonPhong_Panel
            // 
            this.ChonPhong_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChonPhong_Panel.Controls.Add(this.label6);
            this.ChonPhong_Panel.Controls.Add(this.ChonPhong_Button);
            this.ChonPhong_Panel.Controls.Add(this.panel1);
            this.ChonPhong_Panel.Controls.Add(this.dgvPhong);
            this.ChonPhong_Panel.Location = new System.Drawing.Point(12, 202);
            this.ChonPhong_Panel.Name = "ChonPhong_Panel";
            this.ChonPhong_Panel.Size = new System.Drawing.Size(682, 194);
            this.ChonPhong_Panel.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Chọn Phòng:";
            // 
            // ChonPhong_Button
            // 
            this.ChonPhong_Button.Location = new System.Drawing.Point(577, 153);
            this.ChonPhong_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ChonPhong_Button.Name = "ChonPhong_Button";
            this.ChonPhong_Button.Size = new System.Drawing.Size(100, 31);
            this.ChonPhong_Button.TabIndex = 27;
            this.ChonPhong_Button.Text = "Chọn";
            this.ChonPhong_Button.UseVisualStyleBackColor = true;
            this.ChonPhong_Button.Click += new System.EventHandler(this.ChonPhong_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchPhong_ComboBox);
            this.panel1.Controls.Add(this.SearchPhong_TextBox);
            this.panel1.Location = new System.Drawing.Point(25, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 50);
            this.panel1.TabIndex = 23;
            this.panel1.Tag = "";
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
            // SearchPhong_ComboBox
            // 
            this.SearchPhong_ComboBox.FormattingEnabled = true;
            this.SearchPhong_ComboBox.Items.AddRange(new object[] {
            "Mã Phòng",
            "Loại Phòng",
            "Tình Trạng",
            "Giá Phòng",
            "Mã Nhân Viên Phụ Trách",
            "SĐT"});
            this.SearchPhong_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.SearchPhong_ComboBox.Name = "SearchPhong_ComboBox";
            this.SearchPhong_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchPhong_ComboBox.TabIndex = 12;
            this.SearchPhong_ComboBox.Text = "Mã Phòng";
            // 
            // SearchPhong_TextBox
            // 
            this.SearchPhong_TextBox.Location = new System.Drawing.Point(142, 24);
            this.SearchPhong_TextBox.Name = "SearchPhong_TextBox";
            this.SearchPhong_TextBox.Size = new System.Drawing.Size(177, 20);
            this.SearchPhong_TextBox.TabIndex = 10;
            this.SearchPhong_TextBox.TextChanged += new System.EventHandler(this.SearchPhong_TextBox_TextChanged);
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaPhong,
            this.SDT,
            this.MaNV});
            this.dgvPhong.Location = new System.Drawing.Point(14, 17);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(654, 114);
            this.dgvPhong.TabIndex = 22;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.Name = "GiaPhong";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên Phụ Trách";
            this.MaNV.Name = "MaNV";
            // 
            // HopDongMoi_Panel
            // 
            this.HopDongMoi_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HopDongMoi_Panel.Controls.Add(this.Reset_Button);
            this.HopDongMoi_Panel.Controls.Add(this.Back_Button);
            this.HopDongMoi_Panel.Controls.Add(this.ThemNguoiDatvaPhongDat_Button);
            this.HopDongMoi_Panel.Controls.Add(this.label3);
            this.HopDongMoi_Panel.Controls.Add(this.dgvHD);
            this.HopDongMoi_Panel.Location = new System.Drawing.Point(12, 412);
            this.HopDongMoi_Panel.Name = "HopDongMoi_Panel";
            this.HopDongMoi_Panel.Size = new System.Drawing.Size(682, 111);
            this.HopDongMoi_Panel.TabIndex = 32;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(578, 33);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(99, 27);
            this.Back_Button.TabIndex = 44;
            this.Back_Button.Text = "Trở về ";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ThemNguoiDatvaPhongDat_Button
            // 
            this.ThemNguoiDatvaPhongDat_Button.Location = new System.Drawing.Point(577, 65);
            this.ThemNguoiDatvaPhongDat_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ThemNguoiDatvaPhongDat_Button.Name = "ThemNguoiDatvaPhongDat_Button";
            this.ThemNguoiDatvaPhongDat_Button.Size = new System.Drawing.Size(100, 31);
            this.ThemNguoiDatvaPhongDat_Button.TabIndex = 43;
            this.ThemNguoiDatvaPhongDat_Button.Text = "Thêm Ghi Nhớ";
            this.ThemNguoiDatvaPhongDat_Button.UseVisualStyleBackColor = true;
            this.ThemNguoiDatvaPhongDat_Button.Click += new System.EventHandler(this.ThemNguoiDatvaPhongDat_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Bản ghi nhớ đặt phòng sẽ là: ";
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.dataGridViewTextBoxColumn2,
            this.NgayThue,
            this.NgayKetThuc,
            this.PhongThue});
            this.dgvHD.Location = new System.Drawing.Point(12, 33);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(550, 63);
            this.dgvHD.TabIndex = 41;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Người Đặt";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Người Đặt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NgayThue
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayThue.HeaderText = "Số Điện Thoại";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayKetThuc
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "dd//MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayKetThuc.HeaderText = "Ngày được đặt";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // PhongThue
            // 
            this.PhongThue.HeaderText = "Những phòng được đặt";
            this.PhongThue.Name = "PhongThue";
            // 
            // TenNguoiDat_TextBox
            // 
            this.TenNguoiDat_TextBox.Location = new System.Drawing.Point(109, 41);
            this.TenNguoiDat_TextBox.Name = "TenNguoiDat_TextBox";
            this.TenNguoiDat_TextBox.Size = new System.Drawing.Size(190, 20);
            this.TenNguoiDat_TextBox.TabIndex = 34;
            this.TenNguoiDat_TextBox.TextChanged += new System.EventHandler(this.TenNguoiDat_TextBox_TextChanged);
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Location = new System.Drawing.Point(109, 85);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(190, 20);
            this.SDT_TextBox.TabIndex = 35;
            this.SDT_TextBox.TextChanged += new System.EventHandler(this.SDT_TextBox_TextChanged);
            // 
            // NgayDuocDat_DateTimePicker
            // 
            this.NgayDuocDat_DateTimePicker.Location = new System.Drawing.Point(109, 133);
            this.NgayDuocDat_DateTimePicker.Name = "NgayDuocDat_DateTimePicker";
            this.NgayDuocDat_DateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.NgayDuocDat_DateTimePicker.TabIndex = 36;
            this.NgayDuocDat_DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên người đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ngày được đặt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nhập vào thông tin:";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(578, 3);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(99, 23);
            this.Reset_Button.TabIndex = 45;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // QuanLyDatPhong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 538);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NgayDuocDat_DateTimePicker);
            this.Controls.Add(this.SDT_TextBox);
            this.Controls.Add(this.TenNguoiDat_TextBox);
            this.Controls.Add(this.HopDongMoi_Panel);
            this.Controls.Add(this.ChonPhong_Panel);
            this.Name = "QuanLyDatPhong_Form";
            this.Text = "QuanLyDatPhong";
            this.ChonPhong_Panel.ResumeLayout(false);
            this.ChonPhong_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.HopDongMoi_Panel.ResumeLayout(false);
            this.HopDongMoi_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ChonPhong_Panel;
        private System.Windows.Forms.Button ChonPhong_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchPhong_ComboBox;
        private System.Windows.Forms.TextBox SearchPhong_TextBox;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Panel HopDongMoi_Panel;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button ThemNguoiDatvaPhongDat_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongThue;
        private System.Windows.Forms.TextBox TenNguoiDat_TextBox;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.DateTimePicker NgayDuocDat_DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Reset_Button;
    }
}