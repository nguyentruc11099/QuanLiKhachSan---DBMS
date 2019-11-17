using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLHoaDon
    {
        DBMain db = null;
        public BLHoaDon()
        {
            db = new DBMain();
        }
        public DataSet LayDSHD()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon where Hide=0", CommandType.Text);
        }
        public bool CapNhatHD(string mahd, string makh, string ngaythue,string ngaytra,string tongtien,string ngaythanhtoan)
        {
            string sqlString = "Update HoaDon set MaKH='" + makh + "',NgayThue ='" + ngaythue + "',NgayDuKienTraPhong='" + ngaytra + "',GiaTien='"+tongtien+"',NgayXuatHoaDon='"+ngaythanhtoan+"' where MaHoaDon='" + mahd + "'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool XoaHD(string mahd)
        {
            string sqlString = "Update HoaDon set Hide=1 where MaHoaDon='" + mahd + "'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from HoaDon where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
