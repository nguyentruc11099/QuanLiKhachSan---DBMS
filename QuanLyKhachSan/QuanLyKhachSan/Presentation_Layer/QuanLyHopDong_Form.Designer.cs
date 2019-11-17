namespace QuanLyKhachSan
{
    partial class QuanLyHopDong_Form
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
            this.panel = new System.Windows.Forms.Panel();
            this.NgayTra_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayThue_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NgayThue_Label = new System.Windows.Forms.Label();
            this.MaKH_Label = new System.Windows.Forms.Label();
            this.MaKH_TextBox = new System.Windows.Forms.TextBox();
            this.MaHD_Label = new System.Windows.Forms.Label();
            this.MaHD_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuKienTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_Button = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.NgayTra_DateTimePicker);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.NgayThue_DateTimePicker);
            this.panel.Controls.Add(this.NgayThue_Label);
            this.panel.Controls.Add(this.MaKH_Label);
            this.panel.Controls.Add(this.MaKH_TextBox);
            this.panel.Controls.Add(this.MaHD_Label);
            this.panel.Controls.Add(this.MaHD_TextBox);
            this.panel.Location = new System.Drawing.Point(44, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(461, 100);
            this.panel.TabIndex = 49;
            // 
            // NgayTra_DateTimePicker
            // 
            this.NgayTra_DateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.NgayTra_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayTra_DateTimePicker.Location = new System.Drawing.Point(325, 63);
            this.NgayTra_DateTimePicker.Name = "NgayTra_DateTimePicker";
            this.NgayTra_DateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.NgayTra_DateTimePicker.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ngày Trả Phòng";
            // 
            // NgayThue_DateTimePicker
            // 
            this.NgayThue_DateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.NgayThue_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayThue_DateTimePicker.Location = new System.Drawing.Point(325, 14);
            this.NgayThue_DateTimePicker.Name = "NgayThue_DateTimePicker";
            this.NgayThue_DateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.NgayThue_DateTimePicker.TabIndex = 29;
            // 
            // NgayThue_Label
            // 
            this.NgayThue_Label.AutoSize = true;
            this.NgayThue_Label.Location = new System.Drawing.Point(217, 17);
            this.NgayThue_Label.Name = "NgayThue_Label";
            this.NgayThue_Label.Size = new System.Drawing.Size(102, 13);
            this.NgayThue_Label.TabIndex = 28;
            this.NgayThue_Label.Text = "Ngày Bắt Đầu Thuê";
            // 
            // MaKH_Label
            // 
            this.MaKH_Label.AutoSize = true;
            this.MaKH_Label.Location = new System.Drawing.Point(3, 63);
            this.MaKH_Label.Name = "MaKH_Label";
            this.MaKH_Label.Size = new System.Drawing.Size(85, 13);
            this.MaKH_Label.TabIndex = 27;
            this.MaKH_Label.Text = "Mã Khách Hàng";
            // 
            // MaKH_TextBox
            // 
            this.MaKH_TextBox.Location = new System.Drawing.Point(94, 60);
            this.MaKH_TextBox.Name = "MaKH_TextBox";
            this.MaKH_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MaKH_TextBox.TabIndex = 24;
            // 
            // MaHD_Label
            // 
            this.MaHD_Label.AutoSize = true;
            this.MaHD_Label.Location = new System.Drawing.Point(3, 14);
            this.MaHD_Label.Name = "MaHD_Label";
            this.MaHD_Label.Size = new System.Drawing.Size(74, 13);
            this.MaHD_Label.TabIndex = 26;
            this.MaHD_Label.Text = "Mã Hợp Đồng";
            // 
            // MaHD_TextBox
            // 
            this.MaHD_TextBox.Location = new System.Drawing.Point(94, 14);
            this.MaHD_TextBox.Name = "MaHD_TextBox";
            this.MaHD_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MaHD_TextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(44, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 62);
            this.panel1.TabIndex = 48;
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
            "Mã Hợp Đồng",
            "Mã Khách Hàng",
            "Ngày Thuê Phòng"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Hợp Đồng";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(49, 499);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 41;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(283, 499);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 47;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(164, 499);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 45;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(164, 549);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 44;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.NgayThue,
            this.NgayDuKienTra});
            this.dgvHD.Location = new System.Drawing.Point(44, 126);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(461, 283);
            this.dgvHD.TabIndex = 40;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
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
            // NgayDuKienTra
            // 
            this.NgayDuKienTra.DataPropertyName = "NgayDuKienTraPhong";
            this.NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả";
            this.NgayDuKienTra.Name = "NgayDuKienTra";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(49, 549);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 42;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // QuanLyHopDong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 650);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.Save_Button);
            this.Name = "QuanLyHopDong_Form";
            this.Text = "QuanLyHopDong_Form";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label NgayThue_Label;
        private System.Windows.Forms.Label MaKH_Label;
        private System.Windows.Forms.TextBox MaKH_TextBox;
        private System.Windows.Forms.Label MaHD_Label;
        private System.Windows.Forms.TextBox MaHD_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.DateTimePicker NgayThue_DateTimePicker;
        private System.Windows.Forms.DateTimePicker NgayTra_DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDuKienTra;
    }
}