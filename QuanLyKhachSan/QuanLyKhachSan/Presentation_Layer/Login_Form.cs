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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Flag;
            BS_layer.BLLogin KiemTra = new BS_layer.BLLogin();
            if (RadioButton_QuanLy.Checked == true)
            {
                Flag = KiemTra.KiemTraDangNhap(txtUser.Text, txtPass.Text,"Quản Lý");
                Main_Form.QuanLyMode = true;
            }
            else
            {
                Flag = KiemTra.KiemTraDangNhap(txtUser.Text, txtPass.Text,"Lễ Tân");
                Main_Form.QuanLyMode = false;
            }
            if (Flag == true)
            {
                Main_Form.isLogin = true;
                Main_Form.user = txtUser.Text;
                Main_Form.password = txtPass.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu", "Thông báo");
                txtUser.Focus();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
