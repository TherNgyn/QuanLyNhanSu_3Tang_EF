using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyNhanSu_3Tang_EF
{
    public partial class frmReport : Form
    {
        private string reportName;
        private Form parentForm;

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(string MaNV, Form parentForm = null)
        {
            InitializeComponent();
            this.reportName = "ReportLuongHDPCTP";
            this.parentForm = parentForm;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                
                QLNS dataset = new QLNS();

               
                QLNSTableAdapters.vw_ThongTinHopDongTableAdapter adapter =
                    new QLNSTableAdapters.vw_ThongTinHopDongTableAdapter();
                QLNSTableAdapters.NhanVienTableAdapter adapter2 =
                    new QLNSTableAdapters.NhanVienTableAdapter();
                QLNSTableAdapters.PhuCapTableAdapter adapter3 =
                    new QLNSTableAdapters.PhuCapTableAdapter();


                adapter.Fill(dataset.vw_ThongTinHopDong);
                adapter2.Fill(dataset.NhanVien);
                adapter3.Fill(dataset.PhuCap);
            
                ReportDataSource dataSource = new ReportDataSource("DataSet1", (DataTable)dataset.vw_ThongTinHopDong);
                ReportDataSource dsNhanVien = new ReportDataSource("DataSet2", (DataTable)dataset.NhanVien);
                ReportDataSource dsPC = new ReportDataSource("DataSet3", (DataTable)dataset.PhuCap);


                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(dataSource);
                reportViewer.LocalReport.DataSources.Add(dsNhanVien);
                reportViewer.LocalReport.DataSources.Add(dsPC);

                // Làm mới báo cáo
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.Show();
            }
        }
    }
}