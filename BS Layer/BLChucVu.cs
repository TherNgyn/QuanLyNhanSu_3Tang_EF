using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    public class BLChucVu
    {
        public DataSet LayChucVuTheoTrP()
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = context.ChucVu
                    .Where(cv => cv.MaCV == "CV03" || cv.MaCV == "CV04")
                    .ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("MaCV", typeof(string));
                dt.Columns.Add("TenCV", typeof(string));

                foreach (var cv in data)
                {
                    dt.Rows.Add(cv.MaCV, cv.TenCV);
                }

                ds.Tables.Add(dt);
            }
            return ds;
        }
        public DataSet LayChucVu()
        {
            DataSet ds = new DataSet();
            using (var context = new QuanLyNhanSuEntities())
            {
                var data = context.ChucVu.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("MaCV", typeof(string));
                dt.Columns.Add("TenCV", typeof(string));

                foreach (var cv in data)
                {
                    dt.Rows.Add(cv.MaCV, cv.TenCV);
                }

                ds.Tables.Add(dt);
            }
            return ds;
        }
        public bool ThemChucVu(string maCV, string tenCV, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var chucVu = new ChucVu
                    {
                        MaCV = maCV,
                        TenCV = tenCV
                    };
                    context.ChucVu.Add(chucVu);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatChucVu(string maCV, string tenCV, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var chucVu = context.ChucVu.FirstOrDefault(cv => cv.MaCV == maCV);
                    if (chucVu != null)
                    {
                        chucVu.TenCV = tenCV;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        err = "Không tìm thấy chức vụ.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaChucVu(string maCV, ref string err)
        {
            try
            {
                using (var context = new QuanLyNhanSuEntities())
                {
                    var chucVu = context.ChucVu.FirstOrDefault(cv => cv.MaCV == maCV);
                    if (chucVu != null)
                    {
                        context.ChucVu.Remove(chucVu);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        err = "Không tìm thấy chức vụ.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

    }

}
