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
    public partial class QuanLyDichVu_Form : Form
    {
        DataTable dtDV = null;
        bool Them;
        BLDichVu blDV = new BLDichVu();
        public QuanLyDichVu_Form()
        {
            Them = false;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtDV = new DataTable();
                dtDV.Clear();
                DataSet ds = blDV.LayDSDV();
                dtDV = ds.Tables[0];
                dtDV.Columns.Remove("Hide");
                dgvDV.DataSource = dtDV;
                this.MaDV_TextBox.ResetText();
                this.TenDV_TextBox.ResetText();
                this.GiaDV_TextBox.ResetText();

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
                MessageBox.Show("Không lấy được nội dung trong table DichVu !");
            }
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
            this.MaDV_Label.Enabled = false;
            this.MaDV_TextBox.Enabled = false;
        }
        private void SinhMa()
        {
            dtDV = new DataTable();
            DataSet ds = blDV.LayDSDVSinhMa();
            dtDV = ds.Tables[0];
            if (dtDV.Rows.Count == 0)
            {
                MaDV_TextBox.Text = "D01";
            }
            else
            {
                string a = dtDV.Rows[dtDV.Rows.Count - 1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    MaDV_TextBox.Text = "D0" + b.ToString();
                }
                else
                {
                    MaDV_TextBox.Text = "D" + b.ToString();
                }
            }
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
            this.MaDV_TextBox.Enabled = false;
            this.TenDV_TextBox.Focus();
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                blDV = new BLDichVu();
                if (blDV.ThemDV(MaDV_TextBox.Text, TenDV_TextBox.Text, GiaDV_TextBox.Text) == true)
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
                blDV = new BLDichVu();
                if (blDV.CapNhatDV(MaDV_TextBox.Text, TenDV_TextBox.Text, GiaDV_TextBox.Text) == true)
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
            blDV = new BLDichVu();
            DataSet ds = blDV.TimKiem(column, Search_TextBox.Text);
            dtDV = new DataTable();
            dtDV = ds.Tables[0];
            dtDV.Columns.Remove("Hide");
            dgvDV.DataSource = dtDV;
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDV.CurrentCell.RowIndex;
            if (dgvDV.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaDV_TextBox.Text = dgvDV.Rows[r].Cells[0].Value.ToString();
                this.TenDV_TextBox.Text = dgvDV.Rows[r].Cells[1].Value.ToString();
                this.GiaDV_TextBox.Text = dgvDV.Rows[r].Cells[2].Value.ToString();            
            }
            else
            {
                this.MaDV_TextBox.ResetText();
                this.TenDV_TextBox.ResetText();
                this.GiaDV_TextBox.ResetText();
            }
        }
    }
}
