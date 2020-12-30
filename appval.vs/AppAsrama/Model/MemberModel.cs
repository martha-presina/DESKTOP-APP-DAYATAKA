using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //Header untuk Sql Server agar dikenali
using System.Data;  //Namespace untuk DataSet

namespace AppAsrama.Model
{
    class MemberModel
    {
        //object class connection
        private SqlConnection sqlConn;
        private SqlCommand command;

        //declare variabel(opsional)
        private string query;
        private bool hasil;

        //koneksi ke db (constructor)
        public MemberModel()
        {
            sqlConn = Connection.KoneksiSql.GetSqlConn();
        }

        //enkapsulasi
        //1. Information Hiding
        private string nik;
        private string nama;
        private string tmpt_lahir;
        private string tgl_lahir;
        private string jk;
        private string alamat;
        private string agama;
        private string no_hp;
        private string email;
        private string gol_darah;
        private string no_kamar;

        //2. Interface for acc data
        public string GetNIK()
        {
            return nik;
        }
        public void SetNIK(string nik)
        {
            this.nik = nik;
        }

        public string GetNama()
        {
            return nama;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }

        public string GetTmpt_Lahir()
        {
            return tmpt_lahir;
        }
        public void SetTmpt_Lahir(string tmpt_lahir)
        {
            this.tmpt_lahir = tmpt_lahir;
        }
        public string GetTgl_Lahir()
        {
            return tgl_lahir;
        }
        public void SetTgl_Lahir(string tgl_lahir)
        {
            this.tgl_lahir = tgl_lahir;
        }

        public string GetJK()
        {
            return jk;
        }
        public void SetJK(string jk)
        {
            this.jk = jk;
        }

        public string GetAlamat()
        {
            return alamat;
        }
        public void SetAlamat(string alamat)
        {
            this.alamat = alamat;
        }
        public string GetAgama()
        {
            return agama;
        }
        public void SetAgama(string agama)
        {
            this.agama = agama;
        }

        public string GetNo_hp()
        {
            return no_hp;
        }
        public void SetNo_hp(string no_hp)
        {
            this.no_hp = no_hp;
        }
   
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetGol_Darah()
        {
            return gol_darah;
        }
        public void SetGol_Darah(string gol_darah)
        {
            this.gol_darah = gol_darah;
        }

        public string GetNo_kamar()
        {
            return no_kamar;
        }
        public void SetNo_kamar(string no_kamar)
        {
            this.no_kamar = no_kamar;
        }

        //fungsi untuk menampilkan data
        public DataSet SelectMember(string nik, string nama)
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                command = new SqlCommand();
                command.Connection = sqlConn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT nik, nama, tmpt_lahir, tgl_lahir, jk, alamat, agama, no_hp, email, gol_darah, no_kamar FROM anggota "+
                                      "WHERE nik LIKE '%"+ nik +"%' OR nama LIKE '%"+ nama +"%'";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "anggota");
                sqlConn.Close();
            }
            catch (SqlException) { }
            return ds;
        }

        public DataSet SelectNIK()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                command = new SqlCommand();
                command.Connection = sqlConn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT DISTINCT nik FROM anggota";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "anggota");
                sqlConn.Close();
            }
            catch (SqlException) { }
            return ds;
        }

        //fungsi untuk menambah data
        public bool InsertMember()
        {
            hasil = false;

            try
            {
                query = "INSERT INTO anggota VALUES('" +nik+ "','" +nama+ "','" +tmpt_lahir+ "', '"+tgl_lahir+"', +'"+jk+"', '"+alamat+"','"+agama+"', '"+no_hp+"', '"+email+"', '"+gol_darah+ "', '" + no_kamar+ "')";
                sqlConn.Open();

                SqlCommand command = sqlConn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            sqlConn.Close();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeleteMember()
        {
            hasil = false;

            try
            {
                query = "DELETE FROM anggota WHERE nik = '" + nik + "'";
                sqlConn.Open();

                SqlCommand command = sqlConn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            sqlConn.Close();
            return hasil;
        }

        //fungsi untuk mengupdate data
        public bool UpdateMember()
        {
            hasil = false;

            try
            {
                query = "UPDATE anggota SET nama = '" + nama + "', tmpt_lahir = '" + tmpt_lahir + "', tgl_lahir = '" + tgl_lahir + "', jk = +'" +
                                                    jk + "', alamat = '" + alamat + "', agama = '" + agama + "', no_hp = '" + no_hp + "', email = '" +
                                                    email + "', gol_darah = '" + gol_darah + "', no_kamar = '" + no_kamar + "' WHERE nik = '" + nik + "'";
                sqlConn.Open();

                SqlCommand command = sqlConn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            sqlConn.Close();
            return hasil;
        }
    }
}
