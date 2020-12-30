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
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        //object class controller
        private Controller.ReportController control;

        //deklarasi variabel bantu
        private bool hasil;

        public ReportPage()
        {
            InitializeComponent();
            control = new Controller.ReportController(this);
            control.SelectMonthlyReport();
            control.SelectTot_Saldo();
        }
        //fungsi untuk berpindah page(TAB)
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("View/AddReportPage.xaml", UriKind.Relative));
        }

        //fungsi button Detail
        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            control.SelectMonthlyDetail();
        }
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtBulan.Text = "";
            txtTahun.Text = "";
            control.SelectMonthlyDetail();
        }
    }
}
