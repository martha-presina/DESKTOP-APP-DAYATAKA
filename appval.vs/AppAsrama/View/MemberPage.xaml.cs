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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Page
    {
        //object class controller
        private Controller.MemberController control;

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
            control.SelectMember();
            AturButton(true);
        }
        public MemberPage()
        {
            InitializeComponent();
            control = new Controller.MemberController(this);
            TampilData();
        }

        //fungsi untuk berpindah page(TAB)
        private void btnPengurus_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("View/PengurusPage.xaml", UriKind.Relative));
        }

        //fungsi button Tambah
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            AturButton(false);

            txtNIK.Text = "";
            txtNama.Text = "";
            txtTmpt_lahir.Text = "";
            dpTgl_lahir.Text = "";
            cmbJK.Text = "";
            txtAlamat.Text = "";
            cmbAgama.Text = "";
            txtNo_hp.Text = "";
            txtEmail.Text = "";
            txtGol_darah.Text = "";
            txtNo_kamar.Text = "";

            txtNIK.Focus();
        }

        //fungsi button Simpan
        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.InsertMember();
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
            hasil = control.DeleteMember();
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
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.UpdateMember();
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
            control.SelectMember();
        }


        //fungsi button Refresh
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtCari.Text = "";
            control.SelectMember();
        }
    }
}
