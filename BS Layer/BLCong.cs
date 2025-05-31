using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLCong
    {
        public DataSet LayDSChamCongByNV(string MaNV)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var chamCong = from ct in qlnsEntity.ctChamCong
                           join cong in qlnsEntity.ChamCong on ct.MaCC equals cong.MaCC
                           join thg in qlnsEntity.Thang on ct.MaThang equals thg.MaThang
                           where ct.MaNV == MaNV
                           select new
                           {
                               ct.NgayChamCong,
                               Thang = thg.MoTa,
                               MoTa = cong.MoTa,
                               cong.HeSo
                           };

            DataTable dt = new DataTable("ChamCong");

            dt.Columns.Add("NgayChamCong");
            dt.Columns.Add("Thang");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("HeSo");

            foreach (var item in chamCong)
            {
                dt.Rows.Add(item.NgayChamCong, item.Thang, item.MoTa, item.HeSo);
            }

            DataSet ds = new DataSet("ChamCongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet LayDSChamCong()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var chamCong = from cong in qlnsEntity.ChamCong
                           select cong;

            DataTable dt = new DataTable("ChamCong");

            dt.Columns.Add("MaCC");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("HeSo");

            foreach (var item in chamCong)
            {
                dt.Rows.Add(item.MaCC, item.MoTa, item.HeSo);
            }

            DataSet ds = new DataSet("ChamCongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }

        public bool ChamCong(string MaNV, string MaCC, ref string err)
        {
            try
            {
                QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
                BLThang blThang = new BLThang();

                DateTime ngayHienTai = DateTime.Now;
                string maThang = blThang.TaoMaThang(ngayHienTai);
                int ngayChamCong = ngayHienTai.Day;

                if (!blThang.KiemTraThangTonTai(maThang, ref err))
                {
                    int soNgayCongChuan = blThang.TinhSoNgayCongChuan(maThang);
                    string moTa = blThang.TaoMoTaThang(maThang);

                    if (!blThang.ThemThang(maThang, moTa, soNgayCongChuan, ref err))
                    {
                        return false;
                    }
                }

                if (KiemTraDaChamCong(MaNV, maThang, ngayChamCong, ref err))
                {
                    err = "Đã chấm công cho ngày này";
                    return false;
                }

                ctChamCong ctcc = new ctChamCong();
                ctcc.MaNV = MaNV;
                ctcc.MaCC = MaCC;
                ctcc.MaThang = maThang;
                ctcc.NgayChamCong = ngayChamCong;

                qlnsEntity.ctChamCong.Add(ctcc);
                qlnsEntity.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        private bool KiemTraDaChamCong(string maNV, string maThang, int ngayChamCong, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var count = (from ct in qlnsEntity.ctChamCong
                         where ct.MaNV == maNV && ct.MaThang == maThang && ct.NgayChamCong == ngayChamCong
                         select ct).Count();

            return count > 0;
        }

        public bool ThemCong(string MaCC, string MoTa, float HeSo, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            ChamCong cong = new ChamCong();
            cong.MaCC = MaCC;
            cong.MoTa = MoTa;
            cong.HeSo = HeSo;

            qlnsEntity.ChamCong.Add(cong);
            qlnsEntity.SaveChanges();

            return true;
        }

        public bool SuaCong(string MaCC, string MoTa, float HeSo, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var congQuery = (from cong in qlnsEntity.ChamCong
                             where cong.MaCC == MaCC
                             select cong).SingleOrDefault();

            if (congQuery != null)
            {
                congQuery.MoTa = MoTa;
                congQuery.HeSo = HeSo;
                qlnsEntity.SaveChanges();
            }

            return true;
        }
    }
}