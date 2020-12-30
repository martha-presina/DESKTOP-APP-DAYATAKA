using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //Namespace untuk penggunaan DataSet

namespace AppAsrama.Controller
{
    class MemberController
    {
        //1. declare object dari view dan model
        private Model.MemberModel modelMember;
        private View.MemberPage viewMember;

        //2. instansiasi (Contructor)
        public MemberController(View.MemberPage viewMember)
        {
            this.viewMember = viewMember;
            modelMember = new Model.MemberModel();
        }

        //fungsi untuk menampilkan data
        public void SelectMember()
        {
            DataSet data = modelMember.SelectMember(viewMember.txtCari.Text, viewMember.txtCari.Text);
            viewMember.dgMember.ItemsSource = data.Tables[0].DefaultView;
        }

        //fungsi untuk menambahkan data
        public bool InsertMember()
        {
            modelMember.SetNIK(viewMember.txtNIK.Text);
            modelMember.SetNama(viewMember.txtNama.Text);
            modelMember.SetTmpt_Lahir(viewMember.txtTmpt_lahir.Text);
            modelMember.SetTgl_Lahir(viewMember.dpTgl_lahir.Text);
            modelMember.SetJK(viewMember.cmbJK.Text);
            modelMember.SetAlamat(viewMember.txtAlamat.Text);
            modelMember.SetAgama(viewMember.cmbAgama.Text);
            modelMember.SetNo_hp(viewMember.txtNo_hp.Text);
            modelMember.SetEmail(viewMember.txtEmail.Text);
            modelMember.SetGol_Darah(viewMember.txtGol_darah.Text);
            modelMember.SetNo_kamar(viewMember.txtNo_kamar.Text);


            bool hasil = modelMember.InsertMember();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeleteMember()
        {
            modelMember.SetNIK(viewMember.txtNIK.Text);

            bool hasil = modelMember.DeleteMember();
            return hasil;
        }

        //fungsi untuk memperbaharui data
        public bool UpdateMember()
        {
            modelMember.SetNIK(viewMember.txtNIK.Text);
            modelMember.SetNama(viewMember.txtNama.Text);
            modelMember.SetTmpt_Lahir(viewMember.txtTmpt_lahir.Text);
            modelMember.SetTgl_Lahir(viewMember.dpTgl_lahir.Text);
            modelMember.SetJK(viewMember.cmbJK.Text);
            modelMember.SetAlamat(viewMember.txtAlamat.Text);
            modelMember.SetAgama(viewMember.cmbAgama.Text);
            modelMember.SetNo_hp(viewMember.txtNo_hp.Text);
            modelMember.SetEmail(viewMember.txtEmail.Text);
            modelMember.SetGol_Darah(viewMember.txtGol_darah.Text);
            modelMember.SetNo_kamar(viewMember.txtNo_kamar.Text);

            bool hasil = modelMember.UpdateMember();
            return hasil;
        }
    }
}
