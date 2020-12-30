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
using System.Windows.Shapes;

namespace AppAsrama.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //deklarasi object controller
        private Controller.LoginController controll;

        //constructor
        public LoginWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;        //code agar Window berukuran maksimum
            txtID.Focus();                              //code untuk pointer tepat berada pada textbox ID
            //instansiasi ke controller
            controll = new Controller.LoginController(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //variabel bantu
            bool hasil = controll.Login();
            //pengkondisian
            //jika variabel hasil bernilai benar, maka
            if (hasil)
            {
                MainWindow mObj = new MainWindow();     //inisialisasi MainWindow sebagai Window baru
                mObj.Show();                            //menampilkan MainWindow
                this.Close();                           //window Login akan ditutup
            }
            //jika variabel hasil bernilai false/salah, maka
            else
            {
                MessageBox.Show("ID / PASSWORD SALAH BROO!!!", "Warning");       //menampilkan messagebox
                txtID.Text = "";                                                 //textbox ID dikosongkan
                txtPWD.Password = "";                                            //textbox password dikosongkan
                txtID.Focus();                                                   //pointer tepat di textbox ID
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Minimized)
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        private void ShowHide_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            HidePassword();
        }

        private void ShowHide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPassword();
        }
        private void ShowHide_MouseLeave(object sender, MouseEventArgs e)
        {
            HidePassword();
        }
        private void txtPWDBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPWD.Password.Length > 0)
                ShowHide.Visibility = Visibility.Visible;
            else
                ShowHide.Visibility = Visibility.Hidden;
        }

        void ShowPassword()
        {
            txtVisiblePWD.Visibility = Visibility.Visible;
            txtPWD.Visibility = Visibility.Hidden;
            txtVisiblePWD.Text = txtPWD.Password;
        }
        void HidePassword()
        {
            txtVisiblePWD.Visibility = Visibility.Hidden;
            txtPWD.Visibility = Visibility.Visible;
            txtPWD.Focus();
        }


    }
}
