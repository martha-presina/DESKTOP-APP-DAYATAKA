using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppAsrama.View
{
    /// <summary>
    /// Interaction logic for LoanAndReturnPage.xaml
    /// </summary>
    public partial class LoanAndReturnPage : Page
    {
        //object class controller
        private Controller.LoanAndReturnController control;

        //deklarasi variabel bantu
        private bool hasil;

        //fungsi untuk mengatur button
        public void AturButton(Boolean status)
        {
            btnTambah.IsEnabled = status;
            btnSimpan.IsEnabled = !status;
            btnHapus.IsEnabled = status;
            btnUpdate.IsEnabled = status;
            btnCancel.IsEnabled = !status;
        }

        public void TampilData()
        {
            control.SelectLoan();
            AturButton(true);
        }

        public LoanAndReturnPage()
        {
            InitializeComponent();
            control = new Controller.LoanAndReturnController(this);
            txtIdLogin.Text = Controller.LoginController.GetKode();
            TampilData();
        }

        //fungsi untuk berpindah page(TAB)
        private void btnInven_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("View/InventoryPage.xaml", UriKind.Relative));
        }

        //fungsi button Tambah
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {

            txtIdLogin.Text = Controller.LoginController.GetKode();
            AturButton(false);
            control.SelectNo_Inven();

            txtKd_Peminjaman.Text = "";
            txtKd_Inven.SelectedIndex = 0;
            txtNama_Peminjam.Text = "";
            dpTgl_Pinjam.Text = "";
            dpTgl_Kembali.Text = "";

            txtKd_Inven.Focus();
        }

        //fungsi button Simpan
        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.InsertLoan();
            if (hasil)
            {
                MessageBox.Show("Data saved successfully");
            }
            else
            {
                MessageBox.Show("Data failed to save");
            }
            TampilData();
        }

        //fungsi button Hapus
        private void btnHapus_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Will the item be returned ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                control.DeleteLoan();
                MessageBox.Show("Succesfully");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            TampilData();
        }

        //fungsi button Update
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.UpdateLoan();
            if (hasil)
            {
                MessageBox.Show("Data updated successfully");
            }
            else
            {
                MessageBox.Show("Data failed to update");
            }
            TampilData();
        }

        //fungsi button Cancel
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            TampilData();
        }

        //fungsi button Cari
        private void btnCari_Click(object sender, RoutedEventArgs e)
        {
            control.SelectLoan();
        }
        //fungsi button Refresh
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtCari.Text = "";
            control.SelectLoan();
        }
    }
}
