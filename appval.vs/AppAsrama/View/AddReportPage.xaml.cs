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
    /// Interaction logic for AddReportPage.xaml
    /// </summary>
    public partial class AddReportPage : Page
    {
        //object class controller
        private Controller.ReportController control;

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
            control.SelectReport();
            AturButton(true);
        }
        public AddReportPage()
        {
            InitializeComponent();
            control = new Controller.ReportController(this);
            txtIdLogin.Text = Controller.LoginController.GetKode();
            TampilData();
        }
        //fungsi untuk berpindah page(TAB)
        private void btnMonthly_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("View/ReportPage.xaml", UriKind.Relative));
        }

        //fungsi button Tambah
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {

            txtIdLogin.Text = Controller.LoginController.GetKode();
            AturButton(false);

            txtFN.Text = "";
            dpTgl.Text = "";
            txtIncome.Text = "";
            txtSpending.Text = "";
            txtInfo.Text = "";

            txtFN.IsEnabled = false;
        }

        //fungsi button Simpan
        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.InsertReport();
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
            var result = MessageBox.Show("Will the data be deleted ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                control.DeleteReport();
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Data failed to delete");
            }
            TampilData();
        }

        //fungsi button Update
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.UpdateReport();
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
    }
}
