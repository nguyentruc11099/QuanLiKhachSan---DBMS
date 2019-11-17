namespace QuanLyKhachSan
{
    partial class QuanLyDichVu_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV_TextBox = new System.Windows.Forms.TextBox();
            this.TenDV_TextBox = new System.Windows.Forms.TextBox();
            this.GiaDV_TextBox = new System.Windows.Forms.TextBox();
            this.MaDV_Label = new System.Windows.Forms.Label();
            this.TenDV_Label = new System.Windows.Forms.Label();
            this.GiaDV_Label = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(33, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 62);
            this.panel1.TabIndex = 22;
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
            "Mã Dịch Vụ",
            "Tên Dịch Vụ",
            "Giá Dịch Vụ"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Dịch Vụ";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(272, 547);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 21;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(272, 497);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 19;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(155, 547);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(155, 497);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 17;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(38, 547);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 16;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(38, 497);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 15;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.GiaDV});
            this.dgvDV.Location = new System.Drawing.Point(33, 124);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(487, 283);
            this.dgvDV.TabIndex = 14;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
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
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Giá Dịch Vụ ";
            this.GiaDV.Name = "GiaDV";
            // 
            // MaDV_TextBox
            // 
            this.MaDV_TextBox.Location = new System.Drawing.Point(81, 14);
            this.MaDV_TextBox.Name = "MaDV_TextBox";
            this.MaDV_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MaDV_TextBox.TabIndex = 23;
            // 
            // TenDV_TextBox
            // 
            this.TenDV_TextBox.Location = new System.Drawing.Point(81, 63);
            this.TenDV_TextBox.Name = "TenDV_TextBox";
            this.TenDV_TextBox.Size = new System.Drawing.Size(100, 20);
            this.TenDV_TextBox.TabIndex = 24;
            // 
            // GiaDV_TextBox
            // 
            this.GiaDV_TextBox.Location = new System.Drawing.Point(263, 14);
            this.GiaDV_TextBox.Name = "GiaDV_TextBox";
            this.GiaDV_TextBox.Size = new System.Drawing.Size(100, 20);
            this.GiaDV_TextBox.TabIndex = 25;
            // 
            // MaDV_Label
            // 
            this.MaDV_Label.AutoSize = true;
            this.MaDV_Label.Location = new System.Drawing.Point(3, 14);
            this.MaDV_Label.Name = "MaDV_Label";
            this.MaDV_Label.Size = new System.Drawing.Size(63, 13);
            this.MaDV_Label.TabIndex = 26;
            this.MaDV_Label.Text = "Mã Dịch Vụ";
            // 
            // TenDV_Label
            // 
            this.TenDV_Label.AutoSize = true;
            this.TenDV_Label.Location = new System.Drawing.Point(3, 63);
            this.TenDV_Label.Name = "TenDV_Label";
            this.TenDV_Label.Size = new System.Drawing.Size(67, 13);
            this.TenDV_Label.TabIndex = 27;
            this.TenDV_Label.Text = "Tên Dịch Vụ";
            // 
            // GiaDV_Label
            // 
            this.GiaDV_Label.AutoSize = true;
            this.GiaDV_Label.Location = new System.Drawing.Point(195, 17);
            this.GiaDV_Label.Name = "GiaDV_Label";
            this.GiaDV_Label.Size = new System.Drawing.Size(64, 13);
            this.GiaDV_Label.TabIndex = 28;
            this.GiaDV_Label.Text = "Giá Dịch Vụ";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.GiaDV_Label);
            this.panel.Controls.Add(this.TenDV_Label);
            this.panel.Controls.Add(this.GiaDV_TextBox);
            this.panel.Controls.Add(this.TenDV_TextBox);
            this.panel.Controls.Add(this.MaDV_Label);
            this.panel.Controls.Add(this.MaDV_TextBox);
            this.panel.Location = new System.Drawing.Point(33, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 100);
            this.panel.TabIndex = 29;
            // 
            // QuanLyDichVu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 597);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.dgvDV);
            this.Name = "QuanLyDichVu_Form";
            this.Text = "DichVu_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TextBox MaDV_TextBox;
        private System.Windows.Forms.TextBox TenDV_TextBox;
        private System.Windows.Forms.TextBox GiaDV_TextBox;
        private System.Windows.Forms.Label MaDV_Label;
        private System.Windows.Forms.Label TenDV_Label;
        private System.Windows.Forms.Label GiaDV_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.Panel panel;
    }
}