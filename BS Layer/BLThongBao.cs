using QuanLyNhanSu_3Tang_EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    public class BLThongBao
    {
        private readonly QuanLyNhanSuEntities _context;

        public BLThongBao()
        {
            _context = new QuanLyNhanSuEntities();
        }

        // Lấy tất cả thông báo kèm tên phòng ban
        public List<dynamic> LayThongBao()
        {
            var query = from tb in _context.ThongBao
                        join pb in _context.PhongBan on tb.MaPB equals pb.MaPB
                        select new
                        {
                            tb.Id,
                            tb.TieuDe,
                            tb.NoiDung,
                            tb.NgayGui,
                            tb.MaPB,
                            TenPB = pb.TenPB
                        };
            return query.ToList<dynamic>();
        }

        // Lấy danh sách phòng ban
        public List<PhongBan> LayDanhSachPhongBan()
        {
            return _context.PhongBan.ToList();
        }

        // Thêm thông báo
        public bool ThemThongBao(string tieuDe, string noiDung, string maPB, DateTime ngayGui, out string err)
        {
            err = string.Empty;
            try
            {
                var thongBao = new ThongBao
                {
                    TieuDe = tieuDe,
                    NoiDung = noiDung,
                    MaPB = maPB,
                    NgayGui = ngayGui
                };
                _context.ThongBao.Add(thongBao);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Cập nhật thông báo
        public bool CapNhatThongBao(int id, string tieuDe, string noiDung, string maPB, DateTime ngayGui, out string err)
        {
            err = string.Empty;
            try
            {
                var thongBao = _context.ThongBao.Find(id);
                if (thongBao == null)
                {
                    err = "Không tìm thấy thông báo cần cập nhật.";
                    return false;
                }
                thongBao.TieuDe = tieuDe;
                thongBao.NoiDung = noiDung;
                thongBao.MaPB = maPB;
                thongBao.NgayGui = ngayGui;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Xóa thông báo
        public bool XoaThongBao(int id, out string err)
        {
            err = string.Empty;
            try
            {
                var thongBao = _context.ThongBao.Find(id);
                if (thongBao == null)
                {
                    err = "Không tìm thấy thông báo cần xóa.";
                    return false;
                }
                _context.ThongBao.Remove(thongBao);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Lấy thông báo dành cho nhân viên theo phòng ban
        public List<dynamic> LayThongBaoChoNV(string maNV)
        {
            var maPB = _context.NhanVien.Where(nv => nv.MaNV == maNV).Select(nv => nv.MaPB).FirstOrDefault();
            if (string.IsNullOrEmpty(maPB)) return new List<dynamic>();

            var query = _context.ThongBao
                        .Where(tb => tb.MaPB == maPB)
                        .OrderByDescending(tb => tb.NgayGui)
                        .ToList()  // Lấy về bộ nhớ
                        .Select(tb => new
                        {
                            Tiêu_đề_thông_báo = tb.TieuDe,
                            Nội_dung_thông_báo = tb.NoiDung,
                            Ngày_nhận = tb.NgayGui.HasValue ? tb.NgayGui.Value.ToString("dd/MM/yyyy") : ""
                        });

            return query.ToList<dynamic>();
        }
    }
}
