using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLLuong
    {
        public DataTable TinhLuongTheoThang(string maNV, string maThang, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                DataTable dtResult = new DataTable("LuongNhanVien");
                dtResult.Columns.Add("MaNV", typeof(string));
                dtResult.Columns.Add("Ho", typeof(string));
                dtResult.Columns.Add("Ten", typeof(string));
                dtResult.Columns.Add("LuongCoBan", typeof(int));
                dtResult.Columns.Add("BH01", typeof(float));
                dtResult.Columns.Add("BH02", typeof(float));
                dtResult.Columns.Add("BH03", typeof(float));
                dtResult.Columns.Add("TongTienBaoHiem", typeof(float));
                dtResult.Columns.Add("SoNgayCongChuan", typeof(int));
                dtResult.Columns.Add("SoNgayCong", typeof(float));
                dtResult.Columns.Add("TongPhuCap", typeof(int));
                dtResult.Columns.Add("GiamTruGiaCanh", typeof(int));
                dtResult.Columns.Add("TongThuongPhat", typeof(int));
                dtResult.Columns.Add("LuongThucTe", typeof(int));
                dtResult.Columns.Add("Thue", typeof(int));
                dtResult.Columns.Add("LuongThucLanh", typeof(int));

                // Lấy thông tin nhân viên và lương cơ bản
                var nhanVien = (from nv in qlnsEntity.NhanVien
                                join hd in qlnsEntity.HopDong on nv.MaHD equals hd.MaHD
                                where nv.MaNV == maNV
                                select new { nv.MaNV, nv.Ho, nv.Ten, hd.LuongCoBan }).FirstOrDefault();

                if (nhanVien == null)
                {
                    err = "Không tìm thấy thông tin nhân viên";
                    return null;
                }

                // Số ngày công chuẩn của tháng
                int soNgayCongChuan = (from t in qlnsEntity.Thang
                                       where t.MaThang == maThang
                                       select t.SoNgayCongChuan).FirstOrDefault();

                // Tính số ngày công thực tế
                double soNgayCong = (from ct in qlnsEntity.ctChamCong
                                    join cc in qlnsEntity.ChamCong on ct.MaCC equals cc.MaCC
                                    where ct.MaNV == maNV && ct.MaThang == maThang
                                    select cc.HeSo).DefaultIfEmpty(0).Sum();

                // Tính tổng phụ cấp
                int tongPhuCap = (from pc in qlnsEntity.ctPhuCap
                                  where pc.MaNV == maNV && pc.MaThang == maThang
                                  select pc.SoTien).DefaultIfEmpty(0).Sum();

                // Giảm trừ gia cảnh
                int soNguoiPhuThuoc = (from npt in qlnsEntity.NguoiPhuThuoc
                                       where npt.MaNV == maNV
                                       select npt).Count();

                int giamTruGiaCanh = soNguoiPhuThuoc * 4400000 + 11000000;

                // Tính tổng thưởng phạt
                int tongThuongPhat = (from cttp in qlnsEntity.ctThuongPhat
                                      join tp in qlnsEntity.ThuongPhat on cttp.MaThuongPhat equals tp.MaThuongPhat
                                      where cttp.MaNV == maNV && cttp.MaThang == maThang
                                      select tp.SoTien).DefaultIfEmpty(0).Sum();

                // Tính bảo hiểm
                float bhyt = 0, bhxh = 0, bhtn = 0;
                int luongCoBan = nhanVien.LuongCoBan;

                var baoHiems = from bh in qlnsEntity.ctBaoHiem
                               where bh.MaNV == maNV
                               select bh.MaLoai;

                foreach (var maLoai in baoHiems)
                {
                    switch (maLoai)
                    {
                        case "BH01":
                            bhyt = luongCoBan * 0.015f;
                            break;
                        case "BH02":
                            bhxh = luongCoBan * 0.08f;
                            break;
                        case "BH03":
                            bhtn = luongCoBan * 0.01f;
                            break;
                    }
                }

                float tongBaoHiem = bhyt + bhxh + bhtn;
                float luongThucTe = 0;
                int luongChiuThue = 0;

                if (soNgayCong == 0)
                {
                    luongThucTe = 0;
                    luongChiuThue = 0;
                }
                else
                {
                    luongThucTe = (float)(luongCoBan * soNgayCong) / soNgayCongChuan;
                    luongChiuThue = (int)(luongThucTe + tongPhuCap + tongThuongPhat - tongBaoHiem - giamTruGiaCanh);
                }

                // Thuế TNCN
                int thue = 0;
                if (luongChiuThue <= 0)
                {
                    thue = 0;
                }
                else if (luongChiuThue > 0)
                {
                    if (luongChiuThue <= 5000000)
                        thue = (int)(luongChiuThue * 0.05);
                    else if (luongChiuThue <= 10000000)
                        thue = (int)(luongChiuThue * 0.1);
                    else if (luongChiuThue <= 18000000)
                        thue = (int)(luongChiuThue * 0.15);
                    else if (luongChiuThue <= 32000000)
                        thue = (int)(luongChiuThue * 0.2);
                    else if (luongChiuThue <= 52000000)
                        thue = (int)(luongChiuThue * 0.25);
                    else if (luongChiuThue <= 80000000)
                        thue = (int)(luongChiuThue * 0.3);
                    else
                        thue = (int)(luongChiuThue * 0.35);
                }

                int luongThucLanh = 0;
                if (soNgayCong == 0)
                {
                    luongThucLanh = 0;
                }
                else
                {
                    luongThucLanh = (int)(luongThucTe + tongPhuCap + tongThuongPhat - tongBaoHiem - thue);
                }

                // Kết quả
                DataRow newRow = dtResult.NewRow();
                newRow["MaNV"] = nhanVien.MaNV;
                newRow["Ho"] = nhanVien.Ho;
                newRow["Ten"] = nhanVien.Ten;
                newRow["LuongCoBan"] = luongCoBan;
                newRow["BH01"] = bhyt;
                newRow["BH02"] = bhxh;
                newRow["BH03"] = bhtn;
                newRow["TongTienBaoHiem"] = tongBaoHiem;
                newRow["SoNgayCongChuan"] = soNgayCongChuan;
                newRow["SoNgayCong"] = soNgayCong;
                newRow["TongPhuCap"] = tongPhuCap;
                newRow["GiamTruGiaCanh"] = giamTruGiaCanh;
                newRow["TongThuongPhat"] = tongThuongPhat;
                newRow["LuongThucTe"] = luongThucTe;
                newRow["Thue"] = thue;
                newRow["LuongThucLanh"] = luongThucLanh;

                dtResult.Rows.Add(newRow);
                return dtResult;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public DataTable TinhLuongTheoThangAll(string maThang, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

                DataTable dtResult = new DataTable("LuongNhanVien");
                dtResult.Columns.Add("MaNV", typeof(string));
                dtResult.Columns.Add("Ho", typeof(string));
                dtResult.Columns.Add("Ten", typeof(string));
                dtResult.Columns.Add("LuongCoBan", typeof(int));
                dtResult.Columns.Add("LuongChiuThue", typeof(int));
                dtResult.Columns.Add("Thue", typeof(int));
                dtResult.Columns.Add("LuongThucLanh", typeof(int));

                // Lấy thông tin nhân viên và lương cơ bản
                var nhanViens = from nv in qlnsEntity.NhanVien
                                join hd in qlnsEntity.HopDong on nv.MaHD equals hd.MaHD
                                select new { nv.MaNV, nv.Ho, nv.Ten, hd.LuongCoBan };

                // Số ngày công chuẩn của tháng
                int soNgayCongChuan = (from t in qlnsEntity.Thang
                                       where t.MaThang == maThang
                                       select t.SoNgayCongChuan).FirstOrDefault();

                foreach (var nv in nhanViens)
                {
                    string maNV = nv.MaNV;
                    string ho = nv.Ho;
                    string ten = nv.Ten;
                    int luongCoBan = nv.LuongCoBan;

                    // Số ngày công
                    double soNgayCong = (from ct in qlnsEntity.ctChamCong
                                        join cc in qlnsEntity.ChamCong on ct.MaCC equals cc.MaCC
                                        where ct.MaNV == maNV && ct.MaThang == maThang
                                        select cc.HeSo).DefaultIfEmpty(0).Sum();

                    // Phụ cấp
                    int tongPhuCap = (from pc in qlnsEntity.ctPhuCap
                                      where pc.MaNV == maNV && pc.MaThang == maThang
                                      select pc.SoTien).DefaultIfEmpty(0).Sum();

                    // Thưởng phạt
                    int tongThuongPhat = (from cttp in qlnsEntity.ctThuongPhat
                                          join tp in qlnsEntity.ThuongPhat on cttp.MaThuongPhat equals tp.MaThuongPhat
                                          where cttp.MaNV == maNV && cttp.MaThang == maThang
                                          select tp.SoTien).DefaultIfEmpty(0).Sum();

                    // Bảo hiểm
                    float bhyt = 0, bhxh = 0, bhtn = 0;

                    var baoHiems = from bh in qlnsEntity.ctBaoHiem
                                   where bh.MaNV == maNV
                                   select bh.MaLoai;

                    foreach (var maLoai in baoHiems)
                    {
                        switch (maLoai)
                        {
                            case "BH01":
                                bhyt = luongCoBan * 0.015f;
                                break;
                            case "BH02":
                                bhxh = luongCoBan * 0.08f;
                                break;
                            case "BH03":
                                bhtn = luongCoBan * 0.01f;
                                break;
                        }
                    }

                    float tongBaoHiem = bhyt + bhxh + bhtn;

                    // Giảm trừ
                    int soNguoiPhuThuoc = (from npt in qlnsEntity.NguoiPhuThuoc
                                           where npt.MaNV == maNV
                                           select npt).Count();

                    int giamTruGiaCanh = soNguoiPhuThuoc * 4400000 + 11000000;

                    float luongThucTe = 0;
                    int luongChiuThue = 0;

                    if (soNgayCong == 0)
                    {
                        luongThucTe = 0;
                    }
                    else
                    {
                        luongThucTe = (float)(luongCoBan * soNgayCong) / soNgayCongChuan;
                        luongChiuThue = (int)(luongThucTe + tongPhuCap + tongThuongPhat - tongBaoHiem - giamTruGiaCanh);
                    }

                    // Thuế
                    int thue = 0;
                    if (luongChiuThue <= 0)
                        thue = 0;
                    else if (luongChiuThue > 0)
                    {
                        if (luongChiuThue <= 5000000)
                            thue = (int)(luongChiuThue * 0.05);
                        else if (luongChiuThue <= 10000000)
                            thue = (int)(luongChiuThue * 0.1);
                        else if (luongChiuThue <= 18000000)
                            thue = (int)(luongChiuThue * 0.15);
                        else if (luongChiuThue <= 32000000)
                            thue = (int)(luongChiuThue * 0.2);
                        else if (luongChiuThue <= 52000000)
                            thue = (int)(luongChiuThue * 0.25);
                        else if (luongChiuThue <= 80000000)
                            thue = (int)(luongChiuThue * 0.3);
                        else
                            thue = (int)(luongChiuThue * 0.35);
                    }

                    int luongThucLanh = 0;
                    if (soNgayCong == 0)
                    {
                        luongThucLanh = 0;
                    }
                    else
                    {
                        luongThucLanh = (int)(luongThucTe + tongPhuCap + tongThuongPhat - tongBaoHiem) - thue;
                    }

                    DataRow newRow = dtResult.NewRow();
                    newRow["LuongCoBan"] = luongCoBan;
                    newRow["MaNV"] = maNV;
                    newRow["Ho"] = ho;
                    newRow["Ten"] = ten;
                    newRow["LuongChiuThue"] = luongChiuThue;
                    newRow["Thue"] = thue;
                    newRow["LuongThucLanh"] = luongThucLanh;

                    dtResult.Rows.Add(newRow);
                }

                return dtResult;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}