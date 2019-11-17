namespace QuanLyKhachSan
{
    partial class QuanLyNhanVien_Form
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV_TextBox = new System.Windows.Forms.TextBox();
            this.GioiTinh_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.ChucVu_ComboBox = new System.Windows.Forms.ComboBox();
            this.NgaySinh_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Luong_TextBox = new System.Windows.Forms.TextBox();
            this.Luong_Label = new System.Windows.Forms.Label();
            this.Nu_RadioButton = new System.Windows.Forms.RadioButton();
            this.Nam_RadioButton = new System.Windows.Forms.RadioButton();
            this.MaNV_TextBox = new System.Windows.Forms.TextBox();
            this.NgaySinh_Label = new System.Windows.Forms.Label();
            this.ChucVu_Label = new System.Windows.Forms.Label();
            this.TenNV_Label = new System.Windows.Forms.Label();
            this.MaNV_Label = new System.Windows.Forms.Label();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.ChucVu,
            this.Luong,
            this.Ngay_Sinh,
            this.GioiTinh});
            this.dgvNV.Location = new System.Drawing.Point(37, 140);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(673, 265);
            this.dgvNV.TabIndex = 24;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Ngay_Sinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ngay_Sinh.HeaderText = "Ngày Sinh";
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // TenNV_TextBox
            // 
            this.TenNV_TextBox.Location = new System.Drawing.Point(100, 51);
            this.TenNV_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenNV_TextBox.Name = "TenNV_TextBox";
            this.TenNV_TextBox.Size = new System.Drawing.Size(120, 20);
            this.TenNV_TextBox.TabIndex = 19;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(37, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 62);
            this.panel1.TabIndex = 33;
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
            // Search_ComboBox
            // 
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "Mã NV",
            "Tên NV",
            "Chức Vụ",
            "Lương",
            "Giới Tính",
            "Ngày Sinh"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã NV";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.Password_TextBox);
            this.panel.Controls.Add(this.ChucVu_ComboBox);
            this.panel.Controls.Add(this.NgaySinh_DateTimePicker);
            this.panel.Controls.Add(this.TenNV_TextBox);
            this.panel.Controls.Add(this.Luong_TextBox);
            this.panel.Controls.Add(this.Luong_Label);
            this.panel.Controls.Add(this.Nu_RadioButton);
            this.panel.Controls.Add(this.Nam_RadioButton);
            this.panel.Controls.Add(this.MaNV_TextBox);
            this.panel.Controls.Add(this.NgaySinh_Label);
            this.panel.Controls.Add(this.GioiTinh_Label);
            this.panel.Controls.Add(this.ChucVu_Label);
            this.panel.Controls.Add(this.TenNV_Label);
            this.panel.Controls.Add(this.MaNV_Label);
            this.panel.Location = new System.Drawing.Point(37, 30);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(673, 95);
            this.panel.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(568, 53);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Password_TextBox.TabIndex = 22;
            // 
            // ChucVu_ComboBox
            // 
            this.ChucVu_ComboBox.FormattingEnabled = true;
            this.ChucVu_ComboBox.Items.AddRange(new object[] {
            "Quản Lý",
            "Lễ Tân",
            "Phục Vụ"});
            this.ChucVu_ComboBox.Location = new System.Drawing.Point(285, 11);
            this.ChucVu_ComboBox.Name = "ChucVu_ComboBox";
            this.ChucVu_ComboBox.Size = new System.Drawing.Size(90, 21);
            this.ChucVu_ComboBox.TabIndex = 21;
            this.ChucVu_ComboBox.Text = "Quản Lý";
            // 
            // NgaySinh_DateTimePicker
            // 
            this.NgaySinh_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySinh_DateTimePicker.Location = new System.Drawing.Point(447, 13);
            this.NgaySinh_DateTimePicker.MinDate = new System.DateTime(1754, 6, 12, 0, 0, 0, 0);
            this.NgaySinh_DateTimePicker.Name = "NgaySinh_DateTimePicker";
            this.NgaySinh_DateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.NgaySinh_DateTimePicker.TabIndex = 20;
            this.NgaySinh_DateTimePicker.Value = new System.DateTime(2579, 12, 31, 0, 0, 0, 0);
            // 
            // Luong_TextBox
            // 
            this.Luong_TextBox.Location = new System.Drawing.Point(285, 51);
            this.Luong_TextBox.Name = "Luong_TextBox";
            this.Luong_TextBox.Size = new System.Drawing.Size(90, 20);
            this.Luong_TextBox.TabIndex = 18;
            // 
            // Luong_Label
            // 
            this.Luong_Label.AutoSize = true;
            this.Luong_Label.Location = new System.Drawing.Point(236, 58);
            this.Luong_Label.Name = "Luong_Label";
            this.Luong_Label.Size = new System.Drawing.Size(37, 13);
            this.Luong_Label.TabIndex = 17;
            this.Luong_Label.Text = "Lương";
            // 
            // Nu_RadioButton
            // 
            this.Nu_RadioButton.AutoSize = true;
            this.Nu_RadioButton.Location = new System.Drawing.Point(442, 70);
            this.Nu_RadioButton.Name = "Nu_RadioButton";
            this.Nu_RadioButton.Size = new System.Drawing.Size(39, 17);
            this.Nu_RadioButton.TabIndex = 16;
            this.Nu_RadioButton.TabStop = true;
            this.Nu_RadioButton.Text = "Nữ";
            this.Nu_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Nam_RadioButton
            // 
            this.Nam_RadioButton.AutoSize = true;
            this.Nam_RadioButton.Location = new System.Drawing.Point(442, 47);
            this.Nam_RadioButton.Name = "Nam_RadioButton";
            this.Nam_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.Nam_RadioButton.TabIndex = 15;
            this.Nam_RadioButton.TabStop = true;
            this.Nam_RadioButton.Text = "Nam";
            this.Nam_RadioButton.UseVisualStyleBackColor = true;
            // 
            // MaNV_TextBox
            // 
            this.MaNV_TextBox.Location = new System.Drawing.Point(100, 13);
            this.MaNV_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaNV_TextBox.Name = "MaNV_TextBox";
            this.MaNV_TextBox.Size = new System.Drawing.Size(120, 20);
            this.MaNV_TextBox.TabIndex = 8;
            // 
            // NgaySinh_Label
            // 
            this.NgaySinh_Label.AutoSize = true;
            this.NgaySinh_Label.Location = new System.Drawing.Point(386, 13);
            this.NgaySinh_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NgaySinh_Label.Name = "NgaySinh_Label";
            this.NgaySinh_Label.Size = new System.Drawing.Size(56, 13);
            this.NgaySinh_Label.TabIndex = 6;
            this.NgaySinh_Label.Text = "Ngay Sinh";
            // 
            // ChucVu_Label
            // 
            this.ChucVu_Label.AutoSize = true;
            this.ChucVu_Label.Location = new System.Drawing.Point(236, 16);
            this.ChucVu_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChucVu_Label.Name = "ChucVu_Label";
            this.ChucVu_Label.Size = new System.Drawing.Size(48, 13);
            this.ChucVu_Label.TabIndex = 3;
            this.ChucVu_Label.Text = "Chức Vụ";
            // 
            // TenNV_Label
            // 
            this.TenNV_Label.AutoSize = true;
            this.TenNV_Label.Location = new System.Drawing.Point(11, 51);
            this.TenNV_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenNV_Label.Name = "TenNV_Label";
            this.TenNV_Label.Size = new System.Drawing.Size(79, 13);
            this.TenNV_Label.TabIndex = 2;
            this.TenNV_Label.Text = "Tên Nhân Viên";
            // 
            // MaNV_Label
            // 
            this.MaNV_Label.AutoSize = true;
            this.MaNV_Label.Location = new System.Drawing.Point(11, 13);
            this.MaNV_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaNV_Label.Name = "MaNV_Label";
            this.MaNV_Label.Size = new System.Drawing.Size(75, 13);
            this.MaNV_Label.TabIndex = 0;
            this.MaNV_Label.Text = "Mã Nhân Viên";
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(276, 503);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 30;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(159, 553);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 29;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(159, 503);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 28;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(42, 553);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 27;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(42, 503);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 26;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(277, 553);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 32;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // QuanLyNhanVien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 631);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Back_Button);
            this.Name = "QuanLyNhanVien_Form";
            this.Text = "QuanLyNhanVien_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox TenNV_TextBox;
        private System.Windows.Forms.Label GioiTinh_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox Luong_TextBox;
        private System.Windows.Forms.Label Luong_Label;
        private System.Windows.Forms.RadioButton Nu_RadioButton;
        private System.Windows.Forms.RadioButton Nam_RadioButton;
        private System.Windows.Forms.TextBox MaNV_TextBox;
        private System.Windows.Forms.Label NgaySinh_Label;
        private System.Windows.Forms.Label ChucVu_Label;
        private System.Windows.Forms.Label TenNV_Label;
        private System.Windows.Forms.Label MaNV_Label;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.DateTimePicker NgaySinh_DateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.ComboBox ChucVu_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button Back_Button;
    }
}