using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    internal class BLPhongBan
    {
        private QuanLyNhanSuEntities db;

        public BLPhongBan()
        {
            db = new QuanLyNhanSuEntities();
        }

        public DataSet LayPhongBanTheoTrP(string MaTrP)
        {
            var query = from pb in db.PhongBan
                        join nv in db.NhanVien on pb.MaTrP equals nv.MaNV into gj
                        from nv in gj.DefaultIfEmpty()
                        where pb.MaTrP == MaTrP
                        select new
                        {
                            pb.MaPB,
                            pb.TenPB,
                            pb.SDT,
                            pb.MaTrP,
                            nv.Ho,
                            nv.Ten
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPB", typeof(string));
            dt.Columns.Add("TenPB", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("MaTrP", typeof(string));
            dt.Columns.Add("Ho", typeof(string));
            dt.Columns.Add("Ten", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.MaPB, item.TenPB, item.SDT, item.MaTrP, item.Ho, item.Ten);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet LayPhongBan()
        {
            var query = from pb in db.PhongBan
                        join nv in db.NhanVien on pb.MaTrP equals nv.MaNV into gj
                        from nv in gj.DefaultIfEmpty()
                        select new
                        {
                            pb.MaPB,
                            pb.TenPB,
                            pb.SDT,
                            pb.MaTrP,
                            nv.Ho,
                            nv.Ten
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPB", typeof(string));
            dt.Columns.Add("TenPB", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("MaTrP", typeof(string));
            dt.Columns.Add("Ho", typeof(string));
            dt.Columns.Add("Ten", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.MaPB, item.TenPB, item.SDT, item.MaTrP, item.Ho, item.Ten);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet TongSoLuongNhanVienTheoPhongBan()
        {
            var query = from pb in db.PhongBan
                        join nv in db.NhanVien on pb.MaPB equals nv.MaPB
                        group pb by pb.TenPB into g
                        select new
                        {
                            TenPB = g.Key,
                            Count = g.Count()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("TenPB", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.TenPB, item.Count);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet TongSoLuongNhanVienCua1PhongBan(string MaTrP)
        {
            var query = from pb in db.PhongBan
                        join nv in db.NhanVien on pb.MaPB equals nv.MaPB
                        where pb.MaTrP == MaTrP
                        group pb by pb.TenPB into g
                        select new
                        {
                            TenPB = g.Key,
                            Count = g.Count()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("TenPB", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.TenPB, item.Count);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public bool CapNhatPhongBan(string MaPB, string TenPB, string SDT, string MaTrP, ref string err)
        {
            try
            {
                var pb = db.PhongBan.SingleOrDefault(x => x.MaPB == MaPB);
                if (pb == null)
                {
                    err = "Không tìm thấy phòng ban.";
                    return false;
                }
                pb.TenPB = TenPB;
                pb.SDT = SDT;
                pb.MaTrP = MaTrP;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool ThemPhongBan(string MaPB, string TenPB, string SDT, string MaTrP, ref string err)
        {
            try
            {
                var pb = new PhongBan()
                {
                    MaPB = MaPB,
                    TenPB = TenPB,
                    SDT = SDT,
                    MaTrP = MaTrP
                };
                db.PhongBan.Add(pb);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaPhongBan(ref string err, string MaPB)
        {
            try
            {
                var pb = db.PhongBan.SingleOrDefault(x => x.MaPB == MaPB);
                if (pb == null)
                {
                    err = "Không tìm thấy phòng ban.";
                    return false;
                }
                db.PhongBan.Remove(pb);
                db.SaveChanges();
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
