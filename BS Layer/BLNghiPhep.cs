using QuanLyNhanSu_3Tang_EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    public class BLNghiPhep
    {
        private readonly QuanLyNhanSuEntities _context;

        public BLNghiPhep()
        {
            _context = new QuanLyNhanSuEntities();
        }

        // Lấy danh sách nghỉ phép cùng tên nhân viên và tên tháng
        public List<NghiPhepDTO> LayNghiPhep()
        {
            var query = from np in _context.NghiPhep
                        join nv in _context.NhanVien on np.MaNV equals nv.MaNV
                        join t in _context.Thang on np.MaThang equals t.MaThang
                        select new NghiPhepDTO
                        {
                            MaNV = np.MaNV,
                            MaThang = np.MaThang,
                            NgayNghiPhep = np.NgayNghiPhep,
                            GhiChu = np.GhiChu,
                            TenNV = nv.Ho + " " + nv.Ten,
                            TenThang = t.MoTa
                        };
            return query.ToList();
        }

        public bool ThemNghiPhep(string maNV, string maThang, int ngayNghi, string ghiChu, out string err)
        {
            err = string.Empty;
            try
            {
                var nghiPhep = new NghiPhep
                {
                    MaNV = maNV,
                    MaThang = maThang,
                    NgayNghiPhep = ngayNghi,
                    GhiChu = ghiChu
                };
                _context.NghiPhep.Add(nghiPhep);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatNghiPhep(string maNV, string maThang, int ngayNghi, string ghiChu, out string err)
        {
            err = string.Empty;
            try
            {
                var nghiPhep = _context.NghiPhep.FirstOrDefault(np => np.MaNV == maNV && np.MaThang == maThang);
                if (nghiPhep == null)
                {
                    err = "Không tìm thấy bản ghi để cập nhật.";
                    return false;
                }
                nghiPhep.NgayNghiPhep = ngayNghi;
                nghiPhep.GhiChu = ghiChu;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaNghiPhep(string maNV, string maThang, out string err)
        {
            err = string.Empty;
            try
            {
                var nghiPhep = _context.NghiPhep.FirstOrDefault(np => np.MaNV == maNV && np.MaThang == maThang);
                if (nghiPhep == null)
                {
                    err = "Không tìm thấy bản ghi để xóa.";
                    return false;
                }
                _context.NghiPhep.Remove(nghiPhep);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public List<Thang> LayLoaiThang()
        {
            return _context.Thang.ToList();
        }
    }

    // DTO dùng để binding DataGridView (bạn đặt trong namespace BS_Layer)
    public class NghiPhepDTO
    {
        public string MaNV { get; set; }
        public string MaThang { get; set; }
        public int NgayNghiPhep { get; set; }
        public string GhiChu { get; set; }
        public string TenNV { get; set; }
        public string TenThang { get; set; }
    }
}
