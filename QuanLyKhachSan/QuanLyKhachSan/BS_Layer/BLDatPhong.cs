using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLDatPhong
    {
        DBMain db = null;
        public BLDatPhong()
        {
            db = new DBMain();
        }
        public DataSet LayDSNguoiDat()
        {
            return db.ExecuteQueryDataSet(" select * from NguoiDat where Hide=0", CommandType.Text);
        }
        public DataSet LayDSNguoiDatSinhMa()
        {
            return db.ExecuteQueryDataSet(" select * from NguoiDat ", CommandType.Text);
        }
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet(" select * from Phong  where TinhTrang=N'Trống' and Hide=0", CommandType.Text);
        }
        public DataSet TimKiemPhong(string column, string keyword)
        {
            string sqlString = "select * from Phong where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemNguoiDat(string mand, string tennd, string sdt, string ngayduocdat)
        {
            string sqlString = "Insert NguoiDat values('" + mand + "',N'" + tennd + "','" + sdt + "','" + ngayduocdat + "',0) ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemPhongVaNguoiDat(string mand, string maphong)
        {
            string sqlString = "Insert PhongvaNguoiDat values('" + mand + "','" + maphong + "',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool CapNhatPhong(string maphong, string tinhtrang)
        {
            string sqlString = "Update Phong set TinhTrang=N'" + tinhtrang + "' where MaPhong ='" + maphong + "' and Hide=0 ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
    }
}
