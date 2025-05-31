using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu_3Tang_EF
{
    partial class frmMenuNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemThongBao = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMatKhauNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnXemLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKyNghiPhep = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.guna2PanelLoad = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2PanelLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnXemThongBao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnXemThongBao
            // 
            this.btnXemThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemThongBao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThongBao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThongBao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemThongBao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemThongBao.FillColor = System.Drawing.Color.White;
            this.btnXemThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemThongBao.ForeColor = System.Drawing.Color.White;
            this.btnXemThongBao.Image = global::QuanLyNhanSu_3Tang_EF.Properties.Resources.icons8_notification_962;
            this.btnXemThongBao.Location = new System.Drawing.Point(1228, 24);
            this.btnXemThongBao.Name = "btnXemThongBao";
            this.btnXemThongBao.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXemThongBao.Size = new System.Drawing.Size(40, 40);
            this.btnXemThongBao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm 16";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhanSu_3Tang_EF.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 640);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnThoat);
            this.panel5.Controls.Add(this.btnDoiMatKhauNhanVien);
            this.panel5.Controls.Add(this.btnXemLuong);
            this.panel5.Controls.Add(this.btnDangKyNghiPhep);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 434);
            this.panel5.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.FillColor = System.Drawing.Color.Navy;
            this.btnThoat.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.Location = new System.Drawing.Point(0, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnThoat.Size = new System.Drawing.Size(242, 56);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.TextOffset = new System.Drawing.Point(50, 0);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhauNhanVien
            // 
            this.btnDoiMatKhauNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhauNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhauNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhauNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhauNhanVien.FillColor = System.Drawing.Color.Navy;
            this.btnDoiMatKhauNhanVien.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhauNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhauNhanVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnDoiMatKhauNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMatKhauNhanVien.Location = new System.Drawing.Point(0, 112);
            this.btnDoiMatKhauNhanVien.Name = "btnDoiMatKhauNhanVien";
            this.btnDoiMatKhauNhanVien.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnDoiMatKhauNhanVien.Size = new System.Drawing.Size(242, 56);
            this.btnDoiMatKhauNhanVien.TabIndex = 4;
            this.btnDoiMatKhauNhanVien.Text = "Đổi mật khẩu";
            this.btnDoiMatKhauNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMatKhauNhanVien.TextOffset = new System.Drawing.Point(50, 0);
            this.btnDoiMatKhauNhanVien.Click += new System.EventHandler(this.btnDoiMatKhauNhanVien_Click);
            // 
            // btnXemLuong
            // 
            this.btnXemLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemLuong.FillColor = System.Drawing.Color.Navy;
            this.btnXemLuong.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemLuong.ForeColor = System.Drawing.Color.White;
            this.btnXemLuong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnXemLuong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemLuong.Location = new System.Drawing.Point(0, 56);
            this.btnXemLuong.Name = "btnXemLuong";
            this.btnXemLuong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnXemLuong.Size = new System.Drawing.Size(242, 56);
            this.btnXemLuong.TabIndex = 3;
            this.btnXemLuong.Text = "Xem Lương";
            this.btnXemLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemLuong.TextOffset = new System.Drawing.Point(50, 0);
            this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);
            // 
            // btnDangKyNghiPhep
            // 
            this.btnDangKyNghiPhep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKyNghiPhep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyNghiPhep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyNghiPhep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKyNghiPhep.FillColor = System.Drawing.Color.Navy;
            this.btnDangKyNghiPhep.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKyNghiPhep.ForeColor = System.Drawing.Color.White;
            this.btnDangKyNghiPhep.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnDangKyNghiPhep.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyNghiPhep.Location = new System.Drawing.Point(0, 0);
            this.btnDangKyNghiPhep.Name = "btnDangKyNghiPhep";
            this.btnDangKyNghiPhep.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.btnDangKyNghiPhep.Size = new System.Drawing.Size(242, 56);
            this.btnDangKyNghiPhep.TabIndex = 2;
            this.btnDangKyNghiPhep.Text = "Đăng Ký Nghỉ Phép";
            this.btnDangKyNghiPhep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyNghiPhep.TextOffset = new System.Drawing.Point(50, 0);
            this.btnDangKyNghiPhep.Click += new System.EventHandler(this.btnDangKyNghiPhep_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblChucVu);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblTenNV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 157);
            this.panel4.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucVu.Location = new System.Drawing.Point(58, 117);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(145, 20);
            this.lblChucVu.TabIndex = 5;
            this.lblChucVu.Text = "Product Designer";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyNhanSu_3Tang_EF.Properties.Resources.manager;
            this.pictureBox2.Location = new System.Drawing.Point(58, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenNV.ForeColor = System.Drawing.Color.Black;
            this.lblTenNV.Location = new System.Drawing.Point(91, 97);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(66, 20);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Jagdish";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PanelLoad
            // 
            this.guna2PanelLoad.BorderRadius = 20;
            this.guna2PanelLoad.Controls.Add(this.label7);
            this.guna2PanelLoad.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2PanelLoad.Location = new System.Drawing.Point(280, 80);
            this.guna2PanelLoad.Name = "guna2PanelLoad";
            this.guna2PanelLoad.Size = new System.Drawing.Size(1020, 591);
            this.guna2PanelLoad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dashboard";
            // 
            // frmMenuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.guna2PanelLoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenuNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2PanelLoad.ResumeLayout(false);
            this.guna2PanelLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnXemThongBao;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLoad;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhauNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnXemLuong;
        private Guna.UI2.WinForms.Guna2Button btnDangKyNghiPhep;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private PictureBox pictureBox2;
    }

}