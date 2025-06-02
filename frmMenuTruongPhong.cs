﻿using System;
using QuanLyNhanSu_3Tang_EF.BS_Layer;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmMenuTruongPhong : Form
    {
        String userName;
        BLNhanVien bLNhanVien;
        DataSet ds;
        string err;
        bool isLoggingOut = false;
        public frmMenuTruongPhong(string userName)
        {
            InitializeComponent();
            this.userName = userName;

        }

        private void frmMenuTruongPhong_Load(object sender, EventArgs e)
        {
            bLNhanVien = new BLNhanVien();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            LoadData();
        }
        void LoadData()
        {
            txtMaNhanVien.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            cmbGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            txtEmail.Enabled = false;
            txtCCCD.Enabled = false;

            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            ds = bLNhanVien.LayNhanVienTheoMa(userName);
            DataTable dt = ds.Tables[0];
            DataRow dataRow = dt.Rows[0];
            txtMaNhanVien.Text = dataRow["MaNV"].ToString();
            txtHo.Text = dataRow["Ho"].ToString();
            txtTen.Text = dataRow["Ten"].ToString();
            cmbGioiTinh.SelectedItem = dataRow["GioiTinh"].ToString();
            DateTime ngaySinhValue = Convert.ToDateTime(dataRow["NgaySinh"]);
            dtpNgaySinh.Value = ngaySinhValue;
            txtDiaChi.Text = dataRow["DiaChi"].ToString();
            txtSoDT.Text = dataRow["SDT"].ToString();
            txtEmail.Text = dataRow["Email"].ToString();
            txtCCCD.Text = dataRow["CCCD"].ToString();

            lblTenTP.Text = dataRow["Ten"].ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtHo.Enabled = true;
            txtTen.Enabled = true;
            cmbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtEmail.Enabled = true;
            txtCCCD.Enabled = true;

            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            this.txtHo.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            err = "";
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            bLNhanVien.CapNhatNhanVienCV(txtMaNhanVien.Text, txtHo.Text, txtTen.Text, cmbGioiTinh.SelectedItem.ToString(), ngaySinh,
                txtDiaChi.Text, txtSoDT.Text, txtEmail.Text, txtCCCD.Text, ref err);
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?  
            if (traloi == DialogResult.OK)
            {
                isLoggingOut = true;
                this.Close();
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNV frmQuanLyNV = new frmQuanLyNV(userName);
            frmQuanLyNV.Show();
            this.Close();
        }

        private void btnQuanLyPhongBan_Click(object sender, EventArgs e)
        {
            frmQuanLyPhongBan frmQuanLyPhongBan = new frmQuanLyPhongBan(userName);
            frmQuanLyPhongBan.Show();
            this.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            //frmChamCong frmCC = new frmChamCong(userName);
            //frmCC.Show();
            //this.Close();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            //frmLuongNhanVien frmLuong = new frmLuongNhanVien(userName);
            //frmLuong.Show();
            //this.Close();
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            //frmDangKyNghiPhep frmDKNP = new frmDangKyNghiPhep(userName);
            //frmDKNP.Show();
            //this.Close();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenuTruongPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
        }
        private void btnXemThongBaoMenu_Click(object sender, EventArgs e)
        {
            //frmXemThongBao frmQLTB = new frmXemThongBao(userName, true);
            //frmQLTB.Show();
            //this.Close();
        }
      
        private void btnThoatThongTin_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?  
            if (traloi == DialogResult.OK)
            {
                isLoggingOut = true;
                this.Close();
            }
        }

        private void frmMenuTruongPhong_Load_1(object sender, EventArgs e)
        {

        }
    }

}
