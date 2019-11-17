namespace QuanLyKhachSan
{
    partial class NhanPhongKhongDatTruoc_Form
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
            this.Inside_RadioButton = new System.Windows.Forms.RadioButton();
            this.Outside_RadioButton = new System.Windows.Forms.RadioButton();
            this.KhachHangMoi_Panel = new System.Windows.Forms.Panel();
            this.TenKH_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_Label = new System.Windows.Forms.Label();
            this.Nu_RadioButton = new System.Windows.Forms.RadioButton();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Nam_RadioButton = new System.Windows.Forms.RadioButton();
            this.XuatXu_TextBox = new System.Windows.Forms.TextBox();
            this.CMND_TextBox = new System.Windows.Forms.TextBox();
            this.MaKH_TextBox = new System.Windows.Forms.TextBox();
            this.XuatXu_Label = new System.Windows.Forms.Label();
            this.GioiTinh_Label = new System.Windows.Forms.Label();
            this.CMND_Label = new System.Windows.Forms.Label();
            this.TenKH_Label = new System.Windows.Forms.Label();
            this.MaKH_Label = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchKH_ComboBox = new System.Windows.Forms.ComboBox();
            this.SearchKH_TextBox = new System.Windows.Forms.TextBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Today_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Today_Label = new System.Windows.Forms.Label();
            this.ChonKhachHang_Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SoNgayO_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChonKH_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ChonPhong_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ChonPhong_Button = new System.Windows.Forms.Button();
            this.HopDongMoi_Panel = new System.Windows.Forms.Panel();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ThemHD_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.KhachHangMoi_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.ChonKhachHang_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoNgayO_NumericUpDown)).BeginInit();
            this.ChonPhong_Panel.SuspendLayout();
            this.HopDongMoi_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // Inside_RadioButton
            // 
            this.Inside_RadioButton.AutoSize = true;
            this.Inside_RadioButton.Checked = true;
            this.Inside_RadioButton.Location = new System.Drawing.Point(53, 13);
            this.Inside_RadioButton.Name = "Inside_RadioButton";
            this.Inside_RadioButton.Size = new System.Drawing.Size(145, 17);
            this.Inside_RadioButton.TabIndex = 0;
            this.Inside_RadioButton.TabStop = true;
            this.Inside_RadioButton.Text = "Khách hàng đã từng đến";
            this.Inside_RadioButton.UseVisualStyleBackColor = true;
            this.Inside_RadioButton.CheckedChanged += new System.EventHandler(this.Inside_RadioButton_CheckedChanged);
            // 
            // Outside_RadioButton
            // 
            this.Outside_RadioButton.AutoSize = true;
            this.Outside_RadioButton.Location = new System.Drawing.Point(204, 13);
            this.Outside_RadioButton.Name = "Outside_RadioButton";
            this.Outside_RadioButton.Size = new System.Drawing.Size(137, 17);
            this.Outside_RadioButton.TabIndex = 1;
            this.Outside_RadioButton.TabStop = true;
            this.Outside_RadioButton.Text = "Khách đến lần đầu tiên";
            this.Outside_RadioButton.UseVisualStyleBackColor = true;
            // 
            // KhachHangMoi_Panel
            // 
            this.KhachHangMoi_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KhachHangMoi_Panel.Controls.Add(this.TenKH_TextBox);
            this.KhachHangMoi_Panel.Controls.Add(this.SDT_TextBox);
            this.KhachHangMoi_Panel.Controls.Add(this.SDT_Label);
            this.KhachHangMoi_Panel.Controls.Add(this.Nu_RadioButton);
            this.KhachHangMoi_Panel.Controls.Add(this.Add_Button);
            this.KhachHangMoi_Panel.Controls.Add(this.Nam_RadioButton);
            this.KhachHangMoi_Panel.Controls.Add(this.XuatXu_TextBox);
            this.KhachHangMoi_Panel.Controls.Add(this.CMND_TextBox);
            this.KhachHangMoi_Panel.Controls.Add(this.MaKH_TextBox);
            this.KhachHangMoi_Panel.Controls.Add(this.XuatXu_Label);
            this.KhachHangMoi_Panel.Controls.Add(this.GioiTinh_Label);
            this.KhachHangMoi_Panel.Controls.Add(this.CMND_Label);
            this.KhachHangMoi_Panel.Controls.Add(this.TenKH_Label);
            this.KhachHangMoi_Panel.Controls.Add(this.MaKH_Label);
            this.KhachHangMoi_Panel.Location = new System.Drawing.Point(53, 44);
            this.KhachHangMoi_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.KhachHangMoi_Panel.Name = "KhachHangMoi_Panel";
            this.KhachHangMoi_Panel.Size = new System.Drawing.Size(682, 95);
            this.KhachHangMoi_Panel.TabIndex = 16;
            // 
            // TenKH_TextBox
            // 
            this.TenKH_TextBox.Location = new System.Drawing.Point(100, 51);
            this.TenKH_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenKH_TextBox.Name = "TenKH_TextBox";
            this.TenKH_TextBox.Size = new System.Drawing.Size(120, 20);
            this.TenKH_TextBox.TabIndex = 19;
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Location = new System.Drawing.Point(285, 51);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(90, 20);
            this.SDT_TextBox.TabIndex = 18;
            // 
            // SDT_Label
            // 
            this.SDT_Label.AutoSize = true;
            this.SDT_Label.Location = new System.Drawing.Point(236, 58);
            this.SDT_Label.Name = "SDT_Label";
            this.SDT_Label.Size = new System.Drawing.Size(29, 13);
            this.SDT_Label.TabIndex = 17;
            this.SDT_Label.Text = "SĐT";
            // 
            // Nu_RadioButton
            // 
            this.Nu_RadioButton.AutoSize = true;
            this.Nu_RadioButton.Location = new System.Drawing.Point(477, 71);
            this.Nu_RadioButton.Name = "Nu_RadioButton";
            this.Nu_RadioButton.Size = new System.Drawing.Size(39, 17);
            this.Nu_RadioButton.TabIndex = 16;
            this.Nu_RadioButton.TabStop = true;
            this.Nu_RadioButton.Text = "Nữ";
            this.Nu_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(568, 56);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 20;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Nam_RadioButton
            // 
            this.Nam_RadioButton.AutoSize = true;
            this.Nam_RadioButton.Location = new System.Drawing.Point(477, 47);
            this.Nam_RadioButton.Name = "Nam_RadioButton";
            this.Nam_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.Nam_RadioButton.TabIndex = 15;
            this.Nam_RadioButton.TabStop = true;
            this.Nam_RadioButton.Text = "Nam";
            this.Nam_RadioButton.UseVisualStyleBackColor = true;
            // 
            // XuatXu_TextBox
            // 
            this.XuatXu_TextBox.Location = new System.Drawing.Point(464, 13);
            this.XuatXu_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XuatXu_TextBox.Name = "XuatXu_TextBox";
            this.XuatXu_TextBox.Size = new System.Drawing.Size(127, 20);
            this.XuatXu_TextBox.TabIndex = 14;
            // 
            // CMND_TextBox
            // 
            this.CMND_TextBox.Location = new System.Drawing.Point(285, 13);
            this.CMND_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CMND_TextBox.Name = "CMND_TextBox";
            this.CMND_TextBox.Size = new System.Drawing.Size(90, 20);
            this.CMND_TextBox.TabIndex = 12;
            // 
            // MaKH_TextBox
            // 
            this.MaKH_TextBox.Location = new System.Drawing.Point(100, 13);
            this.MaKH_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaKH_TextBox.Name = "MaKH_TextBox";
            this.MaKH_TextBox.Size = new System.Drawing.Size(120, 20);
            this.MaKH_TextBox.TabIndex = 8;
            // 
            // XuatXu_Label
            // 
            this.XuatXu_Label.AutoSize = true;
            this.XuatXu_Label.Location = new System.Drawing.Point(386, 13);
            this.XuatXu_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XuatXu_Label.Name = "XuatXu_Label";
            this.XuatXu_Label.Size = new System.Drawing.Size(45, 13);
            this.XuatXu_Label.TabIndex = 6;
            this.XuatXu_Label.Text = "Xuất Xứ";
            // 
            // GioiTinh_Label
            // 
            this.GioiTinh_Label.AutoSize = true;
            this.GioiTinh_Label.Location = new System.Drawing.Point(386, 56);
            this.GioiTinh_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiTinh_Label.Name = "GioiTinh_Label";
            this.GioiTinh_Label.Size = new System.Drawing.Size(51, 13);
            this.GioiTinh_Label.TabIndex = 5;
            this.GioiTinh_Label.Text = "Giới Tính";
            // 
            // CMND_Label
            // 
            this.CMND_Label.AutoSize = true;
            this.CMND_Label.Location = new System.Drawing.Point(236, 16);
            this.CMND_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CMND_Label.Name = "CMND_Label";
            this.CMND_Label.Size = new System.Drawing.Size(39, 13);
            this.CMND_Label.TabIndex = 3;
            this.CMND_Label.Text = "CMND";
            // 
            // TenKH_Label
            // 
            this.TenKH_Label.AutoSize = true;
            this.TenKH_Label.Location = new System.Drawing.Point(11, 51);
            this.TenKH_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenKH_Label.Name = "TenKH_Label";
            this.TenKH_Label.Size = new System.Drawing.Size(89, 13);
            this.TenKH_Label.TabIndex = 2;
            this.TenKH_Label.Text = "Tên Khách Hàng";
            // 
            // MaKH_Label
            // 
            this.MaKH_Label.AutoSize = true;
            this.MaKH_Label.Location = new System.Drawing.Point(11, 16);
            this.MaKH_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaKH_Label.Name = "MaKH_Label";
            this.MaKH_Label.Size = new System.Drawing.Size(85, 13);
            this.MaKH_Label.TabIndex = 0;
            this.MaKH_Label.Text = "Mã Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchPhong_ComboBox);
            this.panel1.Controls.Add(this.SearchPhong_TextBox);
            this.panel1.Location = new System.Drawing.Point(25, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 40);
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
            this.SearchPhong_ComboBox.Location = new System.Drawing.Point(42, 9);
            this.SearchPhong_ComboBox.Name = "SearchPhong_ComboBox";
            this.SearchPhong_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchPhong_ComboBox.TabIndex = 12;
            this.SearchPhong_ComboBox.Text = "Mã Phòng";
            // 
            // SearchPhong_TextBox
            // 
            this.SearchPhong_TextBox.Location = new System.Drawing.Point(169, 9);
            this.SearchPhong_TextBox.Name = "SearchPhong_TextBox";
            this.SearchPhong_TextBox.Size = new System.Drawing.Size(162, 20);
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
            this.dgvPhong.Location = new System.Drawing.Point(14, 27);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SearchKH_ComboBox);
            this.panel2.Controls.Add(this.SearchKH_TextBox);
            this.panel2.Location = new System.Drawing.Point(25, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 36);
            this.panel2.TabIndex = 25;
            this.panel2.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm kiếm";
            // 
            // SearchKH_ComboBox
            // 
            this.SearchKH_ComboBox.FormattingEnabled = true;
            this.SearchKH_ComboBox.Items.AddRange(new object[] {
            "Mã KH",
            "Tên KH",
            "CMND",
            "Giới Tính",
            "SĐT",
            "Xuất Xứ"});
            this.SearchKH_ComboBox.Location = new System.Drawing.Point(42, 10);
            this.SearchKH_ComboBox.Name = "SearchKH_ComboBox";
            this.SearchKH_ComboBox.Size = new System.Drawing.Size(109, 21);
            this.SearchKH_ComboBox.TabIndex = 12;
            this.SearchKH_ComboBox.Text = "Mã KH";
            // 
            // SearchKH_TextBox
            // 
            this.SearchKH_TextBox.Location = new System.Drawing.Point(157, 11);
            this.SearchKH_TextBox.Name = "SearchKH_TextBox";
            this.SearchKH_TextBox.Size = new System.Drawing.Size(174, 20);
            this.SearchKH_TextBox.TabIndex = 10;
            this.SearchKH_TextBox.TextChanged += new System.EventHandler(this.SearchKH_TextBox_TextChanged);
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.dataGridViewTextBoxColumn1,
            this.XuatXu});
            this.dgvKH.Location = new System.Drawing.Point(12, 36);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(634, 100);
            this.dgvKH.TabIndex = 24;
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
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn1.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất Xứ";
            this.XuatXu.Name = "XuatXu";
            // 
            // Today_DateTimePicker
            // 
            this.Today_DateTimePicker.Location = new System.Drawing.Point(547, 2);
            this.Today_DateTimePicker.Name = "Today_DateTimePicker";
            this.Today_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Today_DateTimePicker.TabIndex = 26;
            // 
            // Today_Label
            // 
            this.Today_Label.AutoSize = true;
            this.Today_Label.Location = new System.Drawing.Point(487, 2);
            this.Today_Label.Name = "Today_Label";
            this.Today_Label.Size = new System.Drawing.Size(54, 13);
            this.Today_Label.TabIndex = 27;
            this.Today_Label.Text = "Hôm Nay:";
            // 
            // ChonKhachHang_Panel
            // 
            this.ChonKhachHang_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChonKhachHang_Panel.Controls.Add(this.label5);
            this.ChonKhachHang_Panel.Controls.Add(this.SoNgayO_NumericUpDown);
            this.ChonKhachHang_Panel.Controls.Add(this.ChonKH_Button);
            this.ChonKhachHang_Panel.Controls.Add(this.label4);
            this.ChonKhachHang_Panel.Controls.Add(this.panel2);
            this.ChonKhachHang_Panel.Controls.Add(this.dgvKH);
            this.ChonKhachHang_Panel.Location = new System.Drawing.Point(53, 144);
            this.ChonKhachHang_Panel.Name = "ChonKhachHang_Panel";
            this.ChonKhachHang_Panel.Size = new System.Drawing.Size(682, 203);
            this.ChonKhachHang_Panel.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chọn khách hàng:";
            // 
            // SoNgayO_NumericUpDown
            // 
            this.SoNgayO_NumericUpDown.Location = new System.Drawing.Point(464, 168);
            this.SoNgayO_NumericUpDown.Name = "SoNgayO_NumericUpDown";
            this.SoNgayO_NumericUpDown.Size = new System.Drawing.Size(98, 20);
            this.SoNgayO_NumericUpDown.TabIndex = 32;
            this.SoNgayO_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SoNgayO_NumericUpDown.ValueChanged += new System.EventHandler(this.SoNgayO_NumericUpDown_ValueChanged);
            // 
            // ChonKH_Button
            // 
            this.ChonKH_Button.Location = new System.Drawing.Point(579, 164);
            this.ChonKH_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ChonKH_Button.Name = "ChonKH_Button";
            this.ChonKH_Button.Size = new System.Drawing.Size(100, 31);
            this.ChonKH_Button.TabIndex = 26;
            this.ChonKH_Button.Text = "Chọn";
            this.ChonKH_Button.UseVisualStyleBackColor = true;
            this.ChonKH_Button.Click += new System.EventHandler(this.ChonKH_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Số ngày ở dự kiến";
            // 
            // ChonPhong_Panel
            // 
            this.ChonPhong_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChonPhong_Panel.Controls.Add(this.label6);
            this.ChonPhong_Panel.Controls.Add(this.ChonPhong_Button);
            this.ChonPhong_Panel.Controls.Add(this.panel1);
            this.ChonPhong_Panel.Controls.Add(this.dgvPhong);
            this.ChonPhong_Panel.Location = new System.Drawing.Point(53, 368);
            this.ChonPhong_Panel.Name = "ChonPhong_Panel";
            this.ChonPhong_Panel.Size = new System.Drawing.Size(682, 197);
            this.ChonPhong_Panel.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Chọn Phòng: ";
            // 
            // ChonPhong_Button
            // 
            this.ChonPhong_Button.Location = new System.Drawing.Point(578, 162);
            this.ChonPhong_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ChonPhong_Button.Name = "ChonPhong_Button";
            this.ChonPhong_Button.Size = new System.Drawing.Size(100, 31);
            this.ChonPhong_Button.TabIndex = 27;
            this.ChonPhong_Button.Text = "Chọn";
            this.ChonPhong_Button.UseVisualStyleBackColor = true;
            this.ChonPhong_Button.Click += new System.EventHandler(this.ChonPhong_Button_Click);
            // 
            // HopDongMoi_Panel
            // 
            this.HopDongMoi_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HopDongMoi_Panel.Controls.Add(this.Reset_Button);
            this.HopDongMoi_Panel.Controls.Add(this.Back_Button);
            this.HopDongMoi_Panel.Controls.Add(this.ThemHD_Button);
            this.HopDongMoi_Panel.Controls.Add(this.label3);
            this.HopDongMoi_Panel.Controls.Add(this.dgvHD);
            this.HopDongMoi_Panel.Location = new System.Drawing.Point(53, 606);
            this.HopDongMoi_Panel.Name = "HopDongMoi_Panel";
            this.HopDongMoi_Panel.Size = new System.Drawing.Size(682, 111);
            this.HopDongMoi_Panel.TabIndex = 31;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(580, 33);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(99, 27);
            this.Back_Button.TabIndex = 44;
            this.Back_Button.Text = "Trở về ";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ThemHD_Button
            // 
            this.ThemHD_Button.Location = new System.Drawing.Point(580, 65);
            this.ThemHD_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ThemHD_Button.Name = "ThemHD_Button";
            this.ThemHD_Button.Size = new System.Drawing.Size(100, 31);
            this.ThemHD_Button.TabIndex = 43;
            this.ThemHD_Button.Text = "Thêm Hợp Đồng";
            this.ThemHD_Button.UseVisualStyleBackColor = true;
            this.ThemHD_Button.Click += new System.EventHandler(this.ThemHD_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hợp đồng sẽ là :";
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
            this.MaHD.DataPropertyName = "MaHopDong";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NgayThue
            // 
            this.NgayThue.DataPropertyName = "NgayThue";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayThue.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayKetThuc
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "dd//MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayKetThuc.HeaderText = "Ngày dự kiến kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // PhongThue
            // 
            this.PhongThue.HeaderText = "Những phòng được thuê";
            this.PhongThue.Name = "PhongThue";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(580, 3);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(97, 23);
            this.Reset_Button.TabIndex = 14;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // NhanPhongKhongDatTruoc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 729);
            this.Controls.Add(this.HopDongMoi_Panel);
            this.Controls.Add(this.ChonPhong_Panel);
            this.Controls.Add(this.ChonKhachHang_Panel);
            this.Controls.Add(this.Today_Label);
            this.Controls.Add(this.Today_DateTimePicker);
            this.Controls.Add(this.KhachHangMoi_Panel);
            this.Controls.Add(this.Outside_RadioButton);
            this.Controls.Add(this.Inside_RadioButton);
            this.Name = "NhanPhongKhongDatTruoc_Form";
            this.Text = "NhanPhong_Form";
            this.Load += new System.EventHandler(this.NhanPhong_Form_Load);
            this.KhachHangMoi_Panel.ResumeLayout(false);
            this.KhachHangMoi_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ChonKhachHang_Panel.ResumeLayout(false);
            this.ChonKhachHang_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoNgayO_NumericUpDown)).EndInit();
            this.ChonPhong_Panel.ResumeLayout(false);
            this.ChonPhong_Panel.PerformLayout();
            this.HopDongMoi_Panel.ResumeLayout(false);
            this.HopDongMoi_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Inside_RadioButton;
        private System.Windows.Forms.RadioButton Outside_RadioButton;
        private System.Windows.Forms.Panel KhachHangMoi_Panel;
        private System.Windows.Forms.TextBox TenKH_TextBox;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.Label SDT_Label;
        private System.Windows.Forms.RadioButton Nu_RadioButton;
        private System.Windows.Forms.RadioButton Nam_RadioButton;
        private System.Windows.Forms.TextBox XuatXu_TextBox;
        private System.Windows.Forms.TextBox CMND_TextBox;
        private System.Windows.Forms.TextBox MaKH_TextBox;
        private System.Windows.Forms.Label XuatXu_Label;
        private System.Windows.Forms.Label GioiTinh_Label;
        private System.Windows.Forms.Label CMND_Label;
        private System.Windows.Forms.Label TenKH_Label;
        private System.Windows.Forms.Label MaKH_Label;
        private System.Windows.Forms.Button Add_Button;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchKH_ComboBox;
        private System.Windows.Forms.TextBox SearchKH_TextBox;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DateTimePicker Today_DateTimePicker;
        private System.Windows.Forms.Label Today_Label;
        private System.Windows.Forms.Panel ChonKhachHang_Panel;
        private System.Windows.Forms.Button ChonKH_Button;
        private System.Windows.Forms.Panel ChonPhong_Panel;
        private System.Windows.Forms.Button ChonPhong_Button;
        private System.Windows.Forms.Panel HopDongMoi_Panel;
        private System.Windows.Forms.Button ThemHD_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.NumericUpDown SoNgayO_NumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongThue;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Reset_Button;
    }
}