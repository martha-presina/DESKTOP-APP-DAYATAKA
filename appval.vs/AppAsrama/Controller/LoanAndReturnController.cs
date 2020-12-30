using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //Namespace untuk penggunaan DataSet

namespace AppAsrama.Controller
{
    class LoanAndReturnController
    {
        //1. declare object dari view dan model
        private Model.LoanAndReturnModel modelLoan;
        private Model.InventoryModel modelInven;
        private View.LoanAndReturnPage viewLoan;

        //2. instansiasi (Contructor)
        public LoanAndReturnController(View.LoanAndReturnPage viewLoan)
        {
            this.viewLoan = viewLoan;
            modelLoan = new Model.LoanAndReturnModel();
            modelInven = new Model.InventoryModel();
        }

        //fungsi untuk menampilkan data
        public void SelectLoan()
        {
            DataSet data = modelLoan.SelectLoan(viewLoan.txtCari.Text);
            viewLoan.dgLoan.ItemsSource = data.Tables[0].DefaultView;
        }

        public void SelectNo_Inven()
        {
            DataSet data = modelInven.SelectNo_Inven();

            viewLoan.txtKd_Inven.DataContext = data.Tables[0].DefaultView;
            viewLoan.txtKd_Inven.DisplayMemberPath = data.Tables[0].Columns[0].ToString();
            viewLoan.txtKd_Inven.SelectedValuePath = data.Tables[0].Columns[0].ToString();
        }

        //fungsi untuk menambahkan data
        public bool InsertLoan()
        {
            modelLoan.SetKd_Peminjaman(viewLoan.txtKd_Peminjaman.Text);
            modelLoan.SetId_Login(viewLoan.txtIdLogin.Text);
            modelLoan.SetNo_Inven(viewLoan.txtKd_Inven.Text);
            modelLoan.SetNama_Peminjam(viewLoan.txtNama_Peminjam.Text);
            modelLoan.SetTgl_Pinjam(viewLoan.dpTgl_Pinjam.Text);
            modelLoan.SetTgl_Kembali(viewLoan.dpTgl_Kembali.Text);
            
            bool hasil = modelLoan.InsertLoan();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeleteLoan()
        {
            modelLoan.SetKd_Peminjaman(viewLoan.txtKd_Peminjaman.Text);

            bool hasil = modelLoan.DeleteLoan();
            return hasil;
        }

        //fungsi untuk memperbaharui data
        public bool UpdateLoan()
        {
            modelLoan.SetKd_Peminjaman(viewLoan.txtKd_Peminjaman.Text);
            modelLoan.SetId_Login(viewLoan.txtIdLogin.Text);
            modelLoan.SetNo_Inven(viewLoan.txtKd_Inven.Text);
            modelLoan.SetNama_Peminjam(viewLoan.txtNama_Peminjam.Text);
            modelLoan.SetTgl_Pinjam(viewLoan.dpTgl_Pinjam.Text);
            modelLoan.SetTgl_Kembali(viewLoan.dpTgl_Kembali.Text);

            bool hasil = modelLoan.UpdateLoan();
            return hasil;
        }
    }
}

