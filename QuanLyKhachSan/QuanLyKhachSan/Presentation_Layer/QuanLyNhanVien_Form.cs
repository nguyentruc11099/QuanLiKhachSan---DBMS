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
    public partial class QuanLyNhanVien_Form : Form
    {
        DataTable dtNV = null;
        bool Them;
        BLNhanVien blNV = new BLNhanVien();
        public QuanLyNhanVien_Form()
        {
            Them = false;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = blNV.LayDSNV();
                dtNV = ds.Tables[0];
                dtNV.Columns.RemoveAt(6);
                dgvNV.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtNV.Columns.Remove("Hide");
                dgvNV.DataSource = dtNV;     
                this.MaNV_TextBox.ResetText();
                this.TenNV_TextBox.ResetText();
                this.Luong_TextBox.ResetText();
                this.ChucVu_ComboBox.ResetText();
                NgaySinh_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgaySinh_DateTimePicker.CustomFormat = " ";

                Nam_RadioButton.Checked = false;
                Nu_RadioButton.Checked = false;

                this.Reload_Button.Enabled = true;
                this.Edit_Button.Enabled = true;
                this.Back_Button.Enabled = true;
                this.Add_Button.Enabled = true;

                this.Cancel_Button.Enabled = false;
                this.Save_Button.Enabled = false;
                this.panel.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien !");
            }
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Them = true;
            SinhMa();
            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Add_Button.Enabled = false;
            this.Edit_Button.Enabled = false;
            this.Back_Button.Enabled = false;
            this.MaNV_TextBox.Enabled = false;
            this.MaNV_Label.Enabled = false;
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Them = false;
            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Add_Button.Enabled = false;
            this.Edit_Button.Enabled = false;
            this.Back_Button.Enabled = false;
            this.TenNV_TextBox.Focus();
            this.MaNV_TextBox.Enabled = false;
            this.MaNV_Label.Enabled = false;
            this.Password_TextBox.Enabled = false;
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

            this.Add_Button.Enabled = true;
            this.Edit_Button.Enabled = true;
            this.Back_Button.Enabled = true;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string TempGioiTinh;
            if (Nam_RadioButton.Checked == true)
            {
                TempGioiTinh = "Nam";
            }
            else
            {
                TempGioiTinh = "Nữ";
            }
            if (Them)
            {

                blNV = new BLNhanVien();
                if (Password_TextBox.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                }
                else
                {
                    if (blNV.ThemNV(MaNV_TextBox.Text, TenNV_TextBox.Text, ChucVu_ComboBox.Text, Luong_TextBox.Text, NgaySinh_DateTimePicker.Value.Date.ToString(),TempGioiTinh,Password_TextBox.Text) == true)
                    {
                        LoadData();
                        MessageBox.Show(" Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show(" Them that bai");
                    }
                    this.Password_TextBox.ResetText();
                    this.Password_TextBox.Enabled = false;
                }
            }
            else
            {
                blNV = new BLNhanVien();
                if (blNV.CapNhatNV(MaNV_TextBox.Text, TenNV_TextBox.Text, ChucVu_ComboBox.Text, Luong_TextBox.Text, NgaySinh_DateTimePicker.Value.Date.ToString(),TempGioiTinh) == true)
                {
                    LoadData();
                    MessageBox.Show(" Cap nhat thanh cong");
                }
                else
                {
                    MessageBox.Show(" Cap nhat that bai");
                }
            }
        }
        private void SinhMa()
        {
            dtNV = new DataTable();
            DataSet ds = blNV.LayDSNVSinhMa();
            dtNV = ds.Tables[0];
            if (dtNV.Rows.Count == 0)
            {
                MaNV_TextBox.Text = "N01";
            }
            else
            {
                string a = this.dgvNV.Rows[this.dgvNV.Rows.Count - 2].Cells[0].Value.ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    MaNV_TextBox.Text = "N0" + b.ToString();
                }
                else
                {
                    MaNV_TextBox.Text = "N" + b.ToString();
                }
            }
        }
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;
            if (dgvNV.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaNV_TextBox.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
                this.TenNV_TextBox.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
                this.Luong_TextBox.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
                NgaySinh_DateTimePicker.Format = DateTimePickerFormat.Short;
                this.NgaySinh_DateTimePicker.Value = Convert.ToDateTime(dgvNV.Rows[r].Cells[4].Value.ToString());

                switch (dgvNV.Rows[r].Cells[2].Value.ToString())
                {
                    case "Quản Lý":
                        {
                            this.ChucVu_ComboBox.Text = "Quản Lý";
                            break;
                        }
                    case "Lễ Tân":
                        {
                            this.ChucVu_ComboBox.Text = "Lễ Tân";
                            break;
                        }
                    case "Phục Vụ":
                        {
                            this.ChucVu_ComboBox.Text = "Phục Vụ";
                            break;
                        }
                }
                string Temp = dgvNV.Rows[r].Cells[5].Value.ToString();
                if (Temp.Length == 3)
                {
                    Nam_RadioButton.Checked = true;
                }
                else
                {
                    Nu_RadioButton.Checked = true;
                }
            }
            else
            {
                this.MaNV_TextBox.ResetText();
                this.TenNV_TextBox.ResetText();
                this.ChucVu_ComboBox.ResetText();
                this.Luong_TextBox.ResetText();
                NgaySinh_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgaySinh_DateTimePicker.CustomFormat = " ";
                Nam_RadioButton.Checked = false;
                Nu_RadioButton.Checked = false;
            }
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column ;
            switch (Search_ComboBox.Text)
            {
                case "Mã NV":
                    {
                        column = "MaNV";
                        break;
                    }
                case "Tên NV":
                    {
                        column = "TenNV";
                        break;
                    }
                case "Chức Vụ":
                    {
                        column = "Chuc Vu";
                        break;
                    }
                case "Lương":
                    {
                        column = "Luong";
                        break;
                    }
                case "Giới Tính":
                    {
                        column = "GioiTinh";
                        break;
                    }
                case "Ngày Sinh":
                    {
                        column = "NgaySinh";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blNV = new BLNhanVien();
            DataSet ds = blNV.TimKiem(column, Search_TextBox.Text);
            dtNV = new DataTable();
            dtNV = ds.Tables[0];
            dtNV.Columns.Remove("Hide");
            dgvNV.DataSource = dtNV;
        }

    }
}
