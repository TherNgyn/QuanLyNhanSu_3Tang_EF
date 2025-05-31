using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLHopDong
    {
        public DataSet LayHopDong()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var hopDongs = from p in qlnsEntity.HopDong
                           select p;

            DataTable dt = new DataTable("HopDong");

            dt.Columns.Add("MaHD");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("LuongCoBan");
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");

            foreach (var p in hopDongs)
            {
                dt.Rows.Add(p.MaHD, p.MaNV, p.LuongCoBan, p.NgayBD, p.NgayKT);
            }

            DataSet ds = new DataSet("HopDongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }
        public DataSet TimKiemHopDong(string MaNV)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var hopDongs = from p in qlnsEntity.HopDong
                           where p.MaNV == MaNV
                           select p;

            DataTable dt = new DataTable("HopDong");

            dt.Columns.Add("MaHD");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("LuongCoBan");
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");

            foreach (var p in hopDongs)
            {
                dt.Rows.Add(p.MaHD, p.MaNV, p.LuongCoBan, p.NgayBD, p.NgayKT);
            }

            DataSet ds = new DataSet("HopDongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }
        public DataSet XemChiTietHopDong(string MaNV)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var chiTietHopDong = from nv in qlnsEntity.NhanVien
                                 join hd in qlnsEntity.HopDong on nv.MaHD equals hd.MaHD
                                 join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV
                                 join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                                 where nv.MaNV == MaNV
                                 select new
                                 {
                                     nv.MaNV,
                                     hd.MaHD,
                                     hd.LuongCoBan,
                                     NgayBatDauHopDong = hd.NgayBD,
                                     NgayKetThucHopDong = hd.NgayKT,
                                     TenPhongBan = pb.TenPB,
                                     TenChucVu = cv.TenCV
                                 };

            DataTable dt = new DataTable("ChiTietHopDong");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaHD");
            dt.Columns.Add("LuongCoBan");
            dt.Columns.Add("NgayBatDauHopDong");
            dt.Columns.Add("NgayKetThucHopDong");
            dt.Columns.Add("TenPhongBan");
            dt.Columns.Add("TenChucVu");

            foreach (var item in chiTietHopDong)
            {
                dt.Rows.Add(
                    item.MaNV,
                    item.MaHD,
                    item.LuongCoBan,
                    item.NgayBatDauHopDong,
                    item.NgayKetThucHopDong,
                    item.TenPhongBan,
                    item.TenChucVu
                );
            }

            DataSet ds = new DataSet("ChiTietHopDongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }
        public bool ThemHopDonng(string MaHD, string MaNV, int LuongCoBan, DateTime NgayBD, DateTime NgayKT, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;
            hd.MaNV = MaNV;
            hd.LuongCoBan = LuongCoBan;
            hd.NgayBD = NgayBD;
            hd.NgayKT = NgayKT;

            qlnsEntity.HopDong.Add(hd);
            qlnsEntity.SaveChanges();

            return true;
        }
        public bool XoaHopDong(ref string err, string MaHD)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;

            qlnsEntity.HopDong.Attach(hd);
            qlnsEntity.SaveChanges();
            return true;
        }
        public bool CapNhatHopDong(string MaHD, string MaNV, int LuongCoBan, DateTime NgayBD, DateTime NgayKT, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            var hdQuery = (from hd in qlnsEntity.HopDong
                           where hd.MaHD == MaHD
                           select hd).SingleOrDefault();
            if (hdQuery != null)
            {
                hdQuery.MaNV = MaNV;
                hdQuery.LuongCoBan = LuongCoBan;
                hdQuery.NgayBD = NgayBD;
                hdQuery.NgayKT = NgayKT;
                qlnsEntity.SaveChanges();
            }
            return true;
        }
        public DataSet LayHopDongSapHetHan()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            DateTime now = DateTime.Now;
            DateTime cutOffDate = now.AddDays(30);

            var hopDongs = from p in qlnsEntity.HopDong
                           where p.NgayKT >= now && p.NgayKT <= cutOffDate
                           select p;

            DataTable dt = new DataTable("HopDong");

            dt.Columns.Add("MaHD");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("LuongCoBan");
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");

            foreach (var p in hopDongs)
            {
                dt.Rows.Add(p.MaHD, p.MaNV, p.LuongCoBan, p.NgayBD, p.NgayKT);
            }

            DataSet ds = new DataSet("HopDongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }
    }
}
