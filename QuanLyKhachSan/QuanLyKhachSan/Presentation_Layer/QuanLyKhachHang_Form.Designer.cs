namespace QuanLyKhachSan
{
    partial class QuanLyKhachHang_Form
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
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_Label = new System.Windows.Forms.Label();
            this.Nu_RadioButton = new System.Windows.Forms.RadioButton();
            this.Nam_RadioButton = new System.Windows.Forms.RadioButton();
            this.XuatXu_TextBox = new System.Windows.Forms.TextBox();
            this.CMND_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaKH_TextBox = new System.Windows.Forms.TextBox();
            this.XuatXu_Label = new System.Windows.Forms.Label();
            this.CMND_Label = new System.Windows.Forms.Label();
            this.TenKH_Label = new System.Windows.Forms.Label();
            this.MaKH_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.TenKH_TextBox = new System.Windows.Forms.TextBox();
            this.GioiTinh_Label = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(261, 496);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 20;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(144, 546);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 19;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(144, 496);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 18;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(27, 546);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 17;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(27, 496);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 16;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(262, 546);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 22;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Search_ComboBox
            // 
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "Mã KH",
            "Tên KH",
            "CMND",
            "Giới Tính",
            "SĐT",
            "Xuất Xứ"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã KH";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
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
            this.MaKH_Label.Location = new System.Drawing.Point(11, 13);
            this.MaKH_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaKH_Label.Name = "MaKH_Label";
            this.MaKH_Label.Size = new System.Drawing.Size(85, 13);
            this.MaKH_Label.TabIndex = 0;
            this.MaKH_Label.Text = "Mã Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(27, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 62);
            this.panel1.TabIndex = 23;
            this.panel1.Tag = "";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.TenKH_TextBox);
            this.panel.Controls.Add(this.SDT_TextBox);
            this.panel.Controls.Add(this.SDT_Label);
            this.panel.Controls.Add(this.Nu_RadioButton);
            this.panel.Controls.Add(this.Nam_RadioButton);
            this.panel.Controls.Add(this.XuatXu_TextBox);
            this.panel.Controls.Add(this.CMND_TextBox);
            this.panel.Controls.Add(this.MaKH_TextBox);
            this.panel.Controls.Add(this.XuatXu_Label);
            this.panel.Controls.Add(this.GioiTinh_Label);
            this.panel.Controls.Add(this.CMND_Label);
            this.panel.Controls.Add(this.TenKH_Label);
            this.panel.Controls.Add(this.MaKH_Label);
            this.panel.Location = new System.Drawing.Point(22, 23);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(673, 95);
            this.panel.TabIndex = 15;
            // 
            // TenKH_TextBox
            // 
            this.TenKH_TextBox.Location = new System.Drawing.Point(100, 51);
            this.TenKH_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenKH_TextBox.Name = "TenKH_TextBox";
            this.TenKH_TextBox.Size = new System.Drawing.Size(120, 20);
            this.TenKH_TextBox.TabIndex = 19;
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
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.SDT,
            this.XuatXu});
            this.dgvKH.Location = new System.Drawing.Point(27, 123);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(668, 283);
            this.dgvKH.TabIndex = 14;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONG_CellClick);
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
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất Xứ";
            this.XuatXu.Name = "XuatXu";
            // 
            // QuanLyKhachHang_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 612);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvKH);
            this.Name = "QuanLyKhachHang_Form";
            this.Text = "QuanLyKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.Label SDT_Label;
        private System.Windows.Forms.RadioButton Nu_RadioButton;
        private System.Windows.Forms.RadioButton Nam_RadioButton;
        private System.Windows.Forms.TextBox XuatXu_TextBox;
        private System.Windows.Forms.TextBox CMND_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaKH_TextBox;
        private System.Windows.Forms.Label XuatXu_Label;
        private System.Windows.Forms.Label CMND_Label;
        private System.Windows.Forms.Label TenKH_Label;
        private System.Windows.Forms.Label MaKH_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label GioiTinh_Label;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.TextBox TenKH_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
    }
}