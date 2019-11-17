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
    public partial class QuanLyDatPhong_Form : Form
    {
        DataTable dtPhong = null;
        DataTable dtHD = null;
        BLDatPhong blDP = new BLDatPhong();
        public QuanLyDatPhong_Form()
        {
            InitializeComponent();
            LoadDataPhong();
            SinhMaHD();
            dgvHD.Rows[0].Cells[4].Value = "";
            dgvHD.Rows[0].Cells[2].Value = "";
            dgvHD.Rows[0].Cells[1].Value = "";
            dgvHD.Rows[0].Cells[3].Value = NgayDuocDat_DateTimePicker.Value.ToString();
        }
        void LoadDataPhong()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();
                DataSet ds = blDP.LayDSPhong();
                dtPhong = ds.Tables[0];
                dgvPhong.DataSource = dtPhong;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Phong !");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[3].Value = NgayDuocDat_DateTimePicker.Value.ToString();
        }

        private void TenNguoiDat_TextBox_TextChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[1].Value = TenNguoiDat_TextBox.Text;
        }

        private void SDT_TextBox_TextChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[2].Value = SDT_TextBox.Text;
        }
        private void SinhMaHD()
        {
            dtHD = new DataTable();
            dtHD.Clear();
            DataSet ds = blDP.LayDSNguoiDatSinhMa();
            dtHD = ds.Tables[0];
            if (dtHD.Rows.Count == 0)
            {
                dgvHD.Rows[0].Cells[0].Value = "M01";
            }
            else
            {
                string a = dtHD.Rows[dtHD.Rows.Count - 1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    dgvHD.Rows[0].Cells[0].Value = "M0" + b.ToString();
                }
                else
                {
                    dgvHD.Rows[0].Cells[0].Value = "M" + b.ToString();
                }
            }
        }
        private void SearchPhong_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (SearchPhong_ComboBox.Text)
            {
                case "Mã Phòng":
                    {
                        column = "MaPhong";
                        break;
                    }
                case "Loại Phòng":
                    {
                        column = "LoaiPhong";
                        break;
                    }
                case "Tình Trạng":
                    {
                        column = "TinhTrang";
                        break;
                    }
                case "Mã Nhân Viên Phụ Trách":
                    {
                        column = "MaNV";
                        break;
                    }
                case "SĐT":
                    {
                        column = "SDT";
                        break;
                    }
                case "Giá Phòng":
                    {
                        column = "GiaPhong";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blDP = new BLDatPhong();
            DataSet ds = blDP.TimKiemPhong(column, SearchPhong_TextBox.Text);
            dtPhong = new DataTable();
            dtPhong = ds.Tables[0];
            dtPhong.Columns.Remove("Hide");
            dgvPhong.DataSource = dtPhong;
        }

        private void ChonPhong_Button_Click(object sender, EventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            if (r > dgvPhong.Rows.Count - 2)
            {
                return;
            }
            else
            {
                if (dgvHD.Rows[0].Cells[4].Value.ToString() == "")
                {
                    dgvHD.Rows[0].Cells[4].Value += dgvPhong.Rows[r].Cells[0].Value.ToString();
                }
                else
                {
                    dgvHD.Rows[0].Cells[4].Value += "," + dgvPhong.Rows[r].Cells[0].Value.ToString();
                }
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemNguoiDatvaPhongDat_Button_Click(object sender, EventArgs e)
        {
            if (dgvHD.Rows[0].Cells[4].Value.ToString() != "" && dgvHD.Rows[0].Cells[2].Value.ToString() != "" &&dgvHD.Rows[0].Cells[1].Value.ToString()!="")
            {
                string a = dgvHD.Rows[0].Cells[4].Value.ToString();
                a.Trim();
                string[] A = a.Split(',');

                blDP = new BLDatPhong();
                if (blDP.ThemNguoiDat(dgvHD.Rows[0].Cells[0].Value.ToString(), dgvHD.Rows[0].Cells[1].Value.ToString(), dgvHD.Rows[0].Cells[2].Value.ToString(), dgvHD.Rows[0].Cells[3].Value.ToString()) == true)
                {
                    MessageBox.Show(" Nhan phong thanh cong");
                }
                else
                {
                    MessageBox.Show(" Chua nhan phong duoc");
                }
                for (int i = 0; i < A.Length; i++)
                {
                    blDP = new BLDatPhong();
                    blDP.ThemPhongVaNguoiDat(dgvHD.Rows[0].Cells[0].Value.ToString(), A[i]);
                    blDP.CapNhatPhong(A[i], "Được Đặt");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[4].Value = "";
        }
    }
}
