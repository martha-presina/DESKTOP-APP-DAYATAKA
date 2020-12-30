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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            WindowState = WindowState.Maximized;
            lblDataUser.Content = Controller.LoginController.GetNama();
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

        private void lblHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HomePage());
        }

        private void lblMember_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.MemberPage());
        }
        private void lblReport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.ReportPage());
        }
        private void lblRent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.RentPage());
        }
        private void lblInventory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.InventoryPage());
        }
        private void imgUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myPopup.IsOpen = true;
        }

        private void lblLogOut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindow lObj = new LoginWindow();
            lObj.Show();
            this.Close();
        }

        private void lblAbout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AboutWindow aObj = new AboutWindow();
            aObj.Show();
        }

        private void lblInfo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PengurusPage());
        }


    }
}
