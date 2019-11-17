using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLDVvaHD
    {
        DBMain db = null;
        public BLDVvaHD()
        {
            db = new DBMain();
        }
        public DataSet LayDSDVvaHD()
        {
            return db.ExecuteQueryDataSet("select * from DichVuvaHD where Hide=0", CommandType.Text);
        }
        public DataSet LayDSDVvaHDSinhMa()
        {
            return db.ExecuteQueryDataSet("select * from DichVuvaHD", CommandType.Text);
        }
        public bool CapNhatDVvaHD(string madv, string mahd, string songaysd)
        {
            string sqlString = "Update DichVuvaHD set SoNgaySD='" + songaysd + "' where MaDV ='" + madv + "' and MaHD='"+ mahd +"'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from DichVuvaHD where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LayThongKeDichVu()
        {
            string sqlString = " select A.MaDV,DichVu.TenDV,DichVu.GiaDV,A.SoLanSD from(select MaDV, sum(SoNgaySD)as SoLanSD from DichVuvaHD group by DichVuvaHD.MaDV) as A,DichVu where A.MaDV = DichVu.MaDV ";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool XoaDVvaHD(string madv, string mahd)
        {
            string sqlString = "Update DichVuvaHD set Hide= 1 where MaDV ='" + madv + "' and MaHD='" + mahd + "'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
    }
}
