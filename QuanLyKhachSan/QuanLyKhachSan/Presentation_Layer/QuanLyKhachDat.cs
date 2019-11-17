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
    public partial class QuanLyKhachDat : Form
    {
        DataTable dtND = null;
        BlKhachDat blKD = new BlKhachDat();
        public QuanLyKhachDat()
        {
            InitializeComponent();
            NgayDat_DateTimePicker.Format = DateTimePickerFormat.Custom;
            NgayDat_DateTimePicker.CustomFormat = " ";
        }

        private void QuanLyKhachDat_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDat();
        }
        private void LoadDataNguoiDat()
        {
            try
            {
                dtND = new DataTable();
                dtND.Clear();
                DataSet ds = blKD.LayDSKhachDat();
                dtND = ds.Tables[0];
                dgvKhachDat.DataSource = dtND;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DanhSachDatTruoc !");
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
            blKD = new BlKhachDat();
            DataSet ds = blKD.TimKiemKhachDat(column, SearchKhachDat_TextBox.Text);
            dtND = new DataTable();
            dtND = ds.Tables[0];
            dtND.Columns.Remove("Hide");
            dgvKhachDat.DataSource = dtND;
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Edit_Button.Enabled = false;
            this.Back_Button.Enabled = false;
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {
            LoadDataNguoiDat();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            blKD = new BlKhachDat();
            if (blKD.CapNhatKhachDat(dgvKhachDat.Rows[dgvKhachDat.CurrentCell.RowIndex].Cells[0].Value.ToString(),TenNguoiDat_TextBox.Text, SDT_TextBox.Text, NgayDat_DateTimePicker.Value.ToString()) == true)
            {
                LoadDataNguoiDat();
                MessageBox.Show(" Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show(" Cap nhat that bai");
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Save_Button.Enabled = false;
            this.Cancel_Button.Enabled = false;
            this.panel.Enabled = false;

            this.Edit_Button.Enabled = true;
            this.Back_Button.Enabled = true;
        }

        private void dgvKhachDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachDat.CurrentCell.RowIndex;
            if (dgvKhachDat.Rows[r].Cells[0].Value.ToString() != "")
            {
                TenNguoiDat_TextBox.Text = dgvKhachDat.Rows[r].Cells[1].Value.ToString();
                SDT_TextBox.Text = dgvKhachDat.Rows[r].Cells[3].Value.ToString();
                NgayDat_DateTimePicker.Format = DateTimePickerFormat.Short;
                NgayDat_DateTimePicker.Value = Convert.ToDateTime(dgvKhachDat.Rows[r].Cells[2].Value.ToString());
            }
            else
            {
                TenNguoiDat_TextBox.ResetText();
                SDT_TextBox.ResetText();
                NgayDat_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayDat_DateTimePicker.CustomFormat = " ";
            }
        }
    }
}
