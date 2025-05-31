using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLNhanVien
    {
        public DataSet LayTatCaMaNhanVien()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var maNVs = from nv in qlnsEntity.NhanVien
                        select nv.MaNV;

            DataTable dt = new DataTable("MaNhanVien");
            dt.Columns.Add("MaNV");

            foreach (var maNV in maNVs)
            {
                dt.Rows.Add(maNV);
            }

            DataSet ds = new DataSet("MaNhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayNhanVien()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            select nv;

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("MaPB");
            dt.Columns.Add("MaCV");
            dt.Columns.Add("MaHD");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                            nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV, nv.MaHD);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayNhanVien1PBCV(String MaTrP)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV
                            where pb.MaTrP == MaTrP
                            select new
                            {
                                nv.MaNV,
                                nv.Ho,
                                nv.Ten,
                                nv.GioiTinh,
                                nv.NgaySinh,
                                nv.DiaChi,
                                nv.SDT,
                                nv.Email,
                                nv.CCCD,
                                TenPB = pb.TenPB,
                                TenCV = cv.TenCV
                            };

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TenCV");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayNhanVienPBCV()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV
                            select new
                            {
                                nv.MaNV,
                                nv.Ho,
                                nv.Ten,
                                nv.GioiTinh,
                                nv.NgaySinh,
                                nv.DiaChi,
                                nv.SDT,
                                nv.Email,
                                nv.CCCD,
                                TenPB = pb.TenPB,
                                TenCV = cv.TenCV
                            };

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TenCV");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TimNhanVienTheoMa1PB(String MaNV, String MaTrP)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV
                            where pb.MaTrP == MaTrP && nv.MaNV.Contains(MaNV)
                            select new
                            {
                                nv.MaNV,
                                nv.Ho,
                                nv.Ten,
                                nv.GioiTinh,
                                nv.NgaySinh,
                                nv.DiaChi,
                                nv.SDT,
                                nv.Email,
                                nv.CCCD,
                                TenPB = pb.TenPB,
                                TenCV = cv.TenCV
                            };

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TenCV");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TimNhanVienTheoMa(String MaNV)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in qlnsEntity.ChucVu on nv.MaCV equals cv.MaCV
                            where nv.MaNV.Contains(MaNV)
                            select new
                            {
                                nv.MaNV,
                                nv.Ho,
                                nv.Ten,
                                nv.GioiTinh,
                                nv.NgaySinh,
                                nv.DiaChi,
                                nv.SDT,
                                nv.Email,
                                nv.CCCD,
                                TenPB = pb.TenPB,
                                TenCV = cv.TenCV
                            };

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TenCV");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayNhanVienTheoMa(String MaNV)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            where nv.MaNV == MaNV
                            select nv;

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("MaPB");
            dt.Columns.Add("MaCV");
            dt.Columns.Add("MaHD");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV, nv.MaHD);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayNhanVienTheoHoTen(String Ho, String Ten)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var nhanViens = from nv in qlnsEntity.NhanVien
                            where nv.Ho.Contains(Ho) || nv.Ten.Contains(Ten)
                            select nv;

            DataTable dt = new DataTable("NhanVien");

            dt.Columns.Add("MaNV");
            dt.Columns.Add("Ho");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("MaPB");
            dt.Columns.Add("MaCV");
            dt.Columns.Add("MaHD");

            foreach (var nv in nhanViens)
            {
                dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh,
                           nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV, nv.MaHD);
            }

            DataSet ds = new DataSet("NhanVienDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TongNhanVienTheoGioiTinh1PB(String MaTrP)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var result = from nv in qlnsEntity.NhanVien
                         join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                         where pb.MaTrP == MaTrP
                         group nv by nv.GioiTinh into g
                         select new { GioiTinh = g.Key, SoLuongNhanVien = g.Count() };

            DataTable dt = new DataTable("ThongKeGioiTinh");

            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("SoLuongNhanVien", typeof(int));

            foreach (var item in result)
            {
                dt.Rows.Add(item.GioiTinh, item.SoLuongNhanVien);
            }

            DataSet ds = new DataSet("ThongKeGioiTinhDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TongNhanVienTheoGioiTinh()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var result = from nv in qlnsEntity.NhanVien
                         group nv by nv.GioiTinh into g
                         select new { GioiTinh = g.Key, SoLuongNhanVien = g.Count() };

            DataTable dt = new DataTable("ThongKeGioiTinh");

            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("SoLuongNhanVien", typeof(int));

            foreach (var item in result)
            {
                dt.Rows.Add(item.GioiTinh, item.SoLuongNhanVien);
            }

            DataSet ds = new DataSet("ThongKeGioiTinhDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TongNhanVienTheoPhongBan1PB(String MaTrP)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var result = from nv in qlnsEntity.NhanVien
                         join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                         where pb.MaTrP == MaTrP
                         group nv by pb.TenPB into g
                         select new { TenPB = g.Key, SoLuongNhanVien = g.Count() };

            DataTable dt = new DataTable("ThongKePhongBan");

            dt.Columns.Add("TenPB");
            dt.Columns.Add("SoLuongNhanVien", typeof(int));

            foreach (var item in result)
            {
                dt.Rows.Add(item.TenPB, item.SoLuongNhanVien);
            }

            DataSet ds = new DataSet("ThongKePhongBanDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet TongNhanVienTheoPhongBan()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var result = from nv in qlnsEntity.NhanVien
                         join pb in qlnsEntity.PhongBan on nv.MaPB equals pb.MaPB
                         group nv by pb.TenPB into g
                         select new { TenPB = g.Key, SoLuongNhanVien = g.Count() };

            DataTable dt = new DataTable("ThongKePhongBan");

            dt.Columns.Add("TenPB");
            dt.Columns.Add("SoLuongNhanVien", typeof(int));

            foreach (var item in result)
            {
                dt.Rows.Add(item.TenPB, item.SoLuongNhanVien);
            }

            DataSet ds = new DataSet("ThongKePhongBanDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public bool CapNhatNhanVienCV(String MaNV, String Ho, String Ten, String GioiTinh, DateTime NgaySinh, String DiaChi, String SDT, String Email, String CCCD, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var nhanVien = (from nv in qlnsEntity.NhanVien
                                where nv.MaNV == MaNV
                                select nv).SingleOrDefault();

                if (nhanVien != null)
                {
                    nhanVien.Ho = Ho;
                    nhanVien.Ten = Ten;
                    nhanVien.GioiTinh = GioiTinh;
                    nhanVien.NgaySinh = NgaySinh;
                    nhanVien.DiaChi = DiaChi;
                    nhanVien.SDT = SDT;
                    nhanVien.Email = Email;
                    nhanVien.CCCD = CCCD;

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

        public bool CapNhatNhanVien(String MaNV, String Ho, String Ten, String GioiTinh, DateTime NgaySinh, String DiaChi, String SDT, String Email, String CCCD, String MaPB, String MaCV, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var nhanVien = (from nv in qlnsEntity.NhanVien
                                where nv.MaNV == MaNV
                                select nv).SingleOrDefault();

                if (nhanVien != null)
                {
                    nhanVien.Ho = Ho;
                    nhanVien.Ten = Ten;
                    nhanVien.GioiTinh = GioiTinh;
                    nhanVien.NgaySinh = NgaySinh;
                    nhanVien.DiaChi = DiaChi;
                    nhanVien.SDT = SDT;
                    nhanVien.Email = Email;
                    nhanVien.CCCD = CCCD;
                    nhanVien.MaPB = MaPB;
                    nhanVien.MaCV = MaCV;

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

        public bool ThemNhanVien(String MaNV, String Ho, String Ten, String GioiTinh, DateTime NgaySinh, String DiaChi, String SDT, String Email, String CCCD, String MaPB, String MaCV, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                NhanVien nv = new NhanVien();
                nv.MaNV = MaNV;
                nv.Ho = Ho;
                nv.Ten = Ten;
                nv.GioiTinh = GioiTinh;
                nv.NgaySinh = NgaySinh;
                nv.DiaChi = DiaChi;
                nv.SDT = SDT;
                nv.Email = Email;
                nv.CCCD = CCCD;
                nv.MaPB = MaPB;
                nv.MaCV = MaCV;

                qlnsEntity.NhanVien.Add(nv);
                qlnsEntity.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaNhanVien(ref string err, string MaNV)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                var nhanVien = (from nv in qlnsEntity.NhanVien
                                where nv.MaNV == MaNV
                                select nv).SingleOrDefault();

                if (nhanVien != null)
                {
                    qlnsEntity.NhanVien.Remove(nhanVien);
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