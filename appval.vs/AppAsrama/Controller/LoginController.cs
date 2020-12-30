using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //Namespace untuk penggunaan DataSet

namespace AppAsrama.Controller
{
    class LoginController
    {
        //1. declare object dari view dan model
        private View.LoginWindow viewLogin;
        private Model.LoginModel modelLogin;
        private Model.MemberModel modelMember;
        private View.PengurusPage viewPengurus;

        //deklarasi variabel untuk menampung nama dan juga kode
        private static String nama;
        private static String kode;
        public static void SetNama(String nama)
        {
            LoginController.nama = nama;
        }

        public static String GetNama()
        {
            return nama;
        }

        public static void SetKode(String kode)
        {
            LoginController.kode = kode;
        }

        public static String GetKode()
        {
            return kode;
        }

        //2. instansiasi (Contructor)
        public LoginController(View.LoginWindow viewLogin)
        {
            this.viewLogin = viewLogin;
            modelLogin = new Model.LoginModel();
        }
        public LoginController(View.PengurusPage viewPengurus)
        {
            this.viewPengurus = viewPengurus;
            modelLogin = new Model.LoginModel();
            modelMember = new Model.MemberModel();
        }

        //3. cek login
        public bool Login()
        {
            bool hasil = modelLogin.Login(viewLogin.txtID.Text, viewLogin.txtPWD.Password);

            return hasil;
        }

        //fungsi untuk menampilkan data
        public void SelectPengurus()
        {
            DataSet data = modelLogin.SelectPengurus();
            viewPengurus.dgPengurus.ItemsSource = data.Tables[0].DefaultView;
        }

        public void SelectNIK()
        {
            DataSet data = modelMember.SelectNIK();

            viewPengurus.txtNik.DataContext = data.Tables[0].DefaultView;
            viewPengurus.txtNik.DisplayMemberPath = data.Tables[0].Columns[0].ToString();
            viewPengurus.txtNik.SelectedValuePath = data.Tables[0].Columns[0].ToString();
        }

        //fungsi untuk menambahkan data
        public bool InsertPengurus()
        {
            modelLogin.SetIdLogin(viewPengurus.txtIdLogin.Text);
            modelLogin.SetNik(viewPengurus.txtNik.Text);
            modelLogin.SetPassword(viewPengurus.txtPassword.Password);
            modelLogin.SetJabatan(viewPengurus.txtJabatan.Text);

            bool hasil = modelLogin.InsertPengurus();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeletePengurus()
        {
            modelLogin.SetIdLogin(viewPengurus.txtIdLogin.Text);

            bool hasil = modelLogin.DeletePengurus();
            return hasil;
        }

        //fungsi untuk memperbaharui data
        public bool UpdatePengurus()
        {
            modelLogin.SetIdLogin(viewPengurus.txtIdLogin.Text);
            modelLogin.SetNik(viewPengurus.txtNik.Text);
            modelLogin.SetPassword(viewPengurus.txtPassword.Password);
            modelLogin.SetJabatan(viewPengurus.txtJabatan.Text);

            bool hasil = modelLogin.UpdatePengurus();
            return hasil;
        }
    }
}
