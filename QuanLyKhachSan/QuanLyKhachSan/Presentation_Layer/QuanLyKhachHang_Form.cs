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
    public partial class QuanLyKhachHang_Form : Form
    {
        DataTable dtKH = null;
        bool Them;
        BLKhachHang blKH = new BLKhachHang();
        public QuanLyKhachHang_Form()
        {
            Them = false;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();
                DataSet ds = blKH.LayDSKH();
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
                MessageBox.Show("Không lấy được nội dung  trong table KhachHang !");
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
            this.MaKH_TextBox.Enabled = false;
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
            this.MaKH_TextBox.Enabled = false;
            this.TenKH_TextBox.Focus();
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
        private void SinhMa()
        {
            dtKH = new DataTable();
            DataSet ds = blKH.LayDSKHSinhMa();
            dtKH = ds.Tables[0];
            if (dtKH.Rows.Count == 0)
            {
                MaKH_TextBox.Text = "K01";
            }
            else
            {
                string a = this.dgvKH.Rows[this.dgvKH.Rows.Count - 2].Cells[0].Value.ToString();
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
                blKH = new BLKhachHang();
                if (blKH.ThemKH(MaKH_TextBox.Text, TenKH_TextBox.Text, CMND_TextBox.Text, SDT_TextBox.Text, XuatXu_TextBox.Text, TempGioiTinh) == true)
                {
                    LoadData();
                    MessageBox.Show(" Them thanh cong");
                }
                else
                {
                    MessageBox.Show(" Them that bai");
                }
            }
            else
            {
                blKH = new BLKhachHang();
                if (blKH.CapNhatKH(MaKH_TextBox.Text, TenKH_TextBox.Text, CMND_TextBox.Text, SDT_TextBox.Text, XuatXu_TextBox.Text, TempGioiTinh) == true)
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
        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            if (dgvKH.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaKH_TextBox.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
                this.TenKH_TextBox.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
                this.CMND_TextBox.Text = dgvKH.Rows[r].Cells[2].Value.ToString();
                this.SDT_TextBox.Text = dgvKH.Rows[r].Cells[4].Value.ToString();
                this.XuatXu_TextBox.Text = dgvKH.Rows[r].Cells[5].Value.ToString();
                string Temp = dgvKH.Rows[r].Cells[3].Value.ToString();
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
                this.MaKH_TextBox.ResetText();
                this.TenKH_TextBox.ResetText();
                this.CMND_TextBox.ResetText();
                this.SDT_TextBox.ResetText();
                this.XuatXu_TextBox.ResetText();
                Nam_RadioButton.Checked = false;
                Nu_RadioButton.Checked = false;
            }
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (Search_ComboBox.Text)
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
            blKH = new BLKhachHang();
            DataSet ds = blKH.TimKiem(column, Search_TextBox.Text);
            dtKH = new DataTable();
            dtKH = ds.Tables[0];
            dtKH.Columns.Remove("Hide");
            dgvKH.DataSource = dtKH;
        }
    }
}
