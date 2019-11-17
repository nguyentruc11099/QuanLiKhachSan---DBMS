using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayDSKH()
        {
            return db.ExecuteQueryDataSet(" select * from KhachHang where Hide=0", CommandType.Text);
        }
        public DataSet LayDSKHSinhMa()
        {
            return db.ExecuteQueryDataSet(" select * from KhachHang", CommandType.Text);
        }
        public bool CapNhatKH(string makh, string tenkh, string cmnd, string sdt, string xuatxu, string gioitinh)
        {
            string sqlString = "Update KhachHang set TenKH=N'" + tenkh + "',CMND='" + cmnd + "',SDT='" + sdt + "',XuatXu =N'" + xuatxu + "',GioiTinh=N'" + gioitinh + "' where MaKH ='" + makh + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemKH(string makh, string tenkh, string cmnd, string sdt, string xuatxu, string gioitinh)
        {
            string sqlString = "Insert into KhachHang values ('" + makh + "',N'" + tenkh + "','" + cmnd + "',N'" + gioitinh + "','" + sdt + "',N'" + xuatxu + "',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from KhachHang where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
