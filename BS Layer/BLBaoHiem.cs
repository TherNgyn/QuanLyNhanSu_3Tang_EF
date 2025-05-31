using QuanLyNhanSu_3Tang_EF; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    public class BLBaoHiem
    {
        private readonly QuanLyNhanSuEntities _context;

        public BLBaoHiem()
        {
            _context = new QuanLyNhanSuEntities();
        }

        // Lấy danh sách bảo hiểm kèm tên nhân viên và loại bảo hiểm
        public List<dynamic> LayBaoHiem()
        {
            var query = from cb in _context.ctBaoHiem
                        join nv in _context.NhanVien on cb.MaNV equals nv.MaNV
                        join bh in _context.BaoHiem on cb.MaLoai equals bh.MaLoai
                        select new
                        {
                            cb.MaBH,
                            cb.MaNV,
                            TenNV = nv.Ho + " " + nv.Ten,
                            bh.TenBH,
                            cb.NgayBD,
                            cb.NgayKT
                        };
            return query.ToList<dynamic>();
        }

        // Lấy danh sách loại bảo hiểm
        public List<BaoHiem> LayLoaiBaoHiem()
        {
            return _context.BaoHiem.ToList();
        }

        // Thêm bảo hiểm
        public bool ThemBaoHiem(string maNV, string maBH, string maLoai, DateTime ngayBD, DateTime ngayKT, out string err)
        {
            err = string.Empty;
            try
            {
                var baoHiem = new ctBaoHiem
                {
                    MaBH = maBH,
                    MaNV = maNV,
                    MaLoai = maLoai,
                    NgayBD = ngayBD,
                    NgayKT = ngayKT
                };
                _context.ctBaoHiem.Add(baoHiem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Xóa bảo hiểm
        public bool XoaBaoHiem(string maBH, out string err)
        {
            err = string.Empty;
            try
            {
                var baoHiem = _context.ctBaoHiem.Find(maBH);
                if (baoHiem == null)
                {
                    err = "Không tìm thấy bảo hiểm cần xóa.";
                    return false;
                }
                _context.ctBaoHiem.Remove(baoHiem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // sửa thông tin bảo hiểm
        public bool CapNhatBaoHiem(string maNV, string maBH, string maLoai, DateTime ngayBD, DateTime ngayKT, out string err)
        {
            err = string.Empty;
            try
            {
                var baoHiem = _context.ctBaoHiem.Find(maBH);
                if (baoHiem == null)
                {
                    err = "Không tìm thấy bảo hiểm cần cập nhật.";
                    return false;
                }
                baoHiem.MaNV = maNV;
                baoHiem.MaLoai = maLoai;
                baoHiem.NgayBD = ngayBD;
                baoHiem.NgayKT = ngayKT;

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
