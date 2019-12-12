using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation_Layer
{
    public partial class Login : Form
    {
        public int? EmployeeID { get; set; }
        public Login()
        {
            InitializeComponent();            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.EmployeeID = 0;
            rbtn_Admin.Checked = true;
            txb_Account.Text = "312383707";
            txb_Password.Text = "0000";
            txb_Password.PasswordChar = '*';
        }
        public void Authenication()
        {
            BS_Layer.BLEmployee Authenication = new BS_Layer.BLEmployee();
            if (rbtn_Admin.Checked == true)
            {
                var Flag = Authenication.Login(Convert.ToInt32(txb_Account.Text), txb_Password.Text, 1);
                if (Flag != null)
                {
                    this.EmployeeID = Flag;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu", "Thông báo");
                    txb_Account.Focus();
                }
            }
            else
            {
                var Flag = Authenication.Login(Convert.ToInt32(txb_Account.Text), txb_Password.Text, 2);
                if (Flag != null)
                {
                    this.EmployeeID = Convert.ToInt32(Flag);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu", "Thông báo");
                    txb_Account.Focus();
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Authenication();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
