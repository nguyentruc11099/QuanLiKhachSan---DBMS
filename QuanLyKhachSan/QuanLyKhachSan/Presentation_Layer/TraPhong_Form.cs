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
    public partial class TraPhong_Form : Form
    {
        int row;
        double S = 0;
        string MaHoaDon;
        DataTable dtPhongvaHD = null;
        DataTable dtDVvaHD = null;
        DataTable dtHD = null;
        BLTraPhong blTP = new BLTraPhong();
        public TraPhong_Form()
        {
            InitializeComponent();
        }

        private void TraPhong_Form_Load(object sender, EventArgs e)
        {
            LoadDataHopDong();
        }
        private void LoadDataHopDong()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = blTP.LayDSHopDong();
                dtHD = ds.Tables[0];
                dgvHD.DataSource = dtHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HopDong !");
            }
        }
        private void LoadDataDichVuvaHopDong(string mahd)
        {
            try
            {
                dtDVvaHD = new DataTable();
                dtDVvaHD.Clear();
                DataSet ds = blTP.LayDSDichVuvaHopDong(mahd);
                dtDVvaHD = ds.Tables[0];
                dgvDVvaHD.DataSource = dtDVvaHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DVvaHD !");
            }
        }
        private void LoadDataPhongvaHopDong(string mahd)
        {
            try
            {
                dtPhongvaHD = new DataTable();
                dtPhongvaHD.Clear();
                DataSet ds = blTP.LayDSPhongvaHD(mahd);
                dtPhongvaHD = ds.Tables[0];
                dgvPhongvaHD.DataSource = dtPhongvaHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PhongvaHD !");
            }
        }

        private void Choose_Button_Click(object sender, EventArgs e)
        {
            row = dgvHD.CurrentCell.RowIndex;
            if (dgvHD.Rows[row].Cells[0].Value.ToString() != "")
            {
                LoadDataDichVuvaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
                LoadDataPhongvaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
            }
            TinhTien_RichTextBox.ResetText();
            TinhTien();
        }
        private void TinhTien()
        {
            S = 0;
            TimeSpan time = Convert.ToDateTime(dgvHD.Rows[row].Cells[4].Value).Subtract(Convert.ToDateTime(dgvHD.Rows[row].Cells[3].Value));
            TinhTien_RichTextBox.AppendText("Hợp đồng: " + dgvHD.Rows[row].Cells[0].Value.ToString() + "\n");
            TinhTien_RichTextBox.AppendText("Khách hàng: " + dgvHD.Rows[row].Cells[2].Value.ToString() + "\n");
            TinhTien_RichTextBox.AppendText("\nPhần tiền phòng: \n");
            for (int i = 0; i < dgvPhongvaHD.Rows.Count - 1; i++)
            {
                TinhTien_RichTextBox.AppendText("Khách đã thuê phòng " + dgvPhongvaHD.Rows[i].Cells[1].Value.ToString() + " loại " + dgvPhongvaHD.Rows[i].Cells[2].Value.ToString() + " với giá tiền mỗi ngày là " + dgvPhongvaHD.Rows[i].Cells[3].Value.ToString() + " trong " + time.Days + " ngày \n");
                S += Convert.ToDouble(dgvPhongvaHD.Rows[i].Cells[3].Value) * time.Days;
            }
            TinhTien_RichTextBox.AppendText("\nPhần tiền dịch vụ: \n");
            if (dgvDVvaHD.Rows.Count <= 1)
            {
                TinhTien_RichTextBox.AppendText("Không có sử dụng dịch vụ thêm nào ! \n");
            }
            else
            {
                for (int i = 0; i < dgvDVvaHD.Rows.Count - 1; i++)
                {
                    TinhTien_RichTextBox.AppendText("Khách đã sử dụng dịch vụ " + dgvDVvaHD.Rows[i].Cells[2].Value.ToString() + " với giá tiền " + dgvDVvaHD.Rows[i].Cells[4].Value.ToString() + " trong " + dgvDVvaHD.Rows[i].Cells[3].Value.ToString() + " lần \n");
                    S += Convert.ToDouble(dgvDVvaHD.Rows[i].Cells[4].Value) * Convert.ToDouble(dgvDVvaHD.Rows[i].Cells[3].Value);
                }
            }
            time = DateTime.Now.Subtract(Convert.ToDateTime(dgvHD.Rows[row].Cells[4].Value));
            if (time.Days >= 1)
            {
                TinhTien_RichTextBox.AppendText(" Khach đã thanh toán tiền trễ hạn " + time.Days + " ngày nên bị phạt " + time.Days + " x 50000 = " + time.Days * 50000 + "\n");
                S += time.Days * 50000;
            }
            TinhTien_RichTextBox.AppendText("\nVậy tổng tiền phải thanh toán là: " + S+"\n");
        }

        private void ThanhToan_Button_Click(object sender, EventArgs e)
        {          
            SinhMaHD();
            blTP.ThemHoaDon(MaHoaDon, dgvHD.Rows[row].Cells[1].Value.ToString(), dgvHD.Rows[row].Cells[3].Value.ToString(), dgvHD.Rows[row].Cells[4].Value.ToString(), S.ToString(), DateTime.Now.ToString());
            blTP.XoaDichVuVaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
            blTP.XoaPhongVaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
            blTP.XoaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
            for (int i = 0; i < dgvPhongvaHD.Rows.Count - 1; i++)
            {
                blTP = new BLTraPhong();
                blTP.CapNhatPhong(dgvPhongvaHD.Rows[i].Cells[1].Value.ToString(), "Trống");
            }
            MessageBox.Show("Hợp đồng đã đươc thanh toán thành công, để kiểm tra lại hãy vào mục hóa đơn");
            this.Close();
        }
        private void SinhMaHD()
        {
            dtHD = new DataTable();
            dtHD.Clear();
            DataSet ds = blTP.LayDSHoaDon();
            dtHD = ds.Tables[0];
            if (dtHD.Rows.Count >= 1)
            {
                string a = dtHD.Rows[dtHD.Rows.Count - 1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    MaHoaDon = "P0" + b.ToString();
                }
                else
                {
                    MaHoaDon = "P" + b.ToString();
                }
            }
            else
            {
                MaHoaDon = "P01";
            }
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (Search_ComboBox.Text)
            {
                case "Mã Hợp Đồng":
                    {
                        column = "MaHopDong";
                        break;
                    }
                case "Mã Khách Hàng":
                    {
                        column = "MaKH";
                        break;
                    }
                case "Ngày Thuê Phòng":
                    {
                        column = "NgayThue";
                        break;
                    }
                case "Ngày Dự Kiến Trả":
                    {
                        column = "NgayDuKienTraPhong";
                        break;
                    }
                case "Tên Khách Hàng":
                    {
                        column = "TenKH";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blTP = new BLTraPhong();
            DataSet ds = blTP.TimKiemHopDong(column, Search_TextBox.Text);
            dtHD = new DataTable();
            dtHD = ds.Tables[0];
            dgvHD.DataSource = dtHD;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
