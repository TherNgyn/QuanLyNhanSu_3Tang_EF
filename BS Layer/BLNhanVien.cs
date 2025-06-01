using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLNhanVien
    {
<<<<<<< HEAD
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

=======
        private DataTable TaoDataTableNhanVien()
    {
        return new DataTable
        {
            Columns =
            {
                new DataColumn("MaNV", typeof(string)),
                new DataColumn("Ho", typeof(string)),
                new DataColumn("Ten", typeof(string)),
                new DataColumn("GioiTinh", typeof(string)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("DiaChi", typeof(string)),
                new DataColumn("SDT", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("CCCD", typeof(string)),
                new DataColumn("MaPB", typeof(string)),
                new DataColumn("MaCV", typeof(string))
            }
        };
    }
        private DataTable TaoDataTableNhanVienPBCV()
        {
            return new DataTable
            {
                Columns =
            {
                new DataColumn("MaNV", typeof(string)),
                new DataColumn("Ho", typeof(string)),
                new DataColumn("Ten", typeof(string)),
                new DataColumn("GioiTinh", typeof(string)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("DiaChi", typeof(string)),
                new DataColumn("SDT", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("CCCD", typeof(string)),
                new DataColumn("TenPB", typeof(string)),
                new DataColumn("TenCV", typeof(string))
            }
            };
        }
            public DataSet LayTatCaMaNhanVien()
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = context.NhanVien.Select(nv => nv.MaNV).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaNV", typeof(string));
                foreach (var ma in data)
                    dt.Rows.Add(ma);
                ds.Tables.Add(dt);
            }
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
            return ds;
        }

        public DataSet LayNhanVien()
        {
<<<<<<< HEAD
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
=======
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = context.NhanVien.ToList();
                DataTable dt = TaoDataTableNhanVien();
                foreach (var nv in data)
                    dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV);
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public DataSet LayNhanVien1PBCV(string MaTrP)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = (from nv in context.NhanVien
                            join pb in context.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in context.ChucVu on nv.MaCV equals cv.MaCV
                            where MaTrP == null || pb.MaTrP == MaTrP
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
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
<<<<<<< HEAD
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
=======
                            }).ToList();

                DataTable dt = TaoDataTableNhanVienPBCV();
                foreach (var nv in data)
                    dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
                ds.Tables.Add(dt);
            }
            return ds;
        }


        public DataSet LayNhanVienPBCV() => LayNhanVien1PBCV(null);

        public DataSet TimNhanVienTheoMa1PB(string MaNV, string MaTrP)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = (from nv in context.NhanVien
                            join pb in context.PhongBan on nv.MaPB equals pb.MaPB
                            join cv in context.ChucVu on nv.MaCV equals cv.MaCV
                            where nv.MaNV.Contains(MaNV) && (MaTrP == null || pb.MaTrP == MaTrP)
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
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
<<<<<<< HEAD
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
=======
                            }).ToList();

                DataTable dt = TaoDataTableNhanVienPBCV();
                foreach (var nv in data)
                {
                    dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.TenPB, nv.TenCV);
                }

                ds.Tables.Add(dt);
            }
            return ds;
        }


        public DataSet TimNhanVienTheoMa(string MaNV) => TimNhanVienTheoMa1PB(MaNV, null);

        public DataSet LayNhanVienTheoMa(string MaNV)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == MaNV);
                DataTable dt = TaoDataTableNhanVien();
                if (nv != null)
                    dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV);
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public DataSet LayNhanVienTheoHoTen(string Ho, string Ten)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = context.NhanVien
                    .Where(nv => nv.Ho.Contains(Ho) || nv.Ten.Contains(Ten))
                    .ToList();

                DataTable dt = TaoDataTableNhanVien();
                foreach (var nv in data)
                    dt.Rows.Add(nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, nv.MaPB, nv.MaCV);
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public DataSet TongNhanVienTheoGioiTinh1PB(string MaTrP)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = (from nv in context.NhanVien
                            join pb in context.PhongBan on nv.MaPB equals pb.MaPB
                            where MaTrP == null || pb.MaTrP == MaTrP
                            group nv by nv.GioiTinh into g
                            select new
                            {
                                GioiTinh = g.Key,
                                SoLuongNhanVien = g.Count()
                            }).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("GioiTinh", typeof(string));
                dt.Columns.Add("SoLuongNhanVien", typeof(int));

                foreach (var item in data)
                    dt.Rows.Add(item.GioiTinh, item.SoLuongNhanVien);

                ds.Tables.Add(dt);
            }
            return ds;
        }


        public DataSet TongNhanVienTheoGioiTinh() => TongNhanVienTheoGioiTinh1PB(null);

        public DataSet TongNhanVienTheoPhongBan1PB(string MaTrP)
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = (from nv in context.NhanVien
                            join pb in context.PhongBan on nv.MaPB equals pb.MaPB
                            where MaTrP == null || pb.MaTrP == MaTrP
                            group nv by pb.TenPB into g
                            select new
                            {
                                TenPB = g.Key,
                                SoLuongNhanVien = g.Count()
                            }).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("TenPB", typeof(string));
                dt.Columns.Add("SoLuongNhanVien", typeof(int));

                foreach (var item in data)
                    dt.Rows.Add(item.TenPB, item.SoLuongNhanVien);

                ds.Tables.Add(dt);
            }
            return ds;
        }


        public DataSet TongNhanVienTheoPhongBan() => TongNhanVienTheoPhongBan1PB(null);

        public bool CapNhatNhanVienCV(string MaNV, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, string Email, string CCCD, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == MaNV);
                    if (nv != null)
                    {
                        nv.Ho = Ho;
                        nv.Ten = Ten;
                        nv.GioiTinh = GioiTinh;
                        nv.NgaySinh = NgaySinh;
                        nv.DiaChi = DiaChi;
                        nv.SDT = SDT;
                        nv.Email = Email;
                        nv.CCCD = CCCD;
                        context.SaveChanges();
                        return true;
                    }
                }
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
            }
            catch (Exception ex)
            {
                err = ex.Message;
<<<<<<< HEAD
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
=======
            }
            return false;
        }
        public bool CapNhatNhanVien(string MaNV, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, string Email, string CCCD, string MaPB, string MaCV, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == MaNV);
                    if (nv != null)
                    {
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
                        context.SaveChanges();
                        return true;
                    }
                }
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
            }
            catch (Exception ex)
            {
                err = ex.Message;
<<<<<<< HEAD
                return false;
            }
=======
            }
            return false;
        }

        public bool ThemNhanVien(string MaNV, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, string Email, string CCCD, string MaPB, string MaCV, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var nv = new NhanVien
                    {
                        MaNV = MaNV,
                        Ho = Ho,
                        Ten = Ten,
                        GioiTinh = GioiTinh,
                        NgaySinh = NgaySinh,
                        DiaChi = DiaChi,
                        SDT = SDT,
                        Email = Email,
                        CCCD = CCCD,
                        MaPB = MaPB,
                        MaCV = MaCV
                    };
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
        }

        public bool XoaNhanVien(ref string err, string MaNV)
        {
            try
            {
<<<<<<< HEAD
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
=======
                using (var context = new QuanLyNhanSuEntities())
                {
                    var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == MaNV);
                    if (nv != null)
                    {
                        context.NhanVien.Remove(nv);
                        context.SaveChanges();
                        return true;
                    }
                }
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
            }
            catch (Exception ex)
            {
                err = ex.Message;
<<<<<<< HEAD
                return false;
            }
        }
    }
}
=======
            }
            return false;
        }

    }
}
>>>>>>> e89ba1eae74a4389fb9312ef4764af0d26c0c270
