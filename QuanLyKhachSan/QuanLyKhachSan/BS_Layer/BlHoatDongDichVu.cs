using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DB_layer;
using System.Data;

namespace QuanLyKhachSan.BS_layer
{
    class BlHoatDongDichVu
    {
        DBMain db = null;
        public BlHoatDongDichVu()
        {
            db = new DBMain();
        }
        public DataSet LayDSHopDong()
        {
            string Temp = " select HopDong.MaHopDong,HopDong.MaKH,KhachHang.TenKH,HopDong.NgayThue,HopDong.NgayDuKienTraPhong from KhachHang, HopDong where KhachHang.MaKH = HopDong.MaKH and KhachHang.Hide=0 and HopDong.Hide=0";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public DataSet TimKiemHopDong(string column, string keyword)
        {
            string Temp = " select * from (select HopDong.MaHopDong,HopDong.MaKH,KhachHang.TenKH,HopDong.NgayThue,HopDong.NgayDuKienTraPhong from KhachHang, HopDong where KhachHang.MaKH = HopDong.MaKH and KhachHang.Hide=0 and HopDong.Hide=0) as A where A." + column + " like (N'%" + keyword + "%')";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public DataSet LayDSDichVuvaHopDong(string MaHD)
        {
            string Temp = " select A.MaHD,A.MaDV,DichVu.TenDV,A.SoNgaySD,DichVu.GiaDV from (select * from DichVuvaHD where MaHD = '" + MaHD + "') as A, DichVu where A.MaDV = DichVu.MaDV and A.Hide=0 and DichVu.Hide=0 ";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public DataSet LayDSDV()
        {
            return db.ExecuteQueryDataSet(" select * from DichVu where Hide=0", CommandType.Text);
        }
        public bool CapNhatDVvaHD(string madv, string mahd, string songaysd)
        {
            string sqlString = "Update DichVuvaHD set SoNgaySD='" + songaysd + "' where MaDV='"+ madv + "'and MaHD='"+mahd +"'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemDVvaHD(string madv, string mahd, string songaysd)
        {
            string sqlString = "Insert into DichVuvaHD values( '" + mahd + "','" + madv + "','" + songaysd + "',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiemDV(string column, string keyword)
        {
            string sqlString = "select * from DichVu where " + column + " like (N'%"+ keyword +"%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
