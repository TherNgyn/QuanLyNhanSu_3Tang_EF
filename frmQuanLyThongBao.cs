using QuanLyNhanSu_3Tang_EF.BS_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmQuanLyThongBao : Form
    {
        List<dynamic> dsThongBao = null;
        List<PhongBan> dsPhongBan = null;
        BLThongBao dbTB = new BLThongBao();
        bool Them;
        string err;
        string MaNV;

        public frmQuanLyThongBao(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
        }

        void LoadData()
        {
            dsThongBao = dbTB.LayThongBao();
            dgvThongBao.DataSource = dsThongBao;

            if (dgvThongBao.Columns.Contains("MaPB"))
                dgvThongBao.Columns["MaPB"].Visible = false;

            if (dgvThongBao.Columns.Contains("Id"))
                dgvThongBao.Columns["Id"].Visible = true;
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load combo box phòng ban
            dsPhongBan = dbTB.LayDanhSachPhongBan();
            cbbPhongBan.DataSource = dsPhongBan;
            cbbPhongBan.DisplayMember = "TenPB";
            cbbPhongBan.ValueMember = "MaPB";
            cbbPhongBan.SelectedIndex = -1;

            // Reset
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            dtpNgayGui.Value = DateTime.Now;

            txtNoiDung.Enabled = false;
            txtTieuDe.Enabled = false;
            dtpNgayGui.Enabled = false;
            cbbPhongBan.Enabled = false;

            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = true;
            btnLamMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnXem.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            if (dsThongBao != null && dsThongBao.Count > 0)
                dgvThongBao_CellContentClick(null, null);
        }

        private void frmQuanLyThongBao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            cbbPhongBan.SelectedIndex = -1;
            dtpNgayGui.Value = DateTime.Now;

            txtNoiDung.Enabled = true;
            txtTieuDe.Enabled = true;
            dtpNgayGui.Enabled = true;
            cbbPhongBan.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnThoat.Enabled = false;
            btnXem.Enabled = false;

            txtTieuDe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtNoiDung.Enabled = true;
            txtTieuDe.Enabled = true;
            dtpNgayGui.Enabled = true;
            cbbPhongBan.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnThoat.Enabled = false;
            btnXem.Enabled = false;

            txtTieuDe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow != null && int.TryParse(dgvThongBao.CurrentRow.Cells["Id"].Value?.ToString(), out int id))
            {
                DialogResult result = MessageBox.Show("Chắc xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dbTB.XoaThongBao(id, out err))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được. Lỗi: " + err);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                bool result = dbTB.ThemThongBao(
                    txtTieuDe.Text,
                    txtNoiDung.Text,
                    cbbPhongBan.SelectedValue?.ToString() ?? "",
                    dtpNgayGui.Value,
                    out err);
                if (result)
                {
                    LoadData();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Không thêm được. Lỗi: " + err);
                }
            }
            else
            {
                if (dgvThongBao.CurrentRow != null && int.TryParse(dgvThongBao.CurrentRow.Cells["Id"].Value?.ToString(), out int id))
                {
                    bool result = dbTB.CapNhatThongBao(
                        id,
                        txtTieuDe.Text,
                        txtNoiDung.Text,
                        cbbPhongBan.SelectedValue?.ToString() ?? "",
                        dtpNgayGui.Value,
                        out err);
                    if (result)
                    {
                        LoadData();
                        MessageBox.Show("Đã cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được. Lỗi: " + err);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTieuDe.ResetText();
            txtNoiDung.ResetText();
            cbbPhongBan.SelectedIndex = -1;
            dtpNgayGui.Value = DateTime.Now;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnXem.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTieuDe.Enabled = false;
            txtNoiDung.Enabled = false;
            cbbPhongBan.Enabled = false;
            dtpNgayGui.Enabled = false;

            if (dsThongBao != null && dsThongBao.Count > 0)
                dgvThongBao_CellContentClick(null, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTieuDe.ResetText();
            txtNoiDung.ResetText();
            cbbPhongBan.SelectedIndex = -1;
            dtpNgayGui.Value = DateTime.Now;

            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Chắc chắn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvThongBao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e == null || e.RowIndex < 0 || dsThongBao == null) return;

            var row = dsThongBao[e.RowIndex];
            txtTieuDe.Text = row.TieuDe?.ToString() ?? "";
            txtNoiDung.Text = row.NoiDung?.ToString() ?? "";
            cbbPhongBan.SelectedValue = row.MaPB?.ToString() ?? "";
            dtpNgayGui.Value = Convert.ToDateTime(row.NgayGui);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow != null)
            {
                var row = dsThongBao[dgvThongBao.CurrentRow.Index];
                string tieuDe = row.TieuDe?.ToString();
                string noiDung = row.NoiDung?.ToString();
                string ngayGui = row.NgayGui?.ToString();

                string message = $"Tiêu đề: {tieuDe}\n\nNội dung:\n{noiDung}\n\nNgày gửi: {ngayGui}";
                MessageBox.Show(message, "Chi tiết thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thông báo để xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         

        private void frmQuanLyThongBao_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuQuanTriVien frm = new frmMenuQuanTriVien(MaNV);
            frm.Show();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow != null)
            {
                var row = dsThongBao[dgvThongBao.CurrentRow.Index];
                string tieuDe = row.TieuDe?.ToString();
                string noiDung = row.NoiDung?.ToString();
                string ngayGui = row.NgayGui?.ToString();

                string message = $"Tiêu đề: {tieuDe}\n\nNội dung:\n{noiDung}\n\nNgày gửi: {ngayGui}";
                MessageBox.Show(message, "Chi tiết thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thông báo để xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}