using System.Drawing;
using System.Windows.Forms;
using System;

namespace QuanLyNhanSu_3Tang_EF
{
    partial class frmMenuQuanTriVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUserInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNghỉPhépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHopDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThưởngPhạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCôngVàThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKeLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.panelMain.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderRadius = 15;
            this.panelMain.Controls.Add(this.panelThongTin);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1300, 576);
            this.panelMain.TabIndex = 0;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BorderRadius = 15;
            this.panelThongTin.Controls.Add(this.txtMaNhanVien);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel9);
            this.panelThongTin.Controls.Add(this.lblUserInfo);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel1);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel2);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel3);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel4);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel5);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel6);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel7);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel8);
            this.panelThongTin.Controls.Add(this.txtHo);
            this.panelThongTin.Controls.Add(this.txtTen);
            this.panelThongTin.Controls.Add(this.txtDiaChi);
            this.panelThongTin.Controls.Add(this.txtSoDT);
            this.panelThongTin.Controls.Add(this.txtEmail);
            this.panelThongTin.Controls.Add(this.txtCCCD);
            this.panelThongTin.Controls.Add(this.cmbGioiTinh);
            this.panelThongTin.Controls.Add(this.dtpNgaySinh);
            this.panelThongTin.Controls.Add(this.panelButtons);
            this.panelThongTin.FillColor = System.Drawing.Color.White;
            this.panelThongTin.Location = new System.Drawing.Point(20, 80);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.panelThongTin.Size = new System.Drawing.Size(1260, 486);
            this.panelThongTin.TabIndex = 1;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(320, 24);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(285, 50);
            this.guna2HtmlLabel9.TabIndex = 25;
            this.guna2HtmlLabel9.Text = "Mã Quản Trị Viên";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = false;
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblUserInfo.Location = new System.Drawing.Point(23, 18);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(291, 56);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Xin chào, Quản trị viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderRadius = 10;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(485, 20);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PlaceholderText = "";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(248, 29);
            this.txtMaNhanVien.TabIndex = 26;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(94, 88);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(134, 44);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Họ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(94, 136);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(134, 44);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Tên";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(94, 184);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(134, 44);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Giới tính";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(94, 232);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(134, 57);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Ngày Sinh";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(619, 88);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(137, 44);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Địa Chỉ";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(619, 136);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(137, 44);
            this.guna2HtmlLabel6.TabIndex = 8;
            this.guna2HtmlLabel6.Text = "Số ĐT";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(619, 184);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(137, 44);
            this.guna2HtmlLabel7.TabIndex = 9;
            this.guna2HtmlLabel7.Text = "Email";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(619, 232);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(137, 57);
            this.guna2HtmlLabel8.TabIndex = 10;
            this.guna2HtmlLabel8.Text = "CCCD";
            // 
            // txtHo
            // 
            this.txtHo.BorderRadius = 10;
            this.txtHo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHo.DefaultText = "";
            this.txtHo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHo.Location = new System.Drawing.Point(234, 80);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHo.Name = "txtHo";
            this.txtHo.PlaceholderText = "";
            this.txtHo.SelectedText = "";
            this.txtHo.Size = new System.Drawing.Size(248, 29);
            this.txtHo.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.BorderRadius = 10;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(234, 128);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(248, 29);
            this.txtTen.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(762, 80);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(248, 29);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BorderRadius = 10;
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.DefaultText = "";
            this.txtSoDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Location = new System.Drawing.Point(762, 128);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.Size = new System.Drawing.Size(248, 29);
            this.txtSoDT.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(762, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(248, 29);
            this.txtEmail.TabIndex = 17;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BorderRadius = 10;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(762, 224);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(248, 29);
            this.txtCCCD.TabIndex = 18;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderRadius = 10;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGioiTinh.ItemHeight = 30;
            this.cmbGioiTinh.Location = new System.Drawing.Point(234, 176);
            this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(248, 36);
            this.cmbGioiTinh.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 10;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(234, 224);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(248, 29);
            this.dtpNgaySinh.TabIndex = 20;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 5, 28, 20, 28, 25, 182);
            // 
            // panelButtons
            // 
            this.panelButtons.BorderRadius = 10;
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Controls.Add(this.btnThoat);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FillColor = System.Drawing.Color.Transparent;
            this.panelButtons.Location = new System.Drawing.Point(20, 374);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1220, 96);
            this.panelButtons.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(74, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(225, 45);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(340, 32);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(225, 45);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(613, 32);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(225, 45);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 10;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(878, 32);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(225, 45);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.AutoScroll = true;
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelMenu);
            this.panelHeader.Controls.Add(this.btnThongKeLuong);
            this.panelHeader.Controls.Add(this.btnThongBao);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.Navy;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelHeader.Size = new System.Drawing.Size(1300, 64);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN SỰ - QUẢN TRỊ VIÊN";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelMenu.BorderRadius = 30;
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.FillColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(598, 18);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(310, 36);
            this.panelMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(110, 36);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýNghỉPhépToolStripMenuItem,
            this.quảnLýHopDongToolStripMenuItem,
            this.quảnLýToolStripMenuItem1,
            this.quảnLýThưởngPhạtToolStripMenuItem,
            this.quảnLýBảoHiểmToolStripMenuItem,
            this.quảnLýCôngVàThángToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản Lý Phòng Ban";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            // 
            // quảnLýNghỉPhépToolStripMenuItem
            // 
            this.quảnLýNghỉPhépToolStripMenuItem.Name = "quảnLýNghỉPhépToolStripMenuItem";
            this.quảnLýNghỉPhépToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýNghỉPhépToolStripMenuItem.Text = "Quản Lý Nghỉ Phép";
            // 
            // quảnLýHopDongToolStripMenuItem
            // 
            this.quảnLýHopDongToolStripMenuItem.Name = "quảnLýHopDongToolStripMenuItem";
            this.quảnLýHopDongToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýHopDongToolStripMenuItem.Text = "Quản Lý Hợp Đồng";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(321, 32);
            this.quảnLýToolStripMenuItem1.Text = "Quản Lý Chức Vụ";
            // 
            // quảnLýThưởngPhạtToolStripMenuItem
            // 
            this.quảnLýThưởngPhạtToolStripMenuItem.Name = "quảnLýThưởngPhạtToolStripMenuItem";
            this.quảnLýThưởngPhạtToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýThưởngPhạtToolStripMenuItem.Text = "Quản Lý Thưởng Phạt";
            // 
            // quảnLýBảoHiểmToolStripMenuItem
            // 
            this.quảnLýBảoHiểmToolStripMenuItem.Name = "quảnLýBảoHiểmToolStripMenuItem";
            this.quảnLýBảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýBảoHiểmToolStripMenuItem.Text = "Quản Lý Bảo Hiểm";
            // 
            // quảnLýCôngVàThángToolStripMenuItem
            // 
            this.quảnLýCôngVàThángToolStripMenuItem.Name = "quảnLýCôngVàThángToolStripMenuItem";
            this.quảnLýCôngVàThángToolStripMenuItem.Size = new System.Drawing.Size(321, 32);
            this.quảnLýCôngVàThángToolStripMenuItem.Text = "Quản Lý Công và Tháng";
            // 
            // btnThongKeLuong
            // 
            this.btnThongKeLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKeLuong.BorderRadius = 10;
            this.btnThongKeLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnThongKeLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKeLuong.ForeColor = System.Drawing.Color.White;
            this.btnThongKeLuong.Location = new System.Drawing.Point(1100, 9);
            this.btnThongKeLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKeLuong.Name = "btnThongKeLuong";
            this.btnThongKeLuong.Size = new System.Drawing.Size(180, 45);
            this.btnThongKeLuong.TabIndex = 27;
            this.btnThongKeLuong.Text = "Thống Kê Lương";
            this.btnThongKeLuong.Click += new System.EventHandler(this.btnThongKeLuong_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.Transparent;
            this.btnThongBao.BorderRadius = 10;
            this.btnThongBao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongBao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongBao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongBao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongBao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(914, 9);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(180, 45);
            this.btnThongBao.TabIndex = 31;
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(110, 36);
            this.miniToolStrip.TabIndex = 29;
            // 
            // frmMenuQuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 576);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.miniToolStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenuQuanTriVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Quản Trị Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuQuanTriVien_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuQuanTriVien_Load);
            this.panelMain.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin;
        private Guna.UI2.WinForms.Guna2Panel panelButtons;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserInfo;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;

        private Guna.UI2.WinForms.Guna2TextBox txtHo;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDT;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;

        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;

        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private MenuStrip miniToolStrip;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnThongKeLuong;
        private Guna.UI2.WinForms.Guna2Button btnThongBao;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýNghỉPhépToolStripMenuItem;
        private ToolStripMenuItem quảnLýHopDongToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem1;
        private ToolStripMenuItem quảnLýThưởngPhạtToolStripMenuItem;
        private ToolStripMenuItem quảnLýBảoHiểmToolStripMenuItem;
        private ToolStripMenuItem quảnLýCôngVàThángToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
    }
}