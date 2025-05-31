using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_3Tang_EF.BS_Layer
{
    internal class BLTaiKhoan
    {
        private QuanLyNhanSuEntities db;

        public BLTaiKhoan()
        {
            db = new QuanLyNhanSuEntities();
        }

        public DataTable AuthenticateUser(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                var query = from tk in db.TaiKhoan
                            join ltk in db.LoaiTaiKhoan on tk.MaLoai equals ltk.MaLoai
                            where tk.TenDangNhap == username && tk.MatKhau == password
                            select new { tk.MaLoai, ltk.Ten };

                dt.Columns.Add("MaLoai", typeof(string));
                dt.Columns.Add("Ten", typeof(string));

                foreach (var item in query)
                {
                    dt.Rows.Add(item.MaLoai, item.Ten);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi xác thực người dùng: " + ex.Message, ex);
            }
            return dt;
        }

        public string AuthenticateUser(string username, string password, out string roleName)
        {
            roleName = string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.";
            }

            try
            {
                DataTable result = AuthenticateUser(username, password);

                if (result != null && result.Rows.Count > 0)
                {
                    roleName = result.Rows[0]["Ten"].ToString();
                    return "SUCCESS";
                }
                else
                {
                    return "Tên đăng nhập hoặc mật khẩu không đúng.";
                }
            }
            catch (Exception ex)
            {
                return "Đã xảy ra lỗi trong quá trình xác thực: " + ex.Message;
            }
        }

        public string LayRoleName(string username)
        {
            var query = from tk in db.TaiKhoan
                        join ltk in db.LoaiTaiKhoan on tk.MaLoai equals ltk.MaLoai
                        where tk.TenDangNhap == username
                        select ltk.Ten;

            string roleName = query.FirstOrDefault();
            return roleName ?? string.Empty;
        }

        public DataSet LayTenLoaiTaiKhoan()
        {
            var query = (from tk in db.TaiKhoan
                         join ltk in db.LoaiTaiKhoan on tk.MaLoai equals ltk.MaLoai
                         select new { tk.MaLoai, ltk.Ten }).Distinct();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaLoai", typeof(string));
            dt.Columns.Add("Ten", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.MaLoai, item.Ten);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet LayThongTinTaiKhoan()
        {
            var query = from tk in db.TaiKhoan
                        join nv in db.NhanVien on tk.TenDangNhap equals nv.MaNV
                        join ltk in db.LoaiTaiKhoan on tk.MaLoai equals ltk.MaLoai
                        select new
                        {
                            tk.TenDangNhap,
                            tk.MatKhau,
                            tk.MaLoai,
                            nv.Ho,
                            nv.Ten,
                            TenLoai = ltk.Ten
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("TenDangNhap", typeof(string));
            dt.Columns.Add("MatKhau", typeof(string));
            dt.Columns.Add("MaLoai", typeof(string));
            dt.Columns.Add("Ho", typeof(string));
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("TenLoai", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.TenDangNhap, item.MatKhau, item.MaLoai, item.Ho, item.Ten, item.TenLoai);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public bool ThemTaiKhoan(string username, string password, string MaLoai, ref string err)
        {
            try
            {
                // Kiểm tra tồn tại
                if (db.TaiKhoan.Any(t => t.TenDangNhap == username))
                {
                    err = "Tên đăng nhập đã tồn tại!";
                    return false;
                }

                var tk = new TaiKhoan()
                {
                    TenDangNhap = username,
                    MatKhau = password,
                    MaLoai = MaLoai
                };

                db.TaiKhoan.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.ToString();
                return false;
            }
        }


        public bool CapNhatMatKhau(string username, string password, ref string err)
        {
            try
            {
                var tk = db.TaiKhoan.SingleOrDefault(x => x.TenDangNhap == username);
                if (tk == null)
                {
                    err = "Không tìm thấy tài khoản.";
                    return false;
                }
                tk.MatKhau = password;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatTaiKhoan(string username, string password, string MaLoai, ref string err)
        {
            try
            {
                var tk = db.TaiKhoan.SingleOrDefault(x => x.TenDangNhap == username);
                if (tk == null)
                {
                    err = "Không tìm thấy tài khoản.";
                    return false;
                }
                tk.MatKhau = password;
                tk.MaLoai = MaLoai;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool XoaTaiKhoan(ref string err, string username)
        {
            try
            {
                var tk = db.TaiKhoan.SingleOrDefault(x => x.TenDangNhap == username);
                if (tk == null)
                {
                    err = "Không tìm thấy tài khoản.";
                    return false;
                }
                db.TaiKhoan.Remove(tk);
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
