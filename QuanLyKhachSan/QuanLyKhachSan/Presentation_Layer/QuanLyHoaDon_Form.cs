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
    public partial class QuanLyHoaDon_Form : Form
    {
        DataTable dtHD = null;
        BLHoaDon blHD = new BLHoaDon();
        public QuanLyHoaDon_Form()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = blHD.LayDSHD();
                dtHD = ds.Tables[0];
                dtHD.Columns.Remove("Hide");
                dgvHD.DataSource = dtHD;
                this.MaHD_TextBox.ResetText();
                this.MaKH_TextBox.ResetText();
                NgayThue_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayThue_DateTimePicker.CustomFormat = " ";
                NgayTra_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayTra_DateTimePicker.CustomFormat = " ";
                NgayThanhToan_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayThanhToan_DateTimePicker.CustomFormat = " ";

                this.Reload_Button.Enabled = true;
                this.Edit_Button.Enabled = true;
                this.Delete_Button.Enabled = true;
                this.Back_Button.Enabled = true;

                this.Cancel_Button.Enabled = false;
                this.Save_Button.Enabled = false;
                this.panel.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DichVu&HD !");
            }
        }
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Edit_Button.Enabled = false;
            this.Delete_Button.Enabled = false;
            this.Back_Button.Enabled = false;
            this.MaHD_TextBox.Enabled = false;
            this.MaKH_TextBox.Focus();
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            blHD = new BLHoaDon();
            if (blHD.CapNhatHD(MaHD_TextBox.Text, MaKH_TextBox.Text, NgayThue_DateTimePicker.Value.Date.ToString(), NgayTra_DateTimePicker.Value.ToString(),TongTien_TextBox.Text,NgayThanhToan_DateTimePicker.Value.ToString()) == true)
            {
                LoadData();
                MessageBox.Show(" Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show(" Cap nhat that bai");
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Save_Button.Enabled = false;
            this.Cancel_Button.Enabled = false;
            this.panel.Enabled = false;

            this.Edit_Button.Enabled = true;
            this.Delete_Button.Enabled = true;
            this.Back_Button.Enabled = true;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        column = "NgayTraPhong";
                        break;
                    }
                case "Giá Tiền":
                    {
                        column = "GiaTien";
                        break;
                    }
                case "Ngày Xuất Hóa Đơn":
                    {
                        column = "NgayXuatHoaDon";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blHD = new BLHoaDon();
            DataSet ds = blHD.TimKiem(column, Search_TextBox.Text);
            dtHD = new DataTable();
            dtHD = ds.Tables[0];
            dtHD.Columns.Remove("Hide");
            dgvHD.DataSource = dtHD;
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHD.CurrentCell.RowIndex;
            if (dgvHD.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaHD_TextBox.Text = dgvHD.Rows[r].Cells[0].Value.ToString();
                this.MaKH_TextBox.Text = dgvHD.Rows[r].Cells[1].Value.ToString();
                this.TongTien_TextBox.Text = dgvHD.Rows[r].Cells[4].Value.ToString();
                NgayThue_DateTimePicker.Format = DateTimePickerFormat.Short;
                NgayTra_DateTimePicker.Format = DateTimePickerFormat.Short;
                this.NgayThue_DateTimePicker.Value = Convert.ToDateTime(dgvHD.Rows[r].Cells[2].Value.ToString());
                this.NgayTra_DateTimePicker.Value = Convert.ToDateTime(dgvHD.Rows[r].Cells[3].Value.ToString());
                this.NgayThanhToan_DateTimePicker.Value = Convert.ToDateTime(dgvHD.Rows[r].Cells[5].Value.ToString());
            }
            else
            {
                this.MaHD_TextBox.ResetText();
                this.MaKH_TextBox.ResetText();
                this.TongTien_TextBox.ResetText();
                NgayThue_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayThue_DateTimePicker.CustomFormat = " ";
                NgayTra_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayTra_DateTimePicker.CustomFormat = " ";
                NgayThanhToan_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayThanhToan_DateTimePicker.CustomFormat = " ";
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            blHD.XoaHD(MaHD_TextBox.Text);
        }
    }
}
