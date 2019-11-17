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
    public partial class ThongKeDichVu : Form
    {
        public ThongKeDichVu()
        {
            InitializeComponent();
        }

        private void ThongKeDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BLDVvaHD bl = new BLDVvaHD();
            DataSet ds = new DataSet();
            ds = bl.LayThongKeDichVu();
            dt = ds.Tables[0];
            dgvDV.DataSource = dt;
            dgvDV.Columns.Add("TongTien","Tổng Tiền");
            for (int i = 0; i < dgvDV.Rows.Count - 1; i++)
            {
            
                dgvDV.Rows[i].Cells[5].Value += "";
                dgvDV.Rows[i].Cells[5].Value += (Convert.ToInt32(dgvDV.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvDV.Rows[i].Cells[4].Value)).ToString();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChartDT.Series["TienDV"].Points.AddXY(dt.Rows[i].ItemArray[1], (Convert.ToInt32(dt.Rows[i].ItemArray[2]) * Convert.ToInt32(dt.Rows[i].ItemArray[3])));                
                //ChartDT.Series["TienDV"].Points.Add((Convert.ToInt32(dt.Rows[i].ItemArray[2]) * Convert.ToInt32(dt.Rows[i].ItemArray[3])));
                //ChartDT.Series["TienDV"].Points[i].Label = (Convert.ToDouble(dt.Rows[i].ItemArray[2]) * Convert.ToDouble(dt.Rows[i].ItemArray[3])).ToString();
                //ChartDT.Series["TienDV"].Points[i].AxisLabel = dt.Rows[i].ItemArray[1].ToString();
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
