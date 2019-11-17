namespace QuanLyKhachSan
{
    partial class ThongKeTaiChinh_Form
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReport = new QuanLyKhachSan.DataSetReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonTableAdapter = new QuanLyKhachSan.DataSetReportTableAdapters.HoaDonTableAdapter();
            this.ChartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Stand_Label = new System.Windows.Forms.Label();
            this.ChartWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.DataSetReport;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 678);
            this.reportViewer1.TabIndex = 52;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ChartDT
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Doanh Thu";
            legend1.Title = "Doanh Thu";
            this.ChartDT.Legends.Add(legend1);
            this.ChartDT.Location = new System.Drawing.Point(679, 33);
            this.ChartDT.Name = "ChartDT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Doanh Thu";
            series1.Name = "DoanhThu";
            this.ChartDT.Series.Add(series1);
            this.ChartDT.Size = new System.Drawing.Size(491, 323);
            this.ChartDT.TabIndex = 53;
            this.ChartDT.Text = "chart1";
            title1.Name = "Thống kê danh thu mỗi tháng ";
            title1.Text = "Thống kê danh thu mỗi tháng ";
            this.ChartDT.Titles.Add(title1);
            // 
            // Stand_Label
            // 
            this.Stand_Label.AutoSize = true;
            this.Stand_Label.Location = new System.Drawing.Point(13, 14);
            this.Stand_Label.Name = "Stand_Label";
            this.Stand_Label.Size = new System.Drawing.Size(105, 13);
            this.Stand_Label.TabIndex = 54;
            this.Stand_Label.Text = "Danh sách hóa đơn:";
            // 
            // ChartWeek
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartWeek.ChartAreas.Add(chartArea2);
            legend2.Name = "Doanh Thu";
            legend2.Title = "Doanh Thu";
            this.ChartWeek.Legends.Add(legend2);
            this.ChartWeek.Location = new System.Drawing.Point(679, 388);
            this.ChartWeek.Name = "ChartWeek";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Doanh Thu";
            series2.Name = "DoanhThu";
            this.ChartWeek.Series.Add(series2);
            this.ChartWeek.Size = new System.Drawing.Size(491, 323);
            this.ChartWeek.TabIndex = 55;
            this.ChartWeek.Text = "chart1";
            title2.Name = "Thống kê danh thu mỗi tháng ";
            title2.Text = "Thống kê danh thu 7 ngày gần nhất ";
            this.ChartWeek.Titles.Add(title2);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(1079, 734);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 56;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ThongKeTaiChinh_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 777);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ChartWeek);
            this.Controls.Add(this.Stand_Label);
            this.Controls.Add(this.ChartDT);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeTaiChinh_Form";
            this.Text = "ThongKeTaiChinh_Form";
            this.Load += new System.EventHandler(this.ThongKeTaiChinh_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDT;
        private System.Windows.Forms.Label Stand_Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartWeek;
        private System.Windows.Forms.Button Back_Button;
    }
}