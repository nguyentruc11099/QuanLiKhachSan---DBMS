using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.BS_layer;
namespace QuanLyKhachSan
{
    public partial class ThongKeTaiChinh_Form : Form
    {
        DataTable dtHD = null;
        BLHoaDon blHD = new BLHoaDon();
        int[] S;
        int[] S1;
        public ThongKeTaiChinh_Form()
        {
            InitializeComponent();
        }

        private void ThongKeTaiChinh_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.DataSetReport.HoaDon);
            this.reportViewer1.RefreshReport();


            dtHD = new DataTable();
            dtHD.Clear();
            DataSet ds = blHD.LayDSHD();
            dtHD = ds.Tables[0];

            int SoThang = DateTime.Now.Month;
            int[] S = new int[SoThang];
            for (int i = SoThang; i > 0; i--)
            {
                S[i-1] = 0;
                for (int j = 0; j < dtHD.Rows.Count; j++)
                {
                    string[] a = dtHD.Rows[j].ItemArray[5].ToString().Split('/');
                    if (Convert.ToInt32(a[0]) == i)
                    {
                        S[i-1] += Convert.ToInt32(dtHD.Rows[j].ItemArray[4]);
                    }
                }
            }

            for (int i = 0; i < SoThang; i++)
            {
                ChartDT.Series["DoanhThu"].Points.Add(S[i]);
                ChartDT.Series["DoanhThu"].Points[i].Label = S[i].ToString();
                ChartDT.Series["DoanhThu"].Points[i].Color =Color.Blue;
                ChartDT.Series["DoanhThu"].Points[i].AxisLabel = "Tháng "+(i+1).ToString();
            }


            int SoNgayBatDauWeek = DateTime.Now.Day - 6;
            S1 = new int[7];
                for (int i = SoNgayBatDauWeek; i <= DateTime.Now.Day; i++)
                {
                    S1[i - SoNgayBatDauWeek] = 0;
                    for (int j = 0; j < dtHD.Rows.Count; j++)
                    {
                        string[] a = dtHD.Rows[j].ItemArray[5].ToString().Split('/');
                        if (Convert.ToInt32(a[1]) == i)
                        {
                            S1[i - SoNgayBatDauWeek] += Convert.ToInt32(dtHD.Rows[j].ItemArray[4]);
                        }
                    }
                }
            for (int i = 0; i < 7; i++)
            {
                ChartWeek.Series["DoanhThu"].Points.Add(S1[i]);
                ChartWeek.Series["DoanhThu"].Points[i].Label = S1[i].ToString();
                ChartWeek.Series["DoanhThu"].Points[i].Color = Color.Blue;
                ChartWeek.Series["DoanhThu"].Points[i].AxisLabel = "Ngày" + (i + SoNgayBatDauWeek).ToString();
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
