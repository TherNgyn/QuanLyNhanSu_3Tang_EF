using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    public class BLChucVu
    {
        private readonly QuanLyNhanSuEntities _context;

        public BLChucVu()
        {
            _context = new QuanLyNhanSuEntities();
        }

        public List<ChucVu> LayChucVuTheoTrP()
        {
            return _context.ChucVu.Where(cv => cv.MaCV == "CV03" || cv.MaCV == "CV04").ToList();
        }

        public List<ChucVu> LayChucVu()
        {
            return _context.ChucVu.ToList();
        }

        public bool ThemChucVu(string maCV, string tenCV, out string err)
        {
            err = string.Empty;
            try
            {
                var chucVu = new ChucVu { MaCV = maCV, TenCV = tenCV };
                _context.ChucVu.Add(chucVu);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatChucVu(string maCV, string tenCV, out string err)
        {
            err = string.Empty;
            try
            {
                var chucVu = _context.ChucVu.Find(maCV);
                if (chucVu == null)
                {
                    err = "Không tìm thấy chức vụ.";
                    return false;
                }
                chucVu.TenCV = tenCV;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaChucVu(string maCV, out string err)
        {
            err = string.Empty;
            try
            {
                var chucVu = _context.ChucVu.Find(maCV);
                if (chucVu == null)
                {
                    err = "Không tìm thấy chức vụ.";
                    return false;
                }
                _context.ChucVu.Remove(chucVu);
                _context.SaveChanges();
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
