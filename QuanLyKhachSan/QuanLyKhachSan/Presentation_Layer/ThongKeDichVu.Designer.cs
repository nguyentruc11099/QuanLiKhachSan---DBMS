namespace QuanLyKhachSan
{
    partial class ThongKeDichVu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDT
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartDT.Legends.Add(legend1);
            this.ChartDT.Location = new System.Drawing.Point(743, 34);
            this.ChartDT.Name = "ChartDT";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "TienDV";
            this.ChartDT.Series.Add(series1);
            this.ChartDT.Size = new System.Drawing.Size(330, 300);
            this.ChartDT.TabIndex = 0;
            this.ChartDT.Text = "chart1";
            title1.Name = "Biểu Đồ Tiền Thu Từ Dịch Vụ";
            title1.Text = "Biểu Đồ Tiền Thu Từ Dịch Vụ";
            this.ChartDT.Titles.Add(title1);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.GiaTien,
            this.SoNgaySD,
            this.TongTienThu});
            this.dgvDV.Location = new System.Drawing.Point(11, 33);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(675, 301);
            this.dgvDV.TabIndex = 31;
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
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaDV";
            this.GiaTien.HeaderText = "Giá Dịch Vụ";
            this.GiaTien.Name = "GiaTien";
            // 
            // SoNgaySD
            // 
            this.SoNgaySD.DataPropertyName = "SoLanSD";
            this.SoNgaySD.HeaderText = "Số Ngày Sử Dụng Dịch Vụ";
            this.SoNgaySD.Name = "SoNgaySD";
            // 
            // TongTienThu
            // 
            this.TongTienThu.HeaderText = "Mô Tả Thêm Nếu Có ";
            this.TongTienThu.Name = "TongTienThu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bảng Thống Kê Dịch Vụ";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(893, 352);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 33;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ThongKeDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 387);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.ChartDT);
            this.Name = "ThongKeDichVu";
            this.Text = "ThongKeDichVu";
            this.Load += new System.EventHandler(this.ThongKeDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDT;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThu;
        private System.Windows.Forms.Button Back_Button;
    }
}