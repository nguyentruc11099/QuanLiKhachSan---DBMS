namespace QuanLyKhachSan
{
    partial class TraPhong_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTien_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ThanhToan_Button = new System.Windows.Forms.Button();
            this.Today_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Today_Label = new System.Windows.Forms.Label();
            this.Choose_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhongvaHD = new System.Windows.Forms.DataGridView();
            this.dataGridViwTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đajdasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDVvaHD = new System.Windows.Forms.DataGridView();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongvaHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(26, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 51);
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
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayThue.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.DataPropertyName = "NgayDuKienTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày Hết Hạn Phòng";
            this.NgayTraPhong.Name = "NgayTraPhong";
            // 
            // TinhTien_RichTextBox
            // 
            this.TinhTien_RichTextBox.Location = new System.Drawing.Point(12, 625);
            this.TinhTien_RichTextBox.Name = "TinhTien_RichTextBox";
            this.TinhTien_RichTextBox.Size = new System.Drawing.Size(570, 181);
            this.TinhTien_RichTextBox.TabIndex = 53;
            this.TinhTien_RichTextBox.Text = "";
            // 
            // ThanhToan_Button
            // 
            this.ThanhToan_Button.Location = new System.Drawing.Point(597, 728);
            this.ThanhToan_Button.Name = "ThanhToan_Button";
            this.ThanhToan_Button.Size = new System.Drawing.Size(75, 23);
            this.ThanhToan_Button.TabIndex = 54;
            this.ThanhToan_Button.Text = "Thanh Toán ";
            this.ThanhToan_Button.UseVisualStyleBackColor = true;
            this.ThanhToan_Button.Click += new System.EventHandler(this.ThanhToan_Button_Click);
            // 
            // Today_DateTimePicker
            // 
            this.Today_DateTimePicker.Enabled = false;
            this.Today_DateTimePicker.Location = new System.Drawing.Point(450, 2);
            this.Today_DateTimePicker.Name = "Today_DateTimePicker";
            this.Today_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Today_DateTimePicker.TabIndex = 55;
            // 
            // Today_Label
            // 
            this.Today_Label.AutoSize = true;
            this.Today_Label.Location = new System.Drawing.Point(375, 9);
            this.Today_Label.Name = "Today_Label";
            this.Today_Label.Size = new System.Drawing.Size(54, 13);
            this.Today_Label.TabIndex = 56;
            this.Today_Label.Text = "Hôm Nay:";
            // 
            // Choose_Button
            // 
            this.Choose_Button.Location = new System.Drawing.Point(400, 164);
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
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Lựa chọn hợp đồng tương ứng với khách hàng:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvHD);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Choose_Button);
            this.panel2.Location = new System.Drawing.Point(11, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 205);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvPhongvaHD);
            this.panel3.Controls.Add(this.dgvDVvaHD);
            this.panel3.Location = new System.Drawing.Point(11, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 340);
            this.panel3.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Phòng được thuê tương ứng bỏi hợp đồng đã chọn:";
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
            // dgvPhongvaHD
            // 
            this.dgvPhongvaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongvaHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViwTextBoxColumn5,
            this.MaPhong,
            this.LoaiPhong,
            this.TienPhong,
            this.đajdasd,
            this.NgayTra});
            this.dgvPhongvaHD.Location = new System.Drawing.Point(9, 191);
            this.dgvPhongvaHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhongvaHD.Name = "dgvPhongvaHD";
            this.dgvPhongvaHD.RowTemplate.Height = 24;
            this.dgvPhongvaHD.Size = new System.Drawing.Size(660, 138);
            this.dgvPhongvaHD.TabIndex = 62;
            // 
            // dataGridViwTextBoxColumn5
            // 
            this.dataGridViwTextBoxColumn5.DataPropertyName = "MaHopDong";
            this.dataGridViwTextBoxColumn5.HeaderText = "Mã Hợp Đồng";
            this.dataGridViwTextBoxColumn5.Name = "dataGridViwTextBoxColumn5";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            this.MaPhong.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // TienPhong
            // 
            this.TienPhong.DataPropertyName = "GiaPhong";
            this.TienPhong.HeaderText = "Tiền Phòng";
            this.TienPhong.Name = "TienPhong";
            // 
            // đajdasd
            // 
            this.đajdasd.DataPropertyName = "NgayThue";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.NullValue = null;
            this.đajdasd.DefaultCellStyle = dataGridViewCellStyle8;
            this.đajdasd.HeaderText = "Ngày Thuê";
            this.đajdasd.Name = "đajdasd";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayDuKienTraPhong";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.NgayTra.DefaultCellStyle = dataGridViewCellStyle9;
            this.NgayTra.HeaderText = "Ngày Hết Hạn Phòng";
            this.NgayTra.Name = "NgayTra";
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
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = null;
            this.SoNgaySD.DefaultCellStyle = dataGridViewCellStyle10;
            this.SoNgaySD.HeaderText = "Số Lần Sử Dụng";
            this.SoNgaySD.Name = "SoNgaySD";
            // 
            // TienDichVu
            // 
            this.TienDichVu.DataPropertyName = "GiaDV";
            this.TienDichVu.HeaderText = "Tiền Dịch Vụ Mỗi Ngày";
            this.TienDichVu.Name = "TienDichVu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tổng quát số tiền:";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(597, 683);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 64;
            this.Back_Button.Text = "Trở Về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // TraPhong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 818);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Today_Label);
            this.Controls.Add(this.Today_DateTimePicker);
            this.Controls.Add(this.ThanhToan_Button);
            this.Controls.Add(this.TinhTien_RichTextBox);
            this.Name = "TraPhong_Form";
            this.Text = "TraPhong_Form";
            this.Load += new System.EventHandler(this.TraPhong_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongvaHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.RichTextBox TinhTien_RichTextBox;
        private System.Windows.Forms.Button ThanhToan_Button;
        private System.Windows.Forms.DateTimePicker Today_DateTimePicker;
        private System.Windows.Forms.Label Today_Label;
        private System.Windows.Forms.Button Choose_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhongvaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViwTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn đajdasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridView dgvDVvaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_Button;
    }
}