using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLNhanVien
    {
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
            return ds;
        }

        public DataSet LayNhanVien()
        {
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
            }
            catch (Exception ex)
            {
                err = ex.Message;
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
            }
            catch (Exception ex)
            {
                err = ex.Message;
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
        }

        public bool XoaNhanVien(ref string err, string MaNV)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }

    }
}
