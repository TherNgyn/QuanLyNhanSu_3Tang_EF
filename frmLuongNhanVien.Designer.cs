using System.Drawing;
using System.Windows.Forms;
using System;

namespace QuanLyNhanSu_3Tang_EF
{
    partial class frmLuongNhanVien
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
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSoTienNguoiPhuThuoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuongThucTe = new System.Windows.Forms.TextBox();
            this.lblPhuCapChucVu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtSoNgayCongChuan = new System.Windows.Forms.TextBox();
            this.txtSoNgayLamViec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThuongPhat = new System.Windows.Forms.Label();
            this.txtThuongPhat = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtTongBaoHiem = new System.Windows.Forms.TextBox();
            this.lblTongBHYT = new System.Windows.Forms.Label();
            this.lblBHTN = new System.Windows.Forms.Label();
            this.txtBHTN = new System.Windows.Forms.TextBox();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.txtBHXH = new System.Windows.Forms.TextBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.lblBHXH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.txtGiamTruGiaCanh = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.lblThucLanh = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.txtThucLanh = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.Navy;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(279, 616);
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(176, 42);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Text = "Xem lương";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Navy;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(646, 616);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox3);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.lblThue);
            this.guna2GroupBox1.Controls.Add(this.txtGiamTruGiaCanh);
            this.guna2GroupBox1.Controls.Add(this.txtThue);
            this.guna2GroupBox1.Controls.Add(this.lblThucLanh);
            this.guna2GroupBox1.Controls.Add(this.lblMaNhanVien);
            this.guna2GroupBox1.Controls.Add(this.lblLuongCoBan);
            this.guna2GroupBox1.Controls.Add(this.txtThucLanh);
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.txtLuongCoBan);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(976, 586);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "THÔNG TIN LƯƠNG";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.guna2Separator2);
            this.guna2GroupBox3.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox3.Controls.Add(this.lblSoTienNguoiPhuThuoc);
            this.guna2GroupBox3.Controls.Add(this.label3);
            this.guna2GroupBox3.Controls.Add(this.txtLuongThucTe);
            this.guna2GroupBox3.Controls.Add(this.lblPhuCapChucVu);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.txtPhuCap);
            this.guna2GroupBox3.Controls.Add(this.txtSoNgayCongChuan);
            this.guna2GroupBox3.Controls.Add(this.txtSoNgayLamViec);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.lblThuongPhat);
            this.guna2GroupBox3.Controls.Add(this.txtThuongPhat);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(513, 60);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(445, 382);
            this.guna2GroupBox3.TabIndex = 25;
            this.guna2GroupBox3.Text = "CHẤM CÔNG";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.White;
            this.guna2Separator2.Location = new System.Drawing.Point(8, 297);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(434, 27);
            this.guna2Separator2.TabIndex = 25;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "\"MM/yyyy\"";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(238, 59);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(195, 36);
            this.guna2DateTimePicker1.TabIndex = 24;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 10, 24, 13, 37, 28, 220);
            // 
            // lblSoTienNguoiPhuThuoc
            // 
            this.lblSoTienNguoiPhuThuoc.AutoSize = true;
            this.lblSoTienNguoiPhuThuoc.BackColor = System.Drawing.Color.White;
            this.lblSoTienNguoiPhuThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoTienNguoiPhuThuoc.ForeColor = System.Drawing.Color.Black;
            this.lblSoTienNguoiPhuThuoc.Location = new System.Drawing.Point(12, 334);
            this.lblSoTienNguoiPhuThuoc.Name = "lblSoTienNguoiPhuThuoc";
            this.lblSoTienNguoiPhuThuoc.Size = new System.Drawing.Size(125, 22);
            this.lblSoTienNguoiPhuThuoc.TabIndex = 22;
            this.lblSoTienNguoiPhuThuoc.Text = "Lương thực tế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng:";
            // 
            // txtLuongThucTe
            // 
            this.txtLuongThucTe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuongThucTe.Location = new System.Drawing.Point(238, 330);
            this.txtLuongThucTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongThucTe.Name = "txtLuongThucTe";
            this.txtLuongThucTe.ReadOnly = true;
            this.txtLuongThucTe.Size = new System.Drawing.Size(193, 30);
            this.txtLuongThucTe.TabIndex = 12;
            // 
            // lblPhuCapChucVu
            // 
            this.lblPhuCapChucVu.AutoSize = true;
            this.lblPhuCapChucVu.BackColor = System.Drawing.Color.White;
            this.lblPhuCapChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhuCapChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblPhuCapChucVu.Location = new System.Drawing.Point(12, 256);
            this.lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            this.lblPhuCapChucVu.Size = new System.Drawing.Size(78, 22);
            this.lblPhuCapChucVu.TabIndex = 16;
            this.lblPhuCapChucVu.Text = "Phụ cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số ngày làm việc:";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhuCap.Location = new System.Drawing.Point(238, 254);
            this.txtPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.ReadOnly = true;
            this.txtPhuCap.Size = new System.Drawing.Size(193, 30);
            this.txtPhuCap.TabIndex = 14;
            // 
            // txtSoNgayCongChuan
            // 
            this.txtSoNgayCongChuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoNgayCongChuan.Location = new System.Drawing.Point(238, 110);
            this.txtSoNgayCongChuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNgayCongChuan.Name = "txtSoNgayCongChuan";
            this.txtSoNgayCongChuan.ReadOnly = true;
            this.txtSoNgayCongChuan.Size = new System.Drawing.Size(193, 30);
            this.txtSoNgayCongChuan.TabIndex = 0;
            // 
            // txtSoNgayLamViec
            // 
            this.txtSoNgayLamViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoNgayLamViec.Location = new System.Drawing.Point(238, 158);
            this.txtSoNgayLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNgayLamViec.Name = "txtSoNgayLamViec";
            this.txtSoNgayLamViec.ReadOnly = true;
            this.txtSoNgayLamViec.Size = new System.Drawing.Size(193, 30);
            this.txtSoNgayLamViec.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ngày công chuẩn:";
            // 
            // lblThuongPhat
            // 
            this.lblThuongPhat.AutoSize = true;
            this.lblThuongPhat.BackColor = System.Drawing.Color.White;
            this.lblThuongPhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThuongPhat.ForeColor = System.Drawing.Color.Black;
            this.lblThuongPhat.Location = new System.Drawing.Point(12, 210);
            this.lblThuongPhat.Name = "lblThuongPhat";
            this.lblThuongPhat.Size = new System.Drawing.Size(117, 22);
            this.lblThuongPhat.TabIndex = 18;
            this.lblThuongPhat.Text = "Thưởng/Phạt:";
            // 
            // txtThuongPhat
            // 
            this.txtThuongPhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThuongPhat.Location = new System.Drawing.Point(238, 206);
            this.txtThuongPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThuongPhat.Name = "txtThuongPhat";
            this.txtThuongPhat.ReadOnly = true;
            this.txtThuongPhat.Size = new System.Drawing.Size(193, 30);
            this.txtThuongPhat.TabIndex = 8;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2Separator1);
            this.guna2GroupBox2.Controls.Add(this.txtTongBaoHiem);
            this.guna2GroupBox2.Controls.Add(this.lblTongBHYT);
            this.guna2GroupBox2.Controls.Add(this.lblBHTN);
            this.guna2GroupBox2.Controls.Add(this.txtBHTN);
            this.guna2GroupBox2.Controls.Add(this.lblBHYT);
            this.guna2GroupBox2.Controls.Add(this.txtBHXH);
            this.guna2GroupBox2.Controls.Add(this.txtBHYT);
            this.guna2GroupBox2.Controls.Add(this.lblBHXH);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(19, 283);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(464, 270);
            this.guna2GroupBox2.TabIndex = 23;
            this.guna2GroupBox2.Text = "BẢO HIỂM";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 210);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(457, 14);
            this.guna2Separator1.TabIndex = 6;
            // 
            // txtTongBaoHiem
            // 
            this.txtTongBaoHiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongBaoHiem.Location = new System.Drawing.Point(260, 230);
            this.txtTongBaoHiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongBaoHiem.Name = "txtTongBaoHiem";
            this.txtTongBaoHiem.ReadOnly = true;
            this.txtTongBaoHiem.Size = new System.Drawing.Size(193, 30);
            this.txtTongBaoHiem.TabIndex = 3;
            // 
            // lblTongBHYT
            // 
            this.lblTongBHYT.AutoSize = true;
            this.lblTongBHYT.BackColor = System.Drawing.Color.White;
            this.lblTongBHYT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongBHYT.ForeColor = System.Drawing.Color.Black;
            this.lblTongBHYT.Location = new System.Drawing.Point(11, 234);
            this.lblTongBHYT.Name = "lblTongBHYT";
            this.lblTongBHYT.Size = new System.Drawing.Size(56, 22);
            this.lblTongBHYT.TabIndex = 2;
            this.lblTongBHYT.Text = "Tổng:";
            // 
            // lblBHTN
            // 
            this.lblBHTN.AutoSize = true;
            this.lblBHTN.BackColor = System.Drawing.Color.White;
            this.lblBHTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBHTN.ForeColor = System.Drawing.Color.Black;
            this.lblBHTN.Location = new System.Drawing.Point(11, 71);
            this.lblBHTN.Name = "lblBHTN";
            this.lblBHTN.Size = new System.Drawing.Size(148, 22);
            this.lblBHTN.TabIndex = 1;
            this.lblBHTN.Text = "Bảo hiểm tai nạn:";
            // 
            // txtBHTN
            // 
            this.txtBHTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBHTN.Location = new System.Drawing.Point(260, 62);
            this.txtBHTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBHTN.Name = "txtBHTN";
            this.txtBHTN.ReadOnly = true;
            this.txtBHTN.Size = new System.Drawing.Size(193, 30);
            this.txtBHTN.TabIndex = 0;
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.BackColor = System.Drawing.Color.White;
            this.lblBHYT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBHYT.ForeColor = System.Drawing.Color.Black;
            this.lblBHYT.Location = new System.Drawing.Point(11, 165);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(124, 22);
            this.lblBHYT.TabIndex = 1;
            this.lblBHYT.Text = "Bảo hiểm y tế:";
            // 
            // txtBHXH
            // 
            this.txtBHXH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBHXH.Location = new System.Drawing.Point(260, 112);
            this.txtBHXH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBHXH.Name = "txtBHXH";
            this.txtBHXH.ReadOnly = true;
            this.txtBHXH.Size = new System.Drawing.Size(193, 30);
            this.txtBHXH.TabIndex = 0;
            // 
            // txtBHYT
            // 
            this.txtBHYT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBHYT.Location = new System.Drawing.Point(260, 162);
            this.txtBHYT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.ReadOnly = true;
            this.txtBHYT.Size = new System.Drawing.Size(193, 30);
            this.txtBHYT.TabIndex = 0;
            // 
            // lblBHXH
            // 
            this.lblBHXH.AutoSize = true;
            this.lblBHXH.BackColor = System.Drawing.Color.White;
            this.lblBHXH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBHXH.ForeColor = System.Drawing.Color.Black;
            this.lblBHXH.Location = new System.Drawing.Point(11, 118);
            this.lblBHXH.Name = "lblBHXH";
            this.lblBHXH.Size = new System.Drawing.Size(144, 22);
            this.lblBHXH.TabIndex = 1;
            this.lblBHXH.Text = "Bảo hiểm xã hội:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giảm trừ gia cảnh";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.BackColor = System.Drawing.Color.White;
            this.lblThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThue.ForeColor = System.Drawing.Color.Black;
            this.lblThue.Location = new System.Drawing.Point(30, 226);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(55, 22);
            this.lblThue.TabIndex = 15;
            this.lblThue.Text = "Thuế:";
            // 
            // txtGiamTruGiaCanh
            // 
            this.txtGiamTruGiaCanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiamTruGiaCanh.Location = new System.Drawing.Point(279, 166);
            this.txtGiamTruGiaCanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamTruGiaCanh.Name = "txtGiamTruGiaCanh";
            this.txtGiamTruGiaCanh.ReadOnly = true;
            this.txtGiamTruGiaCanh.Size = new System.Drawing.Size(193, 30);
            this.txtGiamTruGiaCanh.TabIndex = 11;
            // 
            // txtThue
            // 
            this.txtThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThue.Location = new System.Drawing.Point(279, 219);
            this.txtThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThue.Name = "txtThue";
            this.txtThue.ReadOnly = true;
            this.txtThue.Size = new System.Drawing.Size(193, 30);
            this.txtThue.TabIndex = 7;
            // 
            // lblThucLanh
            // 
            this.lblThucLanh.AutoSize = true;
            this.lblThucLanh.BackColor = System.Drawing.Color.White;
            this.lblThucLanh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThucLanh.ForeColor = System.Drawing.Color.Black;
            this.lblThucLanh.Location = new System.Drawing.Point(513, 466);
            this.lblThucLanh.Name = "lblThucLanh";
            this.lblThucLanh.Size = new System.Drawing.Size(209, 35);
            this.lblThucLanh.TabIndex = 17;
            this.lblThucLanh.Text = "THỰC LÃNH:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.BackColor = System.Drawing.Color.White;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblMaNhanVien.Location = new System.Drawing.Point(30, 65);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 19;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.BackColor = System.Drawing.Color.White;
            this.lblLuongCoBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuongCoBan.ForeColor = System.Drawing.Color.Black;
            this.lblLuongCoBan.Location = new System.Drawing.Point(30, 118);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(125, 22);
            this.lblLuongCoBan.TabIndex = 20;
            this.lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // txtThucLanh
            // 
            this.txtThucLanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThucLanh.Location = new System.Drawing.Point(728, 466);
            this.txtThucLanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThucLanh.Name = "txtThucLanh";
            this.txtThucLanh.ReadOnly = true;
            this.txtThucLanh.Size = new System.Drawing.Size(227, 30);
            this.txtThucLanh.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(279, 60);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(193, 30);
            this.txtMaNV.TabIndex = 10;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(279, 113);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.ReadOnly = true;
            this.txtLuongCoBan.Size = new System.Drawing.Size(193, 30);
            this.txtLuongCoBan.TabIndex = 13;
            // 
            // frmLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 666);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLuongNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLuongNhanVien_FormClosing);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnThoat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label lblBHTN;
        private System.Windows.Forms.TextBox txtBHTN;
        private System.Windows.Forms.Label lblBHYT;
        private System.Windows.Forms.TextBox txtBHXH;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.Label lblBHXH;
        private System.Windows.Forms.Label lblSoTienNguoiPhuThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhuCapChucVu;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtLuongThucTe;
        private System.Windows.Forms.TextBox txtGiamTruGiaCanh;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Label lblThucLanh;
        private System.Windows.Forms.Label lblThuongPhat;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.TextBox txtThucLanh;
        private System.Windows.Forms.TextBox txtThuongPhat;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoNgayCongChuan;
        private System.Windows.Forms.TextBox txtSoNgayLamViec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongBaoHiem;
        private System.Windows.Forms.Label lblTongBHYT;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}