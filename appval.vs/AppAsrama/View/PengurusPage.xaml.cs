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
    /// Interaction logic for PengurusPage.xaml
    /// </summary>
    public partial class PengurusPage : Page
    {
        //object class controller
        private Controller.LoginController control;

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
            control.SelectPengurus();
            AturButton(true);
        }

        public PengurusPage()
        {
            InitializeComponent();
            control = new Controller.LoginController(this);
            control.SelectNIK();
            TampilData();
        }

        //fungsi untuk berpindah page(TAB)
        private void btnMember_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("View/MemberPage.xaml", UriKind.Relative));
        }

        //fungsi button Tambah
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            control.SelectNIK();
            AturButton(false);

            txtIdLogin.Text = "";
            txtPassword.Password = "";
            txtJabatan.Text = "";
            txtNik.SelectedIndex = 0;
            txtNik.IsEnabled = true;
            txtNik.Focus();
        }

        //fungsi button Simpan
        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.InsertPengurus();
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
            hasil = control.DeletePengurus();
            var result = MessageBox.Show("Will the data be deleted ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes && hasil == true)
            {               
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Data failed to delete");
            }
            TampilData();
        }

        //fungsi button Update
        public void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.UpdatePengurus();
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
