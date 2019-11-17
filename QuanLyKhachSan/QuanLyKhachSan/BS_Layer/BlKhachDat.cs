using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BlKhachDat
    {
        DBMain db = null;
        public BlKhachDat()
        {
            db = new DBMain();
        }
        public DataSet LayDSKhachDat()
        {
            string sqlSTR = "select NguoiDat.MaNguoiDat,NguoiDat.TenNguoiDat,NguoiDat.NgayHetHan,NguoiDat.SDT,Phong.MaPhong,Phong.LoaiPhong from NguoiDat, PhongvaNguoiDat, Phong where NguoiDat.MaNguoiDat = PhongvaNguoiDat.MaNguoiDat and Phong.MaPhong = PhongvaNguoiDat.MaPhong and NguoiDat.Hide=0 and PhongvaNguoiDat.Hide=0 and Phong.Hide=0";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public DataSet TimKiemKhachDat(string column, string keyword)
        {
            string sqlSTR = "select * from (select NguoiDat.MaNguoiDat,NguoiDat.TenNguoiDat,NguoiDat.NgayHetHan,NguoiDat.SDT,Phong.MaPhong,Phong.LoaiPhong from NguoiDat, PhongvaNguoiDat, Phong where NguoiDat.MaNguoiDat = PhongvaNguoiDat.MaNguoiDat and Phong.MaPhong = PhongvaNguoiDat.MaPhong and NguoiDat.Hide=0 and PhongvaNguoiDat.Hide=0 and Phong.Hide=0) as A where A." + column + "='" + keyword + "'";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public bool CapNhatKhachDat(string manguoidat,string tennguoidat,string sdt,string ngayhethan)
        {
            string sqlSTR = "Update NguoiDat set TenNguoiDat=N'"+tennguoidat+"',SDT='"+sdt+"',NgayHetHan='"+ngayhethan+"' where MaNguoiDat='"+manguoidat+"'";
            return db.MyExecuteNonQUery(sqlSTR, CommandType.Text);
        }
    }
}
