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
    public partial class QuanLyDichVuVaHopDong_Form : Form
    {
        DataTable dtDVvaHD = null;
        BLDVvaHD blDVvaHD = new BLDVvaHD();
        public QuanLyDichVuVaHopDong_Form()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtDVvaHD = new DataTable();
                dtDVvaHD.Clear();
                DataSet ds = blDVvaHD.LayDSDVvaHD();
                dtDVvaHD = ds.Tables[0];
                dtDVvaHD.Columns.Remove("Hide");
                dgvDVvaHD.DataSource = dtDVvaHD;
                this.MaDV_TextBox.ResetText();
                this.MaHD_TextBox.ResetText();
                this.SoNgaySD_TextBox.ResetText();

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
            this.MaDV_TextBox.Enabled = false;
            this.MaHD_TextBox.Enabled = false;
            this.SoNgaySD_TextBox.Focus();
        }
       
        private void Reload_Button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            blDVvaHD = new BLDVvaHD();
            if (blDVvaHD.CapNhatDVvaHD(MaDV_TextBox.Text, MaHD_TextBox.Text, SoNgaySD_TextBox.Text) == true)
            {
                LoadData();
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
            this.Delete_Button.Enabled = true;
            this.Back_Button.Enabled = true;          
        }

        private void dgvDVvaHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDVvaHD.CurrentCell.RowIndex;
            if (dgvDVvaHD.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaDV_TextBox.Text = dgvDVvaHD.Rows[r].Cells[0].Value.ToString();
                this.MaHD_TextBox.Text = dgvDVvaHD.Rows[r].Cells[1].Value.ToString();
                this.SoNgaySD_TextBox.Text = dgvDVvaHD.Rows[r].Cells[2].Value.ToString();
            }
            else
            {
                this.MaDV_TextBox.ResetText();
                this.MaHD_TextBox.ResetText();
                this.SoNgaySD_TextBox.ResetText();
            }
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (Search_ComboBox.Text)
            {
                case "Mã Dịch Vụ":
                    {
                        column = "MaDV";
                        break;
                    }
                case "Mã Hợp Đồng":
                    {
                        column = "MaHD";
                        break;
                    }
                case "Số Ngày Sử Dụng":
                    {
                        column = "SoNgaySD";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            blDVvaHD = new BLDVvaHD();
            DataSet ds = blDVvaHD.TimKiem(column, Search_TextBox.Text);
            dtDVvaHD = new DataTable();
            dtDVvaHD = ds.Tables[0];
            dtDVvaHD.Columns.Remove("Hide");
            dgvDVvaHD.DataSource = dtDVvaHD;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            blDVvaHD.XoaDVvaHD(MaDV_TextBox.Text, MaHD_TextBox.Text);
        }
    }
}
