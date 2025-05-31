using Guna.UI2.WinForms;
using QuanLyNhanSu_3Tang_EF.BS_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmQuanLyBaoHiem : Form
    {
        List<dynamic> dsBaoHiem = null;  
        List<BaoHiem> dsLoaiBaoHiem = null;
        bool Them;
        string err;
        BLBaoHiem dbBH = new BLBaoHiem();
        string MaNV;

        public frmQuanLyBaoHiem(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;

            // Thêm cột vào dgvBaoHiem  
            dgvBaoHiem.Columns.Clear();

            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaNV",
                HeaderText = "Mã nhân viên",
                DataPropertyName = "MaNV"
            });
            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaBH",
                HeaderText = "Mã bảo hiểm",
                DataPropertyName = "MaBH"
            });
            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenNV",
                HeaderText = "Tên nhân viên",
                DataPropertyName = "TenNV"
            });
            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenBH",
                HeaderText = "Loại bảo hiểm",
                DataPropertyName = "TenBH"
            });
            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayBD",
                HeaderText = "Ngày bắt đầu",
                DataPropertyName = "NgayBD"
            });
            dgvBaoHiem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayKT",
                HeaderText = "Ngày kết thúc",
                DataPropertyName = "NgayKT"
            });
        }

        private void LoadData()
        {
            try
            {
                dsBaoHiem = dbBH.LayBaoHiem();

                dgvBaoHiem.AutoGenerateColumns = false;
                dgvBaoHiem.DataSource = null;
                dgvBaoHiem.DataSource = dsBaoHiem;
                dgvBaoHiem.AutoResizeColumns();

                txtMaBH.ResetText();
                txtMaNV.ResetText();
                cbbLoaiBH.SelectedIndex = -1;

                dtpNgayBD.Value = DateTime.Today;
                dtpNgayKT.Value = DateTime.Today;
                txtTimKiemMaBH.ResetText();

                txtMaBH.Enabled = false;
                txtMaNV.Enabled = false;
                cbbLoaiBH.Enabled = false;
                dtpNgayKT.Enabled = false;
                dtpNgayBD.Enabled = false;

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                guna2Panel1.Enabled = true;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
                txtTimKiemMaBH.Enabled = true;
                btnTimKiem.Enabled = true;

                if (dsBaoHiem.Count > 0)
                    dgvBaoHiem_CellContentClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu bảo hiểm.\n" + ex.Message);
            }
        }

        private void LoadLoaiBaoHiem()
        {
            try
            {
                dsLoaiBaoHiem = dbBH.LayLoaiBaoHiem();
                cbbLoaiBH.DataSource = dsLoaiBaoHiem;
                cbbLoaiBH.DisplayMember = "TenBH";
                cbbLoaiBH.ValueMember = "MaLoai";
                cbbLoaiBH.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được loại bảo hiểm.\n" + ex.Message);
            }
        }

        private void frmQuanLyBaoHiem_Load(object sender, EventArgs e)
        {
            LoadLoaiBaoHiem();
            LoadData();
        }

        private void dgvBaoHiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBaoHiem.CurrentRow == null)
                return;

            var row = dgvBaoHiem.CurrentRow;
             
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtMaBH.Text = row.Cells["MaBH"].Value?.ToString() ?? "";
            cbbLoaiBH.Text = row.Cells["TenBH"].Value?.ToString() ?? "";

            if (row.Cells["NgayBD"].Value != null && DateTime.TryParse(row.Cells["NgayBD"].Value.ToString(), out var ngaybd))
                dtpNgayBD.Value = ngaybd;
            else
                dtpNgayBD.Value = DateTime.Today;

            if (row.Cells["NgayKT"].Value != null && DateTime.TryParse(row.Cells["NgayKT"].Value.ToString(), out var ngaykt))
                dtpNgayKT.Value = ngaykt;
            else
                dtpNgayKT.Value = DateTime.Today;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaNV.ResetText();
            txtMaBH.ResetText();
            dtpNgayBD.Value = DateTime.Today;
            dtpNgayKT.Value = DateTime.Today;
            txtTimKiemMaBH.ResetText();

            guna2GroupBox3.Enabled = true;
            txtMaNV.Enabled = true;
            txtMaBH.Enabled = true;
            cbbLoaiBH.Enabled = true;
            dtpNgayBD.Enabled = true;
            dtpNgayKT.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            guna2Panel1.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            txtTimKiemMaBH.Enabled = false;
            btnThoat.Enabled = false;

            txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            guna2GroupBox3.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            guna2Panel1.Enabled = true;

            dgvBaoHiem_CellContentClick(null, null);

            txtMaNV.Enabled = true;
            cbbLoaiBH.Enabled = true;
            dtpNgayBD.Enabled = true;
            dtpNgayKT.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            txtTimKiemMaBH.Enabled = false;

            txtMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBaoHiem.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                    return;
                }

                string maBH = dgvBaoHiem.CurrentRow.Cells["MaBH"].Value.ToString();

                DialogResult traloi = MessageBox.Show("Chắc xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    bool success = dbBH.XoaBaoHiem(maBH, out err);
                    if (success)
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được. Lỗi: " + err);
                    }
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được.\n" + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (string.IsNullOrWhiteSpace(txtMaBH.Text) || string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    txtMaBH.Focus();
                    return;
                }

                bool success = dbBH.ThemBaoHiem(txtMaNV.Text, txtMaBH.Text, cbbLoaiBH.SelectedValue?.ToString() ?? "", dtpNgayBD.Value, dtpNgayKT.Value, out err);
                if (success)
                {
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Không thêm được. Lỗi: " + err);
                }
            }
            else
            {
                bool success = dbBH.CapNhatBaoHiem(txtMaNV.Text, txtMaBH.Text, cbbLoaiBH.SelectedValue?.ToString() ?? "", dtpNgayBD.Value, dtpNgayKT.Value, out err);
                if (success)
                {
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                else
                {
                    MessageBox.Show("Không sửa được. Lỗi: " + err);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtMaBH.ResetText();
            dtpNgayBD.Value = DateTime.Today;
            dtpNgayKT.Value = DateTime.Today;
            txtTimKiemMaBH.ResetText();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            if (dsBaoHiem != null && dsBaoHiem.Count > 0)
                dgvBaoHiem_CellContentClick(null, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtMaBH.Clear();
            txtTimKiemMaBH.Clear();
            cbbLoaiBH.SelectedIndex = -1;
            dtpNgayBD.Value = DateTime.Today;
            dtpNgayKT.Value = DateTime.Today;

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maBH = txtTimKiemMaBH.Text.Trim();
            var ketqua = dsBaoHiem.Where(b => b.MaBH == maBH).ToList();
            if (ketqua.Count > 0)
            {
                dgvBaoHiem.DataSource = ketqua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã bảo hiểm này!");
                dgvBaoHiem.DataSource = dsBaoHiem;
            }
        }

        private void frmQuanLyBaoHiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuQuanTriVien frm = new frmMenuQuanTriVien(MaNV);
            frm.Show();
        }


    }
}
