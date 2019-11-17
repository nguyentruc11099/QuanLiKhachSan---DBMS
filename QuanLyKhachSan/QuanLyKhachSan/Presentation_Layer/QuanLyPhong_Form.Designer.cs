namespace QuanLyKhachSan
{
    partial class QuanLyPhong_Form
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
            this.dgvPHONG = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.DaDat_RadioButton = new System.Windows.Forms.RadioButton();
            this.LoaiPhong_ComboBox = new System.Windows.Forms.ComboBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Trong_RadioButton = new System.Windows.Forms.RadioButton();
            this.DaThue_RadioButton = new System.Windows.Forms.RadioButton();
            this.MaNV_TextBox = new System.Windows.Forms.TextBox();
            this.GiaPhong_TextBox = new System.Windows.Forms.TextBox();
            this.MaPhong_TextBox = new System.Windows.Forms.TextBox();
            this.MaNV_Label = new System.Windows.Forms.Label();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_GiaPhong = new System.Windows.Forms.Label();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.MaPhong_Label = new System.Windows.Forms.Label();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPHONG
            // 
            this.dgvPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaPhong,
            this.SDT,
            this.MaNV});
            this.dgvPHONG.Location = new System.Drawing.Point(17, 119);
            this.dgvPHONG.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPHONG.Name = "dgvPHONG";
            this.dgvPHONG.RowTemplate.Height = 24;
            this.dgvPHONG.Size = new System.Drawing.Size(673, 283);
            this.dgvPHONG.TabIndex = 0;
            this.dgvPHONG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONG_CellClick);
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
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.DaDat_RadioButton);
            this.panel.Controls.Add(this.LoaiPhong_ComboBox);
            this.panel.Controls.Add(this.SDT_TextBox);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.Trong_RadioButton);
            this.panel.Controls.Add(this.DaThue_RadioButton);
            this.panel.Controls.Add(this.MaNV_TextBox);
            this.panel.Controls.Add(this.GiaPhong_TextBox);
            this.panel.Controls.Add(this.MaPhong_TextBox);
            this.panel.Controls.Add(this.MaNV_Label);
            this.panel.Controls.Add(this.lb_TinhTrang);
            this.panel.Controls.Add(this.lb_GiaPhong);
            this.panel.Controls.Add(this.lb_LoaiPhong);
            this.panel.Controls.Add(this.MaPhong_Label);
            this.panel.Location = new System.Drawing.Point(17, 19);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(673, 95);
            this.panel.TabIndex = 1;
            // 
            // DaDat_RadioButton
            // 
            this.DaDat_RadioButton.AutoSize = true;
            this.DaDat_RadioButton.Location = new System.Drawing.Point(554, 70);
            this.DaDat_RadioButton.Name = "DaDat_RadioButton";
            this.DaDat_RadioButton.Size = new System.Drawing.Size(86, 17);
            this.DaDat_RadioButton.TabIndex = 20;
            this.DaDat_RadioButton.TabStop = true;
            this.DaDat_RadioButton.Text = "Đã được đặt";
            this.DaDat_RadioButton.UseVisualStyleBackColor = true;
            // 
            // LoaiPhong_ComboBox
            // 
            this.LoaiPhong_ComboBox.FormattingEnabled = true;
            this.LoaiPhong_ComboBox.Items.AddRange(new object[] {
            "Đôi",
            "Đơn",
            "Cao Cấp"});
            this.LoaiPhong_ComboBox.Location = new System.Drawing.Point(70, 48);
            this.LoaiPhong_ComboBox.Name = "LoaiPhong_ComboBox";
            this.LoaiPhong_ComboBox.Size = new System.Drawing.Size(90, 21);
            this.LoaiPhong_ComboBox.TabIndex = 19;
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Location = new System.Drawing.Point(285, 51);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(90, 20);
            this.SDT_TextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SĐT";
            // 
            // Trong_RadioButton
            // 
            this.Trong_RadioButton.AutoSize = true;
            this.Trong_RadioButton.Location = new System.Drawing.Point(477, 71);
            this.Trong_RadioButton.Name = "Trong_RadioButton";
            this.Trong_RadioButton.Size = new System.Drawing.Size(53, 17);
            this.Trong_RadioButton.TabIndex = 16;
            this.Trong_RadioButton.TabStop = true;
            this.Trong_RadioButton.Text = "Trống";
            this.Trong_RadioButton.UseVisualStyleBackColor = true;
            // 
            // DaThue_RadioButton
            // 
            this.DaThue_RadioButton.AutoSize = true;
            this.DaThue_RadioButton.Location = new System.Drawing.Point(477, 47);
            this.DaThue_RadioButton.Name = "DaThue_RadioButton";
            this.DaThue_RadioButton.Size = new System.Drawing.Size(91, 17);
            this.DaThue_RadioButton.TabIndex = 15;
            this.DaThue_RadioButton.TabStop = true;
            this.DaThue_RadioButton.Text = "Đã được thuê";
            this.DaThue_RadioButton.UseVisualStyleBackColor = true;
            // 
            // MaNV_TextBox
            // 
            this.MaNV_TextBox.Location = new System.Drawing.Point(464, 13);
            this.MaNV_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaNV_TextBox.Name = "MaNV_TextBox";
            this.MaNV_TextBox.Size = new System.Drawing.Size(63, 20);
            this.MaNV_TextBox.TabIndex = 14;
            // 
            // GiaPhong_TextBox
            // 
            this.GiaPhong_TextBox.Location = new System.Drawing.Point(285, 13);
            this.GiaPhong_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GiaPhong_TextBox.Name = "GiaPhong_TextBox";
            this.GiaPhong_TextBox.Size = new System.Drawing.Size(90, 20);
            this.GiaPhong_TextBox.TabIndex = 12;
            // 
            // MaPhong_TextBox
            // 
            this.MaPhong_TextBox.Location = new System.Drawing.Point(70, 13);
            this.MaPhong_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaPhong_TextBox.Name = "MaPhong_TextBox";
            this.MaPhong_TextBox.Size = new System.Drawing.Size(137, 20);
            this.MaPhong_TextBox.TabIndex = 8;
            // 
            // MaNV_Label
            // 
            this.MaNV_Label.AutoSize = true;
            this.MaNV_Label.Location = new System.Drawing.Point(386, 13);
            this.MaNV_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaNV_Label.Name = "MaNV_Label";
            this.MaNV_Label.Size = new System.Drawing.Size(75, 13);
            this.MaNV_Label.TabIndex = 6;
            this.MaNV_Label.Text = "Mã Nhân Viên";
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(386, 48);
            this.lb_TinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(59, 13);
            this.lb_TinhTrang.TabIndex = 5;
            this.lb_TinhTrang.Text = "Tình Trạng";
            // 
            // lb_GiaPhong
            // 
            this.lb_GiaPhong.AutoSize = true;
            this.lb_GiaPhong.Location = new System.Drawing.Point(224, 13);
            this.lb_GiaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_GiaPhong.Name = "lb_GiaPhong";
            this.lb_GiaPhong.Size = new System.Drawing.Size(57, 13);
            this.lb_GiaPhong.TabIndex = 3;
            this.lb_GiaPhong.Text = "Giá Phòng";
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.AutoSize = true;
            this.lb_LoaiPhong.Location = new System.Drawing.Point(11, 51);
            this.lb_LoaiPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(61, 13);
            this.lb_LoaiPhong.TabIndex = 2;
            this.lb_LoaiPhong.Text = "Loại Phòng";
            // 
            // MaPhong_Label
            // 
            this.MaPhong_Label.AutoSize = true;
            this.MaPhong_Label.Location = new System.Drawing.Point(11, 13);
            this.MaPhong_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaPhong_Label.Name = "MaPhong_Label";
            this.MaPhong_Label.Size = new System.Drawing.Size(56, 13);
            this.MaPhong_Label.TabIndex = 0;
            this.MaPhong_Label.Text = "Mã Phòng";
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(22, 492);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 2;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(22, 542);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 3;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(139, 492);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(139, 542);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(256, 492);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 6;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(256, 541);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 8;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // Search_ComboBox
            // 
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "Mã Phòng",
            "Loại Phòng",
            "Tình Trạng",
            "Giá Phòng",
            "Mã Nhân Viên Phụ Trách",
            "SĐT"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Phòng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(17, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 62);
            this.panel1.TabIndex = 13;
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
            // QuanLyPhong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvPHONG);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyPhong_Form";
            this.Text = "QuanLyPhong";
            this.Load += new System.EventHandler(this.FrmQuanLyDanhMucPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPHONG;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label MaNV_Label;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_GiaPhong;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private System.Windows.Forms.Label MaPhong_Label;
        private System.Windows.Forms.TextBox MaNV_TextBox;
        private System.Windows.Forms.TextBox GiaPhong_TextBox;
        private System.Windows.Forms.TextBox MaPhong_TextBox;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.RadioButton Trong_RadioButton;
        private System.Windows.Forms.RadioButton DaThue_RadioButton;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.ComboBox LoaiPhong_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton DaDat_RadioButton;
    }
}

