using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Main_Form : Form
    {
        public static bool isLogin;
        public static bool QuanLyMode;
        public static string user;
        public static string password;
        public Main_Form()
        {
            isLogin = false;
            QuanLyMode = true;
            InitializeComponent();
            KhoiTaoMoi();
            Main_MonthCalendar.Hide();
            News_RichTextBox.Hide();
            Phong_GroupBox.Hide();
            News_Label.Hide();
            this.NV_Label.Hide();
            App_Label.Show();
        }
        private void KhoiTaoMoi()
        {
            if (isLogin == false)
            {
                this.thốngKêToolStripMenuItem.Enabled = false;
                this.quảnLýToolStripMenuItem.Enabled = false;
               this.hoạtĐộngToolStripMenuItem.Enabled = false;
                this.đăngNhậpToolStripMenuItem.Enabled = true;
                this.đăngXuấtToolStripMenuItem.Enabled = false;
                this.quảnLýNhânViênToolStripMenuItem.Enabled = false;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form Temp = new Login_Form();
            Temp.ShowDialog();
            if (Main_Form.isLogin == true)
            {
                if (QuanLyMode == true)
                {
                    this.thốngKêToolStripMenuItem.Enabled = true;
                    this.quảnLýNhânViênToolStripMenuItem.Enabled = true;
                }
                this.hoạtĐộngToolStripMenuItem.Enabled = true;
                this.quảnLýToolStripMenuItem.Enabled = true;
                this.đăngNhậpToolStripMenuItem.Enabled = false;
                this.đăngXuấtToolStripMenuItem.Enabled = true;
                Main_MonthCalendar.Show();
                News_RichTextBox.Show();
                Phong_GroupBox.Show();
                App_Label.Hide();
                NV_Label.Show();
                News_Label.Show();

                BS_layer.BLNhanVien bl = new BS_layer.BLNhanVien();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                ds = bl.LayDSNVMainForm(user);
                dt = ds.Tables[0];
                FontFamily f = new FontFamily("Times New Roman");
                NV_Label.Font = new Font(f, 12);
                NV_Label.Text = "Nhân Viên đang đăng nhập: " + dt.Rows[0].ItemArray[0] + "\nTên: " + dt.Rows[0].ItemArray[1] + "\nChức Vụ: " + dt.Rows[0].ItemArray[2];
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            KhoiTaoMoi();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong_Form Temp = new QuanLyPhong_Form();
            Temp.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang_Form Temp = new QuanLyKhachHang_Form();
            Temp.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Form Temp = new QuanLyNhanVien_Form();
            Temp.ShowDialog();
        }
        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVu_Form Temp = new QuanLyDichVu_Form();
            Temp.ShowDialog();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVuVaHopDong_Form Temp = new QuanLyDichVuVaHopDong_Form();
            Temp.ShowDialog();
        }

        private void sửDụngDichVụCủaKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoatDongDichVu_Form Temp = new QuanLyHoatDongDichVu_Form();
            Temp.ShowDialog();
        }

        private void quanLyHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon_Form Temp = new QuanLyHoaDon_Form();
            Temp.ShowDialog();
        }

        private void quanLyHopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHopDong_Form Temp = new QuanLyHopDong_Form();
            Temp.ShowDialog();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Khách có đặt phòng trước không?", "Tùy Chọn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                NhanPhongKhongDatTruoc_Form Temp = new NhanPhongKhongDatTruoc_Form();
                Temp.ShowDialog();
            }
            else
            {
                if (dlr == DialogResult.Yes)
                {
                    NhanPhongDatTruoc_Form Temp = new NhanPhongDatTruoc_Form();
                    Temp.ShowDialog();
                }
            }
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong_Form Temp = new TraPhong_Form();
            Temp.ShowDialog();
        }

        private void nhậnĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDatPhong_Form Temp = new QuanLyDatPhong_Form();
            Temp.ShowDialog();
        }

        private void quảnLýKháchĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachDat Temp = new QuanLyKhachDat();
            Temp.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BS_layer.BLMain bl = new BS_layer.BLMain();
            DataSet ds = new DataSet();
            ds = bl.LayDSPhongHetHan();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan ts = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i].ItemArray[1]));
                if (ts.Days > 0)
                {
                    News_RichTextBox.AppendText(" Khách hàng có mã " + dt.Rows[i].ItemArray[2] + " đang nợ tiền phòng " + dt.Rows[i].ItemArray[0] + "   " + ts.Days + " ngày \n");
                    if (ts.Days > 10)
                    {
                        News_RichTextBox.AppendText(" Vì đã quá 10 ngày nhưng khách không thanh toán tiền nên hợp đồng sẽ chấm dứt và phòng"+ dt.Rows[i].ItemArray[0] + " sẽ được chuyển thành trống!");
                        BS_layer.BLTraPhong blTP = new BS_layer.BLTraPhong();
                        blTP.XoaDichVuVaHopDong(dt.Rows[i].ItemArray[3].ToString());
                        blTP.XoaPhongVaHopDong(dt.Rows[i].ItemArray[3].ToString());
                        blTP.XoaHopDong(dt.Rows[i].ItemArray[3].ToString());
                    }
                }
            }
            dt.Clear();
            BS_layer.BLNhanPhong blKD = new BS_layer.BLNhanPhong();
            ds = blKD.LayDSKhachDat();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan ts = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i].ItemArray[2]));
                if (ts.Days > 0)
                {
                    News_RichTextBox.AppendText(" Người đặt có mã " + dt.Rows[i].ItemArray[0] + " không đến lấy phòng " + dt.Rows[i].ItemArray[4] + " đã đặt quá " + ts.Days + " ngày nên sẽ được tự động chuyển phòng thành trống \n");
                    blKD.XoaPhongvaKhachDat(dt.Rows[i].ItemArray[0].ToString());
                    bl.CapNhatPhong(dt.Rows[i].ItemArray[4].ToString());                   
                    blKD.XoaKhachDat(dt.Rows[i].ItemArray[0].ToString());                   
                }
            }

            dt = new DataTable();
            BS_layer.BLPhong blp = new BS_layer.BLPhong();
            ds = new DataSet();
            dt.Clear();
            
            ds = blp.LayDSPhong();
            dt = ds.Tables[0];

            int sophong = dt.Rows.Count;
            int sodong = sophong / 10 + 1;
            int a = 0;
            for (int dong = 0; dong < sodong; dong++)
            {
                int phongtren1dong = sophong - dong * 10;
                phongtren1dong = phongtren1dong > 10 ? 10 : phongtren1dong;
                for (int phong = 0; phong < phongtren1dong; phong++)
                {
                    Button A = new Button();
                    A.Text = dt.Rows[a].ItemArray[0].ToString() + "\n" + dt.Rows[a].ItemArray[1].ToString();
                    if (dt.Rows[a].ItemArray[2].ToString() == "Đã Thuê")
                    {
                        A.BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        if (dt.Rows[a].ItemArray[2].ToString() == "Trống")
                        {
                            A.BackColor = Color.White;
                        }
                        else
                        {
                            A.BackColor = Color.LightBlue;
                        }
                    }
                    A.Size = new Size(65, 45);
                    A.Location = new Point(65 * phong + 5, 45 * dong + 20);
                    Phong_GroupBox.Controls.Add(A);
                    a++;   
                }
            }
        }

        private void biểuĐồTàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeTaiChinh_Form Temp = new ThongKeTaiChinh_Form();
            Temp.ShowDialog();
        }

        private void biểuĐồKháchSửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDichVu Temp = new ThongKeDichVu();
            Temp.ShowDialog();
        }
    }
}
