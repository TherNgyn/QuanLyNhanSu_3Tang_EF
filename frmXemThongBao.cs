using QuanLyNhanSu_3Tang_EF.BS_Layer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmXemThongBao : Form
    {
        string userName;
        bool isTruongPhong;
        BLThongBao dbThongBao = new BLThongBao();
        BLTaiKhoan bLTaiKhoan = new BLTaiKhoan();
        private string userRole;

        public frmXemThongBao(string userName, bool isTruongPhong)
        {
            InitializeComponent();
            this.userName = userName;
            this.isTruongPhong = isTruongPhong;
            this.userRole = bLTaiKhoan.LayRoleName(userName);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadThongBao();
        }

        private void btnXemTB_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow != null)
            {
                string tieuDe = "", noiDung = "", ngayGui = "";

                if (isTruongPhong)
                {
                    tieuDe = dgvThongBao.CurrentRow.Cells["TieuDe"].Value?.ToString();
                    noiDung = dgvThongBao.CurrentRow.Cells["NoiDung"].Value?.ToString();
                    ngayGui = dgvThongBao.CurrentRow.Cells["NgayGui"].Value?.ToString();
                }
                else
                {
                    tieuDe = dgvThongBao.CurrentRow.Cells["Tiêu_đề_thông_báo"].Value?.ToString();
                    noiDung = dgvThongBao.CurrentRow.Cells["Nội_dung_thông_báo"].Value?.ToString();
                    ngayGui = dgvThongBao.CurrentRow.Cells["Ngày_nhận"].Value?.ToString();
                }

                string message = $"Tiêu đề: {tieuDe}\n\nNội dung:\n{noiDung}\n\nNgày gửi: {ngayGui}";
                MessageBox.Show(message, "Chi tiết thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thông báo để xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadThongBao()
        {
            if (isTruongPhong)
            {
                // Lấy tất cả thông báo (có phòng ban)
                var data = dbThongBao.LayThongBao();

                dgvThongBao.DataSource = data;
                dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đổi tên cột hiển thị
                if (dgvThongBao.Columns.Contains("TieuDe"))
                    dgvThongBao.Columns["TieuDe"].HeaderText = "Tiêu đề thông báo";
                if (dgvThongBao.Columns.Contains("NoiDung"))
                    dgvThongBao.Columns["NoiDung"].HeaderText = "Nội dung thông báo";
                if (dgvThongBao.Columns.Contains("NgayGui"))
                    dgvThongBao.Columns["NgayGui"].HeaderText = "Ngày nhận";
                if (dgvThongBao.Columns.Contains("MaPB"))
                    dgvThongBao.Columns["MaPB"].HeaderText = "Mã phòng ban";
                if (dgvThongBao.Columns.Contains("TenPB"))
                    dgvThongBao.Columns["TenPB"].HeaderText = "Tên phòng ban";
            }
            else
            {
                // Lấy thông báo theo phòng ban của nhân viên (định dạng ngày đã được xử lý trong BL)
                var data = dbThongBao.LayThongBaoChoNV(userName);

                dgvThongBao.DataSource = data;
                dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đổi tên cột hiển thị
                if (dgvThongBao.Columns.Contains("Tiêu_đề_thông_báo"))
                    dgvThongBao.Columns["Tiêu_đề_thông_báo"].HeaderText = "Tiêu đề thông báo";
                if (dgvThongBao.Columns.Contains("Nội_dung_thông_báo"))
                    dgvThongBao.Columns["Nội_dung_thông_báo"].HeaderText = "Nội dung thông báo";
                if (dgvThongBao.Columns.Contains("Ngày_nhận"))
                    dgvThongBao.Columns["Ngày_nhận"].HeaderText = "Ngày nhận";
            }
        }

        private void frmXemThongBao_Load(object sender, EventArgs e)
        {
            LoadThongBao();
        }

        private void frmXemThongBao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userRole.Equals("TruongPhong", StringComparison.OrdinalIgnoreCase))
            {
                frmMenuTruongPhong frm = new frmMenuTruongPhong(userName);
                frm.Show();
            }
            else if (userRole.Equals("NhanVien", StringComparison.OrdinalIgnoreCase))
            {
                frmMenuNhanVien frm = new frmMenuNhanVien(userName);
                frm.Show();
            }
        }


    }
}
