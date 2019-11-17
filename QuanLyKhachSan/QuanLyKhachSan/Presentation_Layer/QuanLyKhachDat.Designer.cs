namespace QuanLyKhachSan
{
    partial class QuanLyKhachDat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchKhachDat_ComboBox = new System.Windows.Forms.ComboBox();
            this.SearchKhachDat_TextBox = new System.Windows.Forms.TextBox();
            this.dgvKhachDat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNguoiDat_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.NgayDat_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachDat)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvKhachDat);
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 204);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SearchKhachDat_ComboBox);
            this.panel3.Controls.Add(this.SearchKhachDat_TextBox);
            this.panel3.Location = new System.Drawing.Point(25, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 53);
            this.panel3.TabIndex = 25;
            this.panel3.Tag = "";
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
            // SearchKhachDat_ComboBox
            // 
            this.SearchKhachDat_ComboBox.FormattingEnabled = true;
            this.SearchKhachDat_ComboBox.Items.AddRange(new object[] {
            "Mã Người Đặt",
            "Tên Người Đặt",
            "SĐT",
            "Ngày Hết Hạn",
            "Mã Phòng",
            "Loại Phòng"});
            this.SearchKhachDat_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.SearchKhachDat_ComboBox.Name = "SearchKhachDat_ComboBox";
            this.SearchKhachDat_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchKhachDat_ComboBox.TabIndex = 12;
            this.SearchKhachDat_ComboBox.Text = "Mã Người Đặt";
            // 
            // SearchKhachDat_TextBox
            // 
            this.SearchKhachDat_TextBox.Location = new System.Drawing.Point(142, 24);
            this.SearchKhachDat_TextBox.Name = "SearchKhachDat_TextBox";
            this.SearchKhachDat_TextBox.Size = new System.Drawing.Size(177, 20);
            this.SearchKhachDat_TextBox.TabIndex = 10;
            this.SearchKhachDat_TextBox.TextChanged += new System.EventHandler(this.SearchKhachDat_TextBox_TextChanged);
            // 
            // dgvKhachDat
            // 
            this.dgvKhachDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.MaPhong,
            this.LoaiPhong});
            this.dgvKhachDat.Location = new System.Drawing.Point(14, 8);
            this.dgvKhachDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachDat.Name = "dgvKhachDat";
            this.dgvKhachDat.RowTemplate.Height = 24;
            this.dgvKhachDat.Size = new System.Drawing.Size(654, 129);
            this.dgvKhachDat.TabIndex = 24;
            this.dgvKhachDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachDat_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNguoiDat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Người Đặt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenNguoiDat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Người Đặt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn5.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NgayHetHan";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày Hết Hạn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên người đặt phòng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "SĐT";
            // 
            // TenNguoiDat_TextBox
            // 
            this.TenNguoiDat_TextBox.Location = new System.Drawing.Point(147, 16);
            this.TenNguoiDat_TextBox.Name = "TenNguoiDat_TextBox";
            this.TenNguoiDat_TextBox.Size = new System.Drawing.Size(100, 20);
            this.TenNguoiDat_TextBox.TabIndex = 44;
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Location = new System.Drawing.Point(147, 79);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(100, 20);
            this.SDT_TextBox.TabIndex = 45;
            // 
            // NgayDat_DateTimePicker
            // 
            this.NgayDat_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayDat_DateTimePicker.Location = new System.Drawing.Point(377, 16);
            this.NgayDat_DateTimePicker.Name = "NgayDat_DateTimePicker";
            this.NgayDat_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.NgayDat_DateTimePicker.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày được đặt";
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(16, 405);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 48;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(250, 405);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 53;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(131, 405);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 51;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(131, 455);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 50;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(16, 455);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 49;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.SDT_TextBox);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.TenNguoiDat_TextBox);
            this.panel.Controls.Add(this.NgayDat_DateTimePicker);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(16, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(594, 112);
            this.panel.TabIndex = 54;
            // 
            // QuanLyKhachDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 509);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhachDat";
            this.Text = "QuanLyKhachDat";
            this.Load += new System.EventHandler(this.QuanLyKhachDat_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachDat)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchKhachDat_ComboBox;
        private System.Windows.Forms.TextBox SearchKhachDat_TextBox;
        private System.Windows.Forms.DataGridView dgvKhachDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNguoiDat_TextBox;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.DateTimePicker NgayDat_DateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
    }
}