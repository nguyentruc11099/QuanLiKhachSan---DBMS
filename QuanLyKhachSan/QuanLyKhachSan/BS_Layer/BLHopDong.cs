using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLHopDong
    {
        DBMain db = null;
        public BLHopDong()
        {
            db = new DBMain();
        }
        public DataSet LayDSHD()
        {
            return db.ExecuteQueryDataSet("select * from HopDong where Hide=0", CommandType.Text);
        }
        public bool CapNhatHD(string mahd, string makh, string ngaythue,string NgayTra)
        {
            string sqlString = "Update HopDong set MaKH='" + makh + "',NgayThue ='" + ngaythue + "',NgayDuKienTraPhong='"+NgayTra+"' where MaHopDong='" + mahd + "'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from HopDong where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
