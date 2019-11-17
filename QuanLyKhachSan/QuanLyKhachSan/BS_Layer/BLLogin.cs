using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BS_layer
{
    class BLLogin
    {
        DB_layer.DBMain db = null;
        public BLLogin()
        {
            db = new DB_layer.DBMain();
        }
        public bool KiemTraDangNhap(string user,string password,string chucvu)
        {
            string strString = "Select * From NhanVien Where MaNV = '" + user + "' and Password = '" + password + "' and ChucVu = N'"+ chucvu +"'and Hide=0";
            return db.TestLogin(strString,System.Data.CommandType.Text);
        }
    }
}
