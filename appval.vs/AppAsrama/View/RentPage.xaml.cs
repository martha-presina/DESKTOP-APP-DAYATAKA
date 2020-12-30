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
    /// Interaction logic for RentPage.xaml
    /// </summary>
    public partial class RentPage : Page
    {
        //object class controller
        private Controller.RentController control;

        //deklarasi variabel bantu
        private bool hasil;
        private bool hasil2;

        public RentPage()
        {
            InitializeComponent();
            control = new Controller.RentController(this);
            txtIdLogin.Text = Controller.LoginController.GetKode();
            txtId_Login.Text = Controller.LoginController.GetKode();
        }

        //fungsi button Tambah
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {

            txtIdLogin.Text = Controller.LoginController.GetKode();
            txtKd_Inven.Text = "1";
            txtNama_Peminjam.Text = "";
            dpTgl_Pinjam.Text = "";
            dpTgl_Kembali.Text = "";

            txtNama_Peminjam.IsEnabled = true;
            dpTgl_Pinjam.IsEnabled = true;
            dpTgl_Kembali.IsEnabled = true;
            btnNext.IsEnabled = true;
            txtNama_Peminjam.Focus();
        }

        //fungsi button Tambah
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            txtId_Login.Text = Controller.LoginController.GetKode();
            txtRate.Text = "50000";
            txtInfo.Text = "Sewa Kamar Tamu";
            txtSpending.Text = "0";

            txtStays.IsEnabled = true;
            dpTgl.IsEnabled = true;
            dpTgl.Focus();
            btnSimpan.IsEnabled = true;
            btnPay.IsEnabled = true;
        }

        //fungsi button Tambah
        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            txtIncome.Text = (double.Parse(txtStays.Text) * double.Parse(txtRate.Text)).ToString();
        }

        //fungsi button Simpan
        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.InsertLoan();
            hasil2 = control.InsertReport();
            if (hasil && hasil2)
            {
                MessageBox.Show("Data saved successfully");
            }
            else
            {
                MessageBox.Show("Data failed to save");
            }
        }

        //fungsi button Cancel
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
