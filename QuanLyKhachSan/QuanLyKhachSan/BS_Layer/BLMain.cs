using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;
namespace QuanLyKhachSan.BS_layer
{
    class BLMain
    {
        DBMain db = null;
        public BLMain()
        {
            db = new DBMain();
        }
        public DataSet LayDSPhongHetHan()
        {
            string sqlSTR = "Select PhongvaHopDong.MaPhong,HopDong.NgayDuKienTraPhong,HopDong.MaKH,Hopdong.MaHopDong from HopDong,PhongvaHopDong where PhongvaHopDong.MaHD=HopDong.MaHopDong and PhongvaHopDong.Hide=0 and HopDong.Hide=0";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public DataSet LayDSPhongDatHetHan()
        {
            string sqlSTR = "Select NguoiDat.MaNguoiDat,PhongvaNguoiDat.MaPhong,NguoiDat.NgayHetHan from NguoiDat,PhongvaNguoiDat where NguoiDat.MaNguoiDat=PhongvaNguoiDat.MaNguoiDat and NguoiDat.Hide=0 and PhongvaNguoiDat.Hide=0";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public bool CapNhatPhong(string maphong)
        {
            string sqlSTR = "Update Phong set TinhTrang='Trống' where MaPhong='"+ maphong +"'";
            return db.MyExecuteNonQUery(sqlSTR, CommandType.Text);
        }
    }
}
