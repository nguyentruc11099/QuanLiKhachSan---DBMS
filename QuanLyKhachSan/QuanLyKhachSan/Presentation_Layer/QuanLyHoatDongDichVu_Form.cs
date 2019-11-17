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
    public partial class QuanLyHoatDongDichVu_Form : Form
    {
        int row;
        DataTable dtDVvaHD = null;
        DataTable dtHD = null;
        DataTable dtDV = null;
        BlHoatDongDichVu blhdvadv = new BlHoatDongDichVu();
        public QuanLyHoatDongDichVu_Form()
        {
            InitializeComponent();
        }

        private void QuanLyHoatDongDichVu_Form_Load(object sender, EventArgs e)
        {
            LoadDataHopDong();
            LoadDSDV();
            HienSoLanSuDung_NumericUpDown.Enabled = false;
        }
        public void LoadDSDV()
        {
            try
            {
                dtDV = new DataTable();
                dtDV.Clear();
                DataSet ds = blhdvadv.LayDSDV();
                dtDV = ds.Tables[0];
                dtDV.Columns.Remove("Hide");
                dgvDV.DataSource = dtDV;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DichVu !");
            }
        }
        private void LoadDataHopDong()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = blhdvadv.LayDSHopDong();
                dtHD = ds.Tables[0];
                dgvHD.DataSource = dtHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HopDong !");
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
            blhdvadv = new BlHoatDongDichVu();
            DataSet ds = blhdvadv.TimKiemHopDong(column, Search_TextBox.Text);
            dtHD = new DataTable();
            dtHD = ds.Tables[0];
            dgvHD.DataSource = dtHD;
        }

        private void Choose_Button_Click(object sender, EventArgs e)
        {
            row = dgvHD.CurrentCell.RowIndex;
            if (dgvHD.Rows[row].Cells[0].Value.ToString() != "")
            {
                LoadDataDichVuvaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
            }
        }
        private void LoadDataDichVuvaHopDong(string mahd)
        {
            try
            {
                dtDVvaHD = new DataTable();
                dtDVvaHD.Clear();
                DataSet ds = blhdvadv.LayDSDichVuvaHopDong(mahd);
                dtDVvaHD = ds.Tables[0];
                dgvDVvaHD.DataSource = dtDVvaHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DVvaHD !");
            }
        }

        private void dgvDVvaHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDVvaHD.CurrentCell.RowIndex;
            if (r <= dgvDVvaHD.Rows.Count - 1)
            {
                HienSoLanSuDung_NumericUpDown.Value = Convert.ToInt32(dgvDVvaHD.Rows[0].Cells[3].Value);
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            HienSoLanSuDung_NumericUpDown.Enabled = true;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            blhdvadv.CapNhatDVvaHD(dgvDVvaHD.Rows[dgvDVvaHD.CurrentCell.RowIndex].Cells[1].Value.ToString(), dgvHD.Rows[row].Cells[0].Value.ToString(), HienSoLanSuDung_NumericUpDown.Value.ToString());
            HienSoLanSuDung_NumericUpDown.Enabled = false;
            LoadDataDichVuvaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
        }

        private void ChonThemDichVu_Button_Click(object sender, EventArgs e)
        {
            blhdvadv.ThemDVvaHD(dgvDV.Rows[dgvDV.CurrentCell.RowIndex].Cells[0].Value.ToString(), dgvHD.Rows[row].Cells[0].Value.ToString(), Them_NumericUpDown.Value.ToString());
            LoadDataDichVuvaHopDong(dgvHD.Rows[row].Cells[0].Value.ToString());
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDV_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (SearchDV_ComboBox.Text)
            {
                case "Mã Dịch Vụ":
                    {
                        column = "MaDV";
                        break;
                    }
                case "Tên Dịch Vụ":
                    {
                        column = "TenDV";
                        break;
                    }
                case "Giá Dịch Vụ":
                    {
                        column = "GiaDV";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blhdvadv = new BlHoatDongDichVu();
            DataSet ds = blhdvadv.TimKiemDV(column,SearchDV_TextBox.Text);
            dtDV = new DataTable();
            dtDV = ds.Tables[0];
            dtDV.Columns.Remove("Hide");
            dgvDV.DataSource = dtDV;
        }
    }
}
