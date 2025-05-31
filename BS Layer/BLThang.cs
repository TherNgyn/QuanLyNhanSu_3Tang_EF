using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLThang
    {
        public DataSet LayThang()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var thangs = from t in qlnsEntity.Thang
                         select t;

            DataTable dt = new DataTable("Thang");

            dt.Columns.Add("MaThang");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("SoNgayCongChuan");

            foreach (var t in thangs)
            {
                dt.Rows.Add(t.MaThang, t.MoTa, t.SoNgayCongChuan);
            }

            DataSet ds = new DataSet("ThangDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public bool ThemThang(string MaThang, string MoTa, int SoNgayCong, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
                Thang thang = new Thang();
                thang.MaThang = MaThang;
                thang.MoTa = MoTa;
                thang.SoNgayCongChuan = SoNgayCong;

                qlnsEntity.Thang.Add(thang);
                qlnsEntity.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatThang(string MaThang, string MoTa, int SoNgayCong, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var thangQuery = (from t in qlnsEntity.Thang
                              where t.MaThang == MaThang
                              select t).SingleOrDefault();

            if (thangQuery != null)
            {
                thangQuery.MoTa = MoTa;
                thangQuery.SoNgayCongChuan = SoNgayCong;
                qlnsEntity.SaveChanges();
            }

            return true;
        }

        public bool KiemTraThangTonTai(string MaThang, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var count = (from t in qlnsEntity.Thang
                         where t.MaThang == MaThang
                         select t).Count();

            return count > 0;
        }

        // Tính số ngày công chuẩn
        public int TinhSoNgayCongChuan(string MaThang)
        {
            int soNgayLamViec = 0;

            int thang = int.Parse(MaThang.Substring(0, 2));
            int nam = int.Parse(MaThang.Substring(2, 4));

            // bắt đầu và ngày kết thúc của tháng
            DateTime ngayBatDau = new DateTime(nam, thang, 1);
            DateTime ngayKetThuc = ngayBatDau.AddMonths(1).AddDays(-1);

            // Duyệt qua từng ngày trong tháng
            for (DateTime ngay = ngayBatDau; ngay <= ngayKetThuc; ngay = ngay.AddDays(1))
            {
                if (ngay.DayOfWeek != DayOfWeek.Saturday && ngay.DayOfWeek != DayOfWeek.Sunday)
                {
                    soNgayLamViec++;
                }
            }

            return soNgayLamViec;
        }

        public string TaoMaThang(DateTime ngay)
        {
            return ngay.ToString("MMyyyy");
        }

        public string TaoMoTaThang(string maThang)
        {
            string thang = maThang.Substring(0, 2);
            string nam = maThang.Substring(2, 4);
            return $"Tháng {thang} năm {nam}";
        }
    }
}