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
    public partial class QuanLyPhong_Form : Form
    {
        DataTable dtPhong = null;
        bool Them;
        BLPhong blP = new BLPhong();
        public QuanLyPhong_Form()
        {
            Them = false;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();
                DataSet ds = blP.LayDSPhong();
                dtPhong = ds.Tables[0];
                dtPhong.Columns.Remove("Hide");
                dgvPHONG.DataSource = dtPhong;
                this.MaNV_TextBox.ResetText();
                this.MaPhong_TextBox.ResetText();
                this.GiaPhong_TextBox.ResetText();
                this.SDT_TextBox.ResetText();
                this.LoaiPhong_ComboBox.ResetText();
                DaThue_RadioButton.Checked = false;
                Trong_RadioButton.Checked = false;

                this.Reload_Button.Enabled = true;
                this.Edit_Button.Enabled = true;
                this.Back_Button.Enabled = true;
                this.Add_Button.Enabled = true;

                this.Cancel_Button.Enabled = false;
                this.Save_Button.Enabled = false;
                this.panel.Enabled = false;
                DaThue_RadioButton.Checked = false;
                Trong_RadioButton.Checked = false;
                DaDat_RadioButton.Checked = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung  trong table Phong !");
            }
        }
        private void FrmQuanLyDanhMucPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            if (dgvPHONG.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.MaPhong_TextBox.Text = dgvPHONG.Rows[r].Cells[0].Value.ToString();
                this.GiaPhong_TextBox.Text = dgvPHONG.Rows[r].Cells[3].Value.ToString();
                this.SDT_TextBox.Text = dgvPHONG.Rows[r].Cells[4].Value.ToString();
                this.MaNV_TextBox.Text = dgvPHONG.Rows[r].Cells[5].Value.ToString();

                switch (dgvPHONG.Rows[r].Cells[1].Value.ToString())
                {
                    case "Đơn":
                        {
                            LoaiPhong_ComboBox.Text = "Đơn";
                            break;
                        }
                    case "Đôi":
                        {
                            LoaiPhong_ComboBox.Text = "Đôi";
                            break;
                        }
                    case "Cao Cấp":
                        {
                            LoaiPhong_ComboBox.Text = "Cao Cấp";
                            break;
                        }
                }
                string Temp = dgvPHONG.Rows[r].Cells[2].Value.ToString();
                if (Temp.Length == 7)
                {
                    DaThue_RadioButton.Checked = true;
                }
                else
                {
                    if (Temp.Length == 5)
                    {
                        Trong_RadioButton.Checked = true;
                    }
                    else
                    {
                        DaDat_RadioButton.Checked = true;
                    }
                }
            }
            else
            {
                this.MaNV_TextBox.ResetText();
                this.MaPhong_TextBox.ResetText();
                this.SDT_TextBox.ResetText();
                this.GiaPhong_TextBox.ResetText();
                DaThue_RadioButton.Checked = false;
                Trong_RadioButton.Checked = false;
                DaDat_RadioButton.Checked = false;
                LoaiPhong_ComboBox.ResetText();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            SinhMa();
            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Add_Button.Enabled = false;
            this.Edit_Button.Enabled = false;
            this.Back_Button.Enabled = false;
            this.MaPhong_Label.Enabled = false;
            this.MaPhong_TextBox.Enabled = false;
            DaThue_RadioButton.Enabled = true;
            Trong_RadioButton.Enabled = true;
            DaDat_RadioButton.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string TempTinhTrang;
            if (DaThue_RadioButton.Checked == true)
            {
                TempTinhTrang = "Đã Thuê";
            }
            else
            {
                if (Trong_RadioButton.Checked == true)
                {
                    TempTinhTrang = "Trống";
                }
                else
                {
                    TempTinhTrang = "Được Đặt";
                }
            }

            if (Them)
            {
                blP = new BLPhong();
                if (blP.ThemPhong(MaPhong_TextBox.Text, LoaiPhong_ComboBox.Text, GiaPhong_TextBox.Text, SDT_TextBox.Text, MaNV_TextBox.Text, TempTinhTrang) == true)
                {
                    LoadData();
                    MessageBox.Show(" Them thanh cong");
                }
                else
                {
                    MessageBox.Show(" Them that bai");
                }
                DaThue_RadioButton.Enabled = false;
                Trong_RadioButton.Enabled = false;
                DaDat_RadioButton.Enabled = false;
            }
            else
            {
                blP = new BLPhong();
                if (blP.CapNhatPhong(MaPhong_TextBox.Text, LoaiPhong_ComboBox.Text, GiaPhong_TextBox.Text, SDT_TextBox.Text, MaNV_TextBox.Text, TempTinhTrang) == true)
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
            dtPhong = new DataTable();
            dtPhong.Clear();
            DataSet ds = blP.LayDSPhongSinhMa();
            dtPhong = ds.Tables[0];
            if (dtPhong.Rows.Count == 0)
            {
                MaPhong_TextBox.Text = "P01";
            }
            else
            {
                string a = dtPhong.Rows[dtPhong.Rows.Count-1].ItemArray[0].ToString();
                int b = Convert.ToInt32(a.Substring(1)) + 1;
                if (b < 10)
                {
                    MaPhong_TextBox.Text = "P0" + b.ToString();
                }
                else
                {
                    MaPhong_TextBox.Text = "P" + b.ToString();
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
            this.MaPhong_TextBox.Enabled = false;
            DaThue_RadioButton.Enabled = false;
            Trong_RadioButton.Enabled = false;
            DaDat_RadioButton.Enabled = false;
            this.LoaiPhong_ComboBox.Focus();
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

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (Search_ComboBox.Text)
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
            blP = new BLPhong();
            DataSet ds = blP.TimKiem(column, Search_TextBox.Text);
            dtPhong = new DataTable();
            dtPhong = ds.Tables[0];
            dtPhong.Columns.Remove("Hide");
            dgvPHONG.DataSource = dtPhong;
        }
    }
}
