using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLThuongPhat
    {
        public DataSet LayThuongPhat()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var thuongPhats = from tp in qlnsEntity.ThuongPhat
                              select tp;

            DataTable dt = new DataTable("ThuongPhat");

            dt.Columns.Add("MaThuongPhat");
            dt.Columns.Add("Loai");
            dt.Columns.Add("SoTien");
            dt.Columns.Add("LyDo");

            foreach (var tp in thuongPhats)
            {
                dt.Rows.Add(tp.MaThuongPhat, tp.Loai, tp.SoTien, tp.LyDo);
            }

            DataSet ds = new DataSet("ThuongPhatDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TimKiemThuongPhat(string MaThuongPhat)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var thuongPhats = from tp in qlnsEntity.ThuongPhat
                              where tp.MaThuongPhat == MaThuongPhat
                              select tp;

            DataTable dt = new DataTable("ThuongPhat");

            dt.Columns.Add("MaThuongPhat");
            dt.Columns.Add("Loai");
            dt.Columns.Add("SoTien");
            dt.Columns.Add("LyDo");

            foreach (var tp in thuongPhats)
            {
                dt.Rows.Add(tp.MaThuongPhat, tp.Loai, tp.SoTien, tp.LyDo);
            }

            DataSet ds = new DataSet("ThuongPhatDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayThuongPhatTheoLoai(string Loai)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var thuongPhats = from tp in qlnsEntity.ThuongPhat
                              where tp.Loai == Loai
                              select tp;

            DataTable dt = new DataTable("ThuongPhat");

            dt.Columns.Add("MaThuongPhat");
            dt.Columns.Add("Loai");
            dt.Columns.Add("SoTien");
            dt.Columns.Add("LyDo");

            foreach (var tp in thuongPhats)
            {
                dt.Rows.Add(tp.MaThuongPhat, tp.Loai, tp.SoTien, tp.LyDo);
            }

            DataSet ds = new DataSet("ThuongPhatDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayChiTietThuongPhat()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var ctThuongPhats = from cttp in qlnsEntity.ctThuongPhat
                                select cttp;

            DataTable dt = new DataTable("ctThuongPhat");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaThuongPhat");
            dt.Columns.Add("MaThang");
            dt.Columns.Add("NgayThuongPhat");

            foreach (var cttp in ctThuongPhats)
            {
                dt.Rows.Add(cttp.MaNV, cttp.MaThuongPhat, cttp.MaThang, cttp.NgayThuongPhat);
            }

            DataSet ds = new DataSet("ChiTietThuongPhatDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LocThuongPhatNhanVien(string MaNV, string Loai)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var result = from cttp in qlnsEntity.ctThuongPhat
                         join tp in qlnsEntity.ThuongPhat on cttp.MaThuongPhat equals tp.MaThuongPhat
                         join nv in qlnsEntity.NhanVien on cttp.MaNV equals nv.MaNV
                         join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV into cvGroup
                         from cv in cvGroup.DefaultIfEmpty()
                         join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB into pbGroup
                         from pb in pbGroup.DefaultIfEmpty()
                         where tp.Loai == Loai && nv.MaNV == MaNV
                         select new
                         {
                             MaNhanVien = nv.MaNV,
                             Ho = nv.Ho,
                             Ten = nv.Ten,
                             Loai = tp.Loai,
                             LyDo = tp.LyDo,
                             TienThuongPhat = tp.SoTien,
                             MaThang = cttp.MaThang,
                             NgayThuongPhat = cttp.NgayThuongPhat,
                             TenChucVu = cv.TenCV,
                             TenPhongBan = pb.TenPB
                         };

            DataTable dt = new DataTable("ThuongPhatNhanVien");

            dt.Columns.Add("MaNhanVien");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("Loai");
            dt.Columns.Add("LyDo");
            dt.Columns.Add("TienThuongPhat");
            dt.Columns.Add("MaThang");
            dt.Columns.Add("NgayThuongPhat");
            dt.Columns.Add("TenChucVu");
            dt.Columns.Add("TenPhongBan");

            foreach (var item in result)
            {
                dt.Rows.Add(
                    item.MaNhanVien,
                    item.Ho,
                    item.Ten,
                    item.Loai,
                    item.LyDo,
                    item.TienThuongPhat,
                    item.MaThang,
                    item.NgayThuongPhat,
                    item.TenChucVu,
                    item.TenPhongBan
                );
            }

            DataSet ds = new DataSet("ThuongPhatNhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public bool ThemThuongPhat(string MaThuongPhat, string Loai, int SoTien, string LyDo, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                ThuongPhat tp = new ThuongPhat();
                tp.MaThuongPhat = MaThuongPhat;
                tp.Loai = Loai;
                tp.SoTien = SoTien;
                tp.LyDo = LyDo;

                qlnsEntity.ThuongPhat.Add(tp);
                qlnsEntity.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool ThemChiTietThuongPhat(string MaNV, string MaThuongPhat, string MaThang, int NgayThuongPhat, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                ctThuongPhat cttp = new ctThuongPhat();
                cttp.MaNV = MaNV;
                cttp.MaThuongPhat = MaThuongPhat;
                cttp.MaThang = MaThang;
                cttp.NgayThuongPhat = NgayThuongPhat;

                qlnsEntity.ctThuongPhat.Add(cttp);
                qlnsEntity.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatThuongPhat(string MaThuongPhat, string Loai, int SoTien, string LyDo, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var tpQuery = (from tp in qlnsEntity.ThuongPhat
                               where tp.MaThuongPhat == MaThuongPhat
                               select tp).SingleOrDefault();

                if (tpQuery != null)
                {
                    tpQuery.Loai = Loai;
                    tpQuery.SoTien = SoTien;
                    tpQuery.LyDo = LyDo;

                    qlnsEntity.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatNgayThangThuongPhat(string MaNV, string MaThuongPhat, string MaThang, int NgayThuongPhat, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var cttpQuery = (from cttp in qlnsEntity.ctThuongPhat
                                 where cttp.MaThuongPhat == MaThuongPhat && cttp.MaNV == MaNV
                                 select cttp).SingleOrDefault();

                if (cttpQuery != null)
                {
                    cttpQuery.MaThang = MaThang;
                    cttpQuery.NgayThuongPhat = NgayThuongPhat;

                    qlnsEntity.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaThuongPhat(ref string err, string MaThuongPhat)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var tpQuery = (from tp in qlnsEntity.ThuongPhat
                               where tp.MaThuongPhat == MaThuongPhat
                               select tp).SingleOrDefault();

                if (tpQuery != null)
                {
                    qlnsEntity.ThuongPhat.Remove(tpQuery);
                    qlnsEntity.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaChiTietThuongPhat(string MaNV, int NgayThuongPhat, string MaTP, string MaThang, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var cttpQuery = (from cttp in qlnsEntity.ctThuongPhat
                                 where cttp.MaNV == MaNV &&
                                       cttp.NgayThuongPhat == NgayThuongPhat &&
                                       cttp.MaThuongPhat == MaTP &&
                                       cttp.MaThang == MaThang
                                 select cttp).SingleOrDefault();

                if (cttpQuery != null)
                {
                    qlnsEntity.ctThuongPhat.Remove(cttpQuery);
                    qlnsEntity.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}