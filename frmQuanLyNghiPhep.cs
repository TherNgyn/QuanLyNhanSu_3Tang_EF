using Guna.UI2.WinForms;
using QuanLyNhanSu_3Tang_EF.BS_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmQuanLyNghiPhep : Form
    {
        List<NghiPhepDTO> dsNghiPhep = null;
        List<Thang> dsThang = null;
        bool Them;
        string err;
        BLNghiPhep dbNP = new BLNghiPhep();
        string MaNV;

        public frmQuanLyNghiPhep(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
        }

        private void LoadData()
        {
            try
            {
                dsNghiPhep = dbNP.LayNghiPhep();

                dgvNghiPhep.AutoGenerateColumns = false;
                dgvNghiPhep.Columns.Clear();

                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Mã nhân viên",
                    DataPropertyName = "MaNV",
                    Name = "MaNV"
                });
                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Mã tháng",
                    DataPropertyName = "MaThang",
                    Name = "MaThang"
                });
                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên tháng",
                    DataPropertyName = "TenThang",
                    Name = "TenThang"
                });
                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ngày nghỉ phép",
                    DataPropertyName = "NgayNghiPhep",
                    Name = "NgayNghiPhep"
                });
                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ghi chú",
                    DataPropertyName = "GhiChu",
                    Name = "GhiChu"
                });
                dgvNghiPhep.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên nhân viên",
                    DataPropertyName = "TenNV",
                    Name = "TenNV"
                });

                dgvNghiPhep.DataSource = dsNghiPhep;
                dgvNghiPhep.AutoResizeColumns();

                txtMaNV.ResetText();
                txtNgayNghi.ResetText();
                txtLyDo.ResetText();
                cbbMaThang.SelectedIndex = -1;
                txtTimKiemMaNV.ResetText();

                txtMaNV.Enabled = false;
                txtNgayNghi.Enabled = false;
                txtLyDo.Enabled = false;
                cbbMaThang.Enabled = false;

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;

                if (dsNghiPhep.Count > 0)
                    dgvNghiPhep_CellContentClick(null, null);

                LoadComboBoxThang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu nghỉ phép.\n" + ex.Message);
            }
        }

        private void LoadComboBoxThang()
        {
            try
            {
                dsThang = dbNP.LayLoaiThang();
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

        private void dgvNghiPhep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNghiPhep.CurrentRow == null) return;

            var row = dgvNghiPhep.CurrentRow;
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtNgayNghi.Text = row.Cells["NgayNghiPhep"].Value?.ToString() ?? "";
            txtLyDo.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            var maThang = row.Cells["MaThang"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(maThang))
                cbbMaThang.SelectedValue = maThang;
            else
                cbbMaThang.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaNV.Clear();
            txtNgayNghi.Clear();
            txtLyDo.Clear();
            cbbMaThang.SelectedIndex = -1;

            txtMaNV.Enabled = true;
            txtNgayNghi.Enabled = true;
            txtLyDo.Enabled = true;
            cbbMaThang.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            txtMaNV.Enabled = false;
            cbbMaThang.Enabled = false;

            txtNgayNghi.Enabled = true;
            txtLyDo.Enabled = true;
            cbbMaThang.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNghiPhep.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            string maNV = dgvNghiPhep.CurrentRow.Cells["MaNV"].Value?.ToString() ?? "";
            string maThang = dgvNghiPhep.CurrentRow.Cells["MaThang"].Value?.ToString() ?? "";

            DialogResult traloi = MessageBox.Show("Chắc chắn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                bool success = dbNP.XoaNghiPhep(maNV, maThang, out err);
                if (success)
                {
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                cbbMaThang.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNgayNghi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtNgayNghi.Text, out int ngayNghi))
            {
                MessageBox.Show("Ngày nghỉ phải là số nguyên!");
                return;
            }

            string maThang = cbbMaThang.SelectedValue.ToString();

            bool success = Them ?
                dbNP.ThemNghiPhep(txtMaNV.Text, maThang, ngayNghi, txtLyDo.Text, out err) :
                dbNP.CapNhatNghiPhep(txtMaNV.Text, maThang, ngayNghi, txtLyDo.Text, out err);

            if (success)
            {
                LoadData();
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi: " + err);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtNgayNghi.ResetText();
            txtLyDo.ResetText();
            txtTimKiemMaNV.ResetText();

            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtNgayNghi.Clear();
            txtLyDo.Clear();
            txtTimKiemMaNV.Clear();
            cbbMaThang.SelectedIndex = -1;

            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtTimKiemMaNV.Text.Trim();
            var ketqua = dsNghiPhep.Where(np => np.MaNV == maNV).ToList();

            if (ketqua.Count > 0)
            {
                dgvNghiPhep.DataSource = ketqua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã nhân viên này!");
                dgvNghiPhep.DataSource = dsNghiPhep;
            }
        }

        private void frmQuanLyNghiPhep_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmQuanLyNghiPhep_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuQuanTriVien frm = new frmMenuQuanTriVien(MaNV);
            frm.Show();
        }

    }
}
