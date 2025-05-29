using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    class BLHopDong
    {
        public DataSet LayHopDong()
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();

            var hopDongs = from p in qlnsEntity.HopDong
                           select p;

            DataTable dt = new DataTable("HopDong");

            dt.Columns.Add("MaHD");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("LuongCoBan");
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");

            foreach (var p in hopDongs)
            {
                dt.Rows.Add(p.MaHD, p.MaNV, p.LuongCoBan, p.NgayBD, p.NgayKT);
            }

            DataSet ds = new DataSet("HopDongDataSet");
            ds.Tables.Add(dt);

            return ds;
        }
        public bool ThemHopDonng(string MaHD, string MaNV, int LuongCoBan, DateTime NgayBD, DateTime NgayKT, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;
            hd.MaNV = MaNV;
            hd.LuongCoBan = LuongCoBan;
            hd.NgayBD = NgayBD;
            hd.NgayKT = NgayKT;

            qlnsEntity.HopDong.Add(hd);
            qlnsEntity.SaveChanges();

            return true;
        }
        public bool XoaHopDong(ref string err, string MaHD)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;

            qlnsEntity.HopDong.Attach(hd);
            qlnsEntity.SaveChanges();
            return true;
        }
        public bool CapNhatHopDong(string MaHD, string MaNV, int LuongCoBan, DateTime NgayBD, DateTime NgayKT, ref string err)
        {
            QuanLyNhanSuEntities qlnsEntity = new QuanLyNhanSuEntities();
            var hdQuery = (from hd in qlnsEntity.HopDong
                           where hd.MaHD == MaHD
                           select hd).SingleOrDefault();
            if (hdQuery != null)
            {
                hdQuery.MaNV = MaNV;
                hdQuery.LuongCoBan = LuongCoBan;
                hdQuery.NgayBD = NgayBD;
                hdQuery.NgayKT = NgayKT;
                qlnsEntity.SaveChanges();
            }
            return true;
        }
        public DataSet LayHopDongSapHetHan()
        {
            DataSet ds = new DataSet("HopDongDataSet");
            

            return ds;
        }
    }
}
