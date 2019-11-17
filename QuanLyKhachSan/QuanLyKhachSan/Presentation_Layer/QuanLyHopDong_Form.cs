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
    public partial class QuanLyHopDong_Form : Form
    {
        DataTable dtHD = null;
        BLHopDong blHD = new BLHopDong();
        public QuanLyHopDong_Form()
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

                this.Reload_Button.Enabled = true;
                this.Edit_Button.Enabled = true;
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
            this.Back_Button.Enabled = false;
            this.MaHD_TextBox.Enabled = false;
            this.MaKH_TextBox.Focus();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Save_Button.Enabled = false;
            this.Cancel_Button.Enabled = false;
            this.panel.Enabled = false;

            this.Edit_Button.Enabled = true;
            this.Back_Button.Enabled = true;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            blHD = new BLHopDong();
            if (blHD.CapNhatHD(MaHD_TextBox.Text, MaKH_TextBox.Text,NgayThue_DateTimePicker.Value.Date.ToString(),NgayTra_DateTimePicker.Value.ToString()) == true)
            {
                LoadData();
                MessageBox.Show(" Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show(" Cap nhat that bai");
            }
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHD.CurrentCell.RowIndex;
            if (dgvHD.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaHD_TextBox.Text = dgvHD.Rows[r].Cells[0].Value.ToString();
                this.MaKH_TextBox.Text = dgvHD.Rows[r].Cells[1].Value.ToString();
                NgayThue_DateTimePicker.Format = DateTimePickerFormat.Short;
                NgayTra_DateTimePicker.Format = DateTimePickerFormat.Short;
                this.NgayThue_DateTimePicker.Value = Convert.ToDateTime(dgvHD.Rows[r].Cells[2].Value.ToString());
                this.NgayTra_DateTimePicker.Value = Convert.ToDateTime(dgvHD.Rows[r].Cells[3].Value.ToString());
            }
            else
            {
                this.MaHD_TextBox.ResetText();
                this.MaKH_TextBox.ResetText();
                NgayThue_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayThue_DateTimePicker.CustomFormat = " ";
                NgayTra_DateTimePicker.Format = DateTimePickerFormat.Custom;
                NgayTra_DateTimePicker.CustomFormat = " ";
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
                default:
                    {
                        return;
                    }
            }
            blHD = new BLHopDong();
            DataSet ds = blHD.TimKiem(column, Search_TextBox.Text);
            dtHD = new DataTable();
            dtHD = ds.Tables[0];
            dtHD.Columns.Remove("Hide");
            dgvHD.DataSource = dtHD;
        }
    }
}
