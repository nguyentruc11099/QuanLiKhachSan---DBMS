using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayDSNV()
        {
            return db.ExecuteQueryDataSet(" select * from NhanVien where Hide=0", CommandType.Text);
        }
        public DataSet LayDSNVMainForm(string manv)
        {
            return db.ExecuteQueryDataSet(" select * from NhanVien where Hide=0 and MaNV='"+manv+"'", CommandType.Text);
        }
        public DataSet LayDSNVSinhMa()
        {
            return db.ExecuteQueryDataSet(" select * from NhanVien", CommandType.Text);
        }
        public bool CapNhatNV(string manv, string tennv, string chucvu, string luong, string ngaysinh, string gioitinh)
        {
            string sqlString = "Update NhanVien set TenNV=N'" + tennv + "',ChucVu=N'" + chucvu + "',Luong='" + luong + "',NgaySinh ='" + ngaysinh + "',GioiTinh=N'" + gioitinh + "',Password ='a' where MaNV ='" + manv + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemNV(string manv, string tennv, string chucvu, string luong, string ngaysinh, string gioitinh,string matkhau)
        {
            string sqlString = "Insert into NhanVien values ('" + manv + "',N'" + tennv + "',N'" + chucvu + "','" + luong + "','" + ngaysinh + "',N'" + gioitinh + "',N'"+matkhau+"',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from NhanVien where " + column + " like (N'%" + keyword + "%') and Hide=0 ";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
