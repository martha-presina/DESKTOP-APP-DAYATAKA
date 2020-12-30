using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppAsrama.Controller
{
    class RentController
    {
        //1. declare object dari view dan model
        private Model.LoanAndReturnModel modelLoan;
        private Model.ReportModel modelReport;
        private View.LoanAndReturnPage viewLoan;
        private View.AddReportPage viewAddReport;
        private View.RentPage viewRent;


        //2. instansiasi (Contructor)
        public RentController(View.LoanAndReturnPage viewLoan)
        {
            this.viewLoan = viewLoan;
            modelLoan = new Model.LoanAndReturnModel();
        }

        public RentController(View.RentPage viewRent)
        {
            this.viewRent = viewRent;
            modelLoan = new Model.LoanAndReturnModel();
            modelReport = new Model.ReportModel();
        }

        public RentController(View.AddReportPage viewAddReport)
        {
            this.viewAddReport = viewAddReport;
            modelReport = new Model.ReportModel();
        }


        //fungsi untuk menambahkan data
        public bool InsertLoan()
        {
            modelLoan.SetKd_Peminjaman(viewRent.txtKd_Peminjaman.Text);
            modelLoan.SetId_Login(viewRent.txtIdLogin.Text);
            modelLoan.SetNo_Inven(viewRent.txtKd_Inven.Text);
            modelLoan.SetNama_Peminjam(viewRent.txtNama_Peminjam.Text);
            modelLoan.SetTgl_Pinjam(viewRent.dpTgl_Pinjam.Text);
            modelLoan.SetTgl_Kembali(viewRent.dpTgl_Kembali.Text);

            bool hasil = modelLoan.InsertLoan();
            return hasil;
        }

        public bool InsertReport()
        {
            modelReport.SetNo_Keu(viewRent.txtFN.Text);
            modelReport.SetTgl(viewRent.dpTgl.Text);
            modelReport.SetId_Login(viewRent.txtId_Login.Text);
            modelReport.SetJml_Masuk(viewRent.txtIncome.Text);
            modelReport.SetJml_Keluar(viewRent.txtSpending.Text);
            modelReport.SetKeterangan(viewRent.txtInfo.Text);

            bool hasil = modelReport.InsertReport();
            return hasil;
        }
    }
}
