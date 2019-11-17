using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLNhanPhong
    {
        DBMain db = null;
        public BLNhanPhong()
        {
            db = new DBMain();
        }
        public DataSet LayDSKH()
        {
            return db.ExecuteQueryDataSet(" select * from KhachHang where Hide=0", CommandType.Text);
        }
        public DataSet LayDSKHSinhMa()
        {
            return db.ExecuteQueryDataSet(" select * from KhachHang ", CommandType.Text);
        }
        public bool ThemKH(string makh, string tenkh, string cmnd, string sdt, string xuatxu, string gioitinh)
        {
            string sqlString = "Insert into KhachHang values ('" + makh + "',N'" + tenkh + "','" + cmnd + "',N'" + gioitinh + "','" + sdt + "',N'" + xuatxu + "',0)";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiemKH(string column, string keyword)
        {
            string sqlString = "select * from KhachHang where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet("select * from Phong  where TinhTrang=N'Trống' and Hide=0", CommandType.Text);
        }
        public DataSet LayDSPhongSinhMa()
        {
            return db.ExecuteQueryDataSet("select * from Phong  where TinhTrang=N'Trống'", CommandType.Text);
        }
        public DataSet TimKiemPhong(string column, string keyword)
        {
            string sqlString = "select * from Phong where " + column + " like (N'%" + keyword + "%') and TinhTrang=N'Trống' and Hide=0 ";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LayDSHD()
        {
            return db.ExecuteQueryDataSet("select * from HopDong where Hide=0", CommandType.Text);
        }
        public DataSet LayDSHDSinhMa()
        {
            return db.ExecuteQueryDataSet("select * from HopDong", CommandType.Text);
        }
        public bool ThemHD(string mahd, string makh, string ngaythue, string ngaytra)
        {
            string sqlString = "Insert HopDong values('" + mahd + "','" + makh + "','" + ngaythue + "','" + ngaytra + "',0) ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemPhongvaHopDong(string mahd, string maphong)
        {
            string sqlString = "Insert PhongvaHopDong values('" + maphong + "','" + mahd + "',0) ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool CapNhatPhong(string maphong, string tinhtrang)
        {
            string sqlString = "Update Phong set TinhTrang=N'" + tinhtrang +"' where MaPhong ='" + maphong + "' and Hide=0";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet LayDSKhachDat()
        {
            string sqlSTR = "select NguoiDat.MaNguoiDat,NguoiDat.TenNguoiDat,NguoiDat.NgayHetHan,NguoiDat.SDT,Phong.MaPhong,Phong.LoaiPhong from NguoiDat, PhongvaNguoiDat, Phong where NguoiDat.MaNguoiDat = PhongvaNguoiDat.MaNguoiDat and Phong.MaPhong = PhongvaNguoiDat.MaPhong and NguoiDat.Hide=0 and PhongvaNguoiDat.Hide=0 and Phong.Hide=0";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public DataSet TimKiemKhachDat(string column, string keyword)
        {
            string sqlSTR = "select * from (select NguoiDat.MaNguoiDat,NguoiDat.TenNguoiDat,NguoiDat.NgayHetHan,NguoiDat.SDT,Phong.MaPhong,Phong.LoaiPhong from NguoiDat, PhongvaNguoiDat, Phong where NguoiDat.MaNguoiDat = PhongvaNguoiDat.MaNguoiDat and Phong.MaPhong = PhongvaNguoiDat.MaPhong and NguoiDat.Hide=0 and PhongvaNguoiDat.Hide=0 and Phong.Hide=0) as A where A."+column+"='"+keyword+"'";
            return db.ExecuteQueryDataSet(sqlSTR, CommandType.Text);
        }
        public bool XoaKhachDat(string makd)
        {
            return db.MyExecuteNonQUery("Update NguoiDat set Hide=1 where MaNguoiDat='" +makd + "'and Hide=0", CommandType.Text);
        }
        public bool XoaPhongvaKhachDat(string makd)
        {
            return db.MyExecuteNonQUery("Update PhongvaNguoiDat set Hide=1 where MaNguoiDat='" + makd + "'and Hide=0", CommandType.Text);
        }
    }
}
