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
    public partial class NhanPhongDatTruoc_Form : Form
    {
        int row;
        DataTable dtKH = null;
        DataTable dtND = null;
        DataTable dtHD = null;
        BLNhanPhong blNP = new BLNhanPhong();
        public NhanPhongDatTruoc_Form()
        {
            InitializeComponent();
        }

        private void Inside_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Inside_RadioButton.Checked == true)
            {
                KhachHangMoi_Panel.Enabled = false;
            }
            else
            {
                KhachHangMoi_Panel.Enabled = true;
                SinhMaKH();
                this.MaKH_TextBox.Enabled = false;
            }
        }
        private void SinhMaKH()
        {
            dtKH = new DataTable();
            dtKH.Clear();
            DataSet ds = blNP.LayDSKHSinhMa();
            dtKH = ds.Tables[0];
            if (dtKH.Rows.Count >= 1)
            {
                string a = dtKH.Rows[dtKH.Rows.Count-1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    MaKH_TextBox.Text = "K0" + b.ToString();
                }
                else
                {
                    MaKH_TextBox.Text = "K" + b.ToString();
                }
            }
            else
            {
                MaKH_TextBox.Text = "K01";
            }
        }
        private void SinhMaHD()
        {
            dtHD = new DataTable();
            dtHD.Clear();
            DataSet ds = blNP.LayDSHDSinhMa();
            dtHD = ds.Tables[0];
            if (dtHD.Rows.Count >= 1)
            {
                string a = dtHD.Rows[dtHD.Rows.Count - 1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    dgvHD.Rows[0].Cells[0].Value = "H0" + b.ToString();
                }
                else
                {
                    dgvHD.Rows[0].Cells[0].Value = "H" + b.ToString();
                }
            }
            else
            {
                dgvHD.Rows[0].Cells[0].Value = "H01";
            }
        }
        private void LoadDataKH()
        {
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();
                DataSet ds = blNP.LayDSKH();
                dtKH = ds.Tables[0];
                dtKH.Columns.Remove("Hide");
                dgvKH.DataSource = dtKH;
                this.MaKH_TextBox.ResetText();
                this.TenKH_TextBox.ResetText();
                this.CMND_TextBox.ResetText();
                this.SDT_TextBox.ResetText();
                this.XuatXu_TextBox.ResetText();
                Nam_RadioButton.Checked = false;
                Nu_RadioButton.Checked = false;

                this.KhachHangMoi_Panel.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung  trong table KhachHang !");
            }
        }
        private void LoadDataNguoiDat()
        {
            try
            {
                dtND = new DataTable();
                dtND.Clear();
                DataSet ds = blNP.LayDSKhachDat();
                dtND = ds.Tables[0];
                dgvKhachDat.DataSource = dtND;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DanhSachDatTruoc !");
            }
        }
        private void ChonKH_Button_Click(object sender, EventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            if (r > dgvKH.Rows.Count - 2)
            {
                return;
            }
            else
            {
                dgvHD.Rows[0].Cells[1].Value = dgvKH.Rows[r].Cells[0].Value;
                this.ChonKhachHang_Panel.Enabled = false;
            }
        }

        private void SearchKH_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (SearchKH_ComboBox.Text)
            {
                case "Mã KH":
                    {
                        column = "MaKH";
                        break;
                    }
                case "Tên KH":
                    {
                        column = "TenKH";
                        break;
                    }
                case "CMND":
                    {
                        column = "CMND";
                        break;
                    }
                case "Xuất Xứ":
                    {
                        column = "XuatXu";
                        break;
                    }
                case "SĐT":
                    {
                        column = "SDT";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blNP = new BLNhanPhong();
            DataSet ds = blNP.TimKiemKH(column, SearchKH_TextBox.Text);
            dtKH = new DataTable();
            dtKH = ds.Tables[0];
            dtKH.Columns.Remove("Hide");
            dgvKH.DataSource = dtKH;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            this.MaKH_TextBox.Enabled = false;
            string TempGioiTinh;
            if (Nam_RadioButton.Checked == true)
            {
                TempGioiTinh = "Nam";
            }
            else
            {
                TempGioiTinh = "Nữ";
            }
            blNP = new BLNhanPhong();
            if (blNP.ThemKH(MaKH_TextBox.Text, TenKH_TextBox.Text, CMND_TextBox.Text, SDT_TextBox.Text, XuatXu_TextBox.Text, TempGioiTinh) == true)
            {
                LoadDataKH();
                this.KhachHangMoi_Panel.Enabled = true;
                MessageBox.Show(" Them thanh cong");
            }
            else
            {
                MessageBox.Show(" Them that bai");
            }
        }

        private void SoNgayO_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateTime Temp = DateTime.Now;
            TimeSpan ktg = new TimeSpan(Convert.ToInt32(SoNgayO_NumericUpDown.Value), 0, 0, 0);
            Temp = Temp.Add(ktg);
            dgvHD.Rows[0].Cells[3].Value = Temp.Date.ToString();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHD_Button_Click(object sender, EventArgs e)
        {
            if (dgvHD.Rows[0].Cells[4].Value.ToString() != "" && dgvHD.Rows[0].Cells[4].Value.ToString() != "")
            {
                string a = dgvHD.Rows[0].Cells[4].Value.ToString();
                a.Trim();
                string[] A = a.Split(',');

                blNP = new BLNhanPhong();
                if (blNP.ThemHD(dgvHD.Rows[0].Cells[0].Value.ToString(), dgvHD.Rows[0].Cells[1].Value.ToString(), dgvHD.Rows[0].Cells[2].Value.ToString(), dgvHD.Rows[0].Cells[3].Value.ToString()) == true)
                {
                    MessageBox.Show(" Nhan phong thanh cong");
                }
                else
                {
                    MessageBox.Show(" Chua nhan phong duoc");
                }
                for (int i = 0; i < A.Length; i++)
                {
                    blNP = new BLNhanPhong();
                    blNP.ThemPhongvaHopDong(dgvHD.Rows[0].Cells[0].Value.ToString(), A[i]);
                    blNP.CapNhatPhong(A[i], "Đã Thuê");
                }
                blNP.XoaPhongvaKhachDat(dgvKhachDat.Rows[row].Cells[0].Value.ToString());
                blNP.XoaKhachDat(dgvKhachDat.Rows[row].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }

        private void NhanPhongDatTruoc_Form_Load(object sender, EventArgs e)
        {
            if (Inside_RadioButton.Checked == true)
            {
                KhachHangMoi_Panel.Enabled = false;
            }
            LoadDataKH();
            LoadDataNguoiDat();
            dgvHD.Rows[0].Cells[2].Value = DateTime.Now.ToString();
            DateTime Temp = Today_DateTimePicker.Value;
            Temp = Today_DateTimePicker.Value.AddDays(1);
            dgvHD.Rows[0].Cells[3].Value = Temp.Date.ToString();
            SinhMaHD();
            dgvHD.Rows[0].Cells[4].Value += "";
            dgvHD.Rows[0].Cells[1].Value += "";
        }

        private void ChonKhachDat_Button_Click(object sender, EventArgs e)
        {
            int r = dgvKhachDat.CurrentCell.RowIndex;
            row = r;
            for (int i = 0; i< dgvKhachDat.Rows.Count-1; i++)
            {
                if (dgvKhachDat.Rows[i].Cells[0].Value.ToString() == dgvKhachDat.Rows[r].Cells[0].Value.ToString())
                {
                    if (dgvHD.Rows[0].Cells[4].Value.ToString() == "")
                    {
                        dgvHD.Rows[0].Cells[4].Value += dgvKhachDat.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        dgvHD.Rows[0].Cells[4].Value += ","+dgvKhachDat.Rows[i].Cells[4].Value.ToString();
                    }
                }
            }
        }

        private void SearchKhachDat_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (SearchKhachDat_ComboBox.Text)
            {
                case "Mã Người Đặt":
                    {
                        column = "MaNguoiDat";
                        break;
                    }
                case "Tên Người Đặt":
                    {
                        column = "TenNguoiDat";
                        break;
                    }
                case "SĐT":
                    {
                        column = "SDT";
                        break;
                    }
                case "Ngày Hết Hạn":
                    {
                        column = "NgayHetHan";
                        break;
                    }
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
                default:
                    {
                        return;
                    }
            }
            blNP = new BLNhanPhong();
            DataSet ds = blNP.TimKiemKH(column, SearchKhachDat_TextBox.Text);
            dtND = new DataTable();
            dtND = ds.Tables[0];
            dtND.Columns.Remove("Hide");
            dgvKhachDat.DataSource = dtND;
        }
    }
}
