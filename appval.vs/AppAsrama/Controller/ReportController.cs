using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //Namespace untuk penggunaan DataSet

namespace AppAsrama.Controller
{
    class ReportController
    {
        //1. declare object dari view dan model
        private Model.ReportModel modelReport;
        private View.AddReportPage viewAddReport;
        private View.ReportPage viewReport;

        //2. instansiasi (Contructor)
        public ReportController(View.AddReportPage viewAddReport)
        {
            this.viewAddReport = viewAddReport;
            modelReport = new Model.ReportModel();
        }
        public ReportController(View.ReportPage viewReport)
        {
            this.viewReport = viewReport;
            modelReport = new Model.ReportModel();
        }

        //fungsi untuk menampilkan data
        public void SelectReport()
        {
            DataSet data = modelReport.SelectReport();
            viewAddReport.dgReport.ItemsSource = data.Tables[0].DefaultView;
        }

        //fungsi untuk menambahkan data
        public bool InsertReport()
        {
            modelReport.SetNo_Keu(viewAddReport.txtFN.Text);
            modelReport.SetTgl(viewAddReport.dpTgl.Text);
            modelReport.SetId_Login(viewAddReport.txtIdLogin.Text);
            modelReport.SetJml_Masuk(viewAddReport.txtIncome.Text);
            modelReport.SetJml_Keluar(viewAddReport.txtSpending.Text);
            modelReport.SetKeterangan(viewAddReport.txtInfo.Text);

            bool hasil = modelReport.InsertReport();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeleteReport()
        {
            modelReport.SetKd_Keu(viewAddReport.txtFN.Text);

            bool hasil = modelReport.DeleteReport();
            return hasil;
        }

        //fungsi untuk memperbaharui data
        public bool UpdateReport()
        {
            modelReport.SetNo_Keu(viewAddReport.txtFN.Text);
            modelReport.SetTgl(viewAddReport.dpTgl.Text);
            modelReport.SetId_Login(viewAddReport.txtIdLogin.Text);
            modelReport.SetJml_Masuk(viewAddReport.txtIncome.Text);
            modelReport.SetJml_Keluar(viewAddReport.txtSpending.Text);
            modelReport.SetKeterangan(viewAddReport.txtInfo.Text);

            bool hasil = modelReport.UpdateReport();
            return hasil;
        }
        //fungsi untuk menampilkan data
        public void SelectMonthlyReport()
        {
            DataSet data = modelReport.SelectMonthlyReport();
            viewReport.dgRecap.ItemsSource = data.Tables[0].DefaultView;
        }

        //fungsi untuk menampilkan data
        public void SelectTot_Saldo()
        {
            DataSet data = modelReport.SelectTotSaldo();
            viewReport.dgSaldo.ItemsSource = data.Tables[0].DefaultView;
        }

        public void SelectMonthlyDetail()
        {
            DataSet data = modelReport.SelectDetail(viewReport.txtBulan.Text, viewReport.txtTahun.Text);
            viewReport.dgDetail.ItemsSource = data.Tables[0].DefaultView;
        }

    }
}
