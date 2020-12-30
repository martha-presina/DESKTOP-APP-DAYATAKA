using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //Header untuk Sql Server agar dikenali
using System.Data;   //Namespace untuk DataSet

namespace AppAsrama.Model
{
    class LoginModel
    {
        //object class connection
        private SqlConnection sqlConn;

        //declare variabel(opsional)
        private string query;
        private bool hasil;

        //koneksi ke db (constructor)
        public LoginModel()
        {
            sqlConn = Connection.KoneksiSql.GetSqlConn();
        }

        //enkapsulasi
        //1. Information Hiding
        private string id_Login;
        private string nama;
        private string nik;
        private string password;
        private string jabatan;


        //2. Interface for acc data
        public string GetIdLogin()
        {
            return id_Login;
        }
        public void SetIdLogin(string id_Login)
        {
            this.id_Login = id_Login;
        }

        public string GetNama()
        {
            return nama;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }

        public string GetNik()
        {
            return nik;
        }
        public void SetNik(string nik)
        {
            this.nik = nik;
        }

        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetJabatan()
        {
            return jabatan;
        }
        public void SetJabatan(string jabatan)
        {
            this.jabatan = jabatan;
        }

        //fungsi untuk validasi login
        public bool Login(string id, string pwd)
        {
            query = "SELECT P.id_Login, A.nama, P.password FROM pengurus P JOIN anggota A ON P.nik = A.nik WHERE P.id_Login= '"+id+"' AND P.password ='"+pwd+"'";
            //membuka connection
            sqlConn.Open();
            //eksekusi query
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            //membaca hasil query
            SqlDataReader reader = command.ExecuteReader();

            //cek login
            while (reader.Read())
            {
                if ((reader.GetString(0) == id) && (reader.GetString(2) == pwd))
                {
                    hasil = true;
                    Controller.LoginController.SetNama(reader.GetString(1).ToString());
                    Controller.LoginController.SetKode(reader.GetString(0).ToString());
                }
                else
                {
                    hasil = false;
                }
            }
            //menutup koneksi
            sqlConn.Close();

            return hasil;
        }
        //fungsi untuk menampilkan data
        public DataSet SelectPengurus()
        {
            query = "SELECT P.nik, A.nama, P.jabatan, P.id_Login, PWDENCRYPT(P.password) FROM pengurus P JOIN anggota A ON P.nik = A.nik";
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "pengurus");

            sqlConn.Close();
            return ds;
        }

        //fungsi untuk menambah data
        public bool InsertPengurus()
        {
            hasil = false;

            try
            {
                query = "INSERT INTO pengurus VALUES('"+nik+"','"+jabatan+"','"+id_Login+"','"+password+"')";
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
        public bool DeletePengurus()
        {
            hasil = false;

            try
            {
                query = "DELETE FROM pengurus WHERE id_Login = '"+id_Login+"'";
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
        public bool UpdatePengurus()
        {
            hasil = false;

            try
            {
                query = "UPDATE pengurus SET nik = '"+nik+"', jabatan = '"+jabatan+ "', password = '" + password + "' WHERE id_Login = '" + id_Login+"'";
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
