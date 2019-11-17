using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLDichVu
    {
        DBMain db = null;
        public BLDichVu()
        {
            db = new DBMain();
        }
        public DataSet LayDSDV()
        {
            return db.ExecuteQueryDataSet(" select * from DichVu where Hide=0", CommandType.Text);
        }
        public DataSet LayDSDVSinhMa()
        {
            return db.ExecuteQueryDataSet(" select * from DichVu", CommandType.Text);
        }
        public bool CapNhatDV(string madv, string tendv, string giadv)
        {
            string sqlString = "Update DichVu set TenDV=N'" + tendv + "',GiaDV='" + giadv + "' where MaDV ='" + madv + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemDV(string madv, string tendv, string giadv)
        {
            string sqlString = "Insert into DichVu values ('" + madv + "',N'" + tendv + "','" + giadv + "',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from DichVu where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
