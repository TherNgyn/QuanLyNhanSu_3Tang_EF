using QuanLyNhanSu_3Tang_EF.BS_Layer;
using QuanLyNhanSu_3Tang_EF;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;


namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmDangKyNghiPhep : Form
    {
        private readonly string maNhanVien;
        private readonly BLNghiPhep dbNP = new BLNghiPhep();
        private readonly BLTaiKhoan bLTaiKhoan = new BLTaiKhoan();
        private string err;
        private readonly string userRole;

        public frmDangKyNghiPhep(string maNV)
        {
            InitializeComponent();
            maNhanVien = maNV;
            userRole = bLTaiKhoan.LayRoleName(maNV);
        }

        private void frmDangKyNghiPhep_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = maNhanVien;
            txtMaNV.Enabled = false;

            LoadComboBoxThang();
            LoadLichSuNghiPhep();
        }

        private void LoadComboBoxThang()
        {
            try
            {
                var dsThang = dbNP.LayLoaiThang();
                cbbMaThang.DataSource = dsThang;
                cbbMaThang.DisplayMember = "MoTa";
                cbbMaThang.ValueMember = "MaThang";
                cbbMaThang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được danh sách tháng.\n" + ex.Message);
            }
        }

        private void LoadLichSuNghiPhep()
        {
            try
            {
                var dsNghiPhep = dbNP.LayNghiPhep();
                // Lọc theo nhân viên hiện tại
                var filtered = dsNghiPhep.Where(np => np.MaNV == maNhanVien).Select(np => new
                {
                    np.NgayNghiPhep,
                    np.TenThang,
                    np.GhiChu
                }).ToList();

                dgvNghiPhep.DataSource = filtered;
                dgvNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNghiPhep.Columns[0].HeaderText = "Ngày nghỉ phép";
                dgvNghiPhep.Columns[1].HeaderText = "Tháng";
                dgvNghiPhep.Columns[2].HeaderText = "Ghi chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được lịch sử nghỉ phép.\n" + ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNgayNghi.Text) || string.IsNullOrWhiteSpace(txtLyDo.Text) || cbbMaThang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNgayNghi.Text, out int ngayNghi) || ngayNghi <= 0)
            {
                MessageBox.Show("Ngày nghỉ phải là số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = dbNP.ThemNghiPhep(maNhanVien, cbbMaThang.SelectedValue.ToString(), ngayNghi, txtLyDo.Text, out err);
            if (result)
            {
                MessageBox.Show("Đăng ký nghỉ phép thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLichSuNghiPhep();
                txtNgayNghi.Clear();
                txtLyDo.Clear();
                cbbMaThang.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lỗi: " + err);
            }
        }

        private void frmDangKyNghiPhep_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userRole.Equals("TruongPhong", StringComparison.OrdinalIgnoreCase))
            {
                frmMenuTruongPhong frm = new frmMenuTruongPhong(maNhanVien);
                frm.Show();
            }
            else if (userRole.Equals("NhanVien", StringComparison.OrdinalIgnoreCase))
            {
                frmMenuNhanVien frm = new frmMenuNhanVien(maNhanVien);
                frm.Show();
            }
        }
    }
}
