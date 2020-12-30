using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //Header untuk Sql Server agar dikenali
using System.Data;  //Namespace untuk DataSet

namespace AppAsrama.Model
{
    class LoanAndReturnModel
    {
        //object class connection
        private SqlConnection sqlConn;

        //declare variabel(opsional)
        private string query;
        private bool hasil;

        //koneksi ke db (constructor)
        public LoanAndReturnModel()
        {
            sqlConn = Connection.KoneksiSql.GetSqlConn();
        }

        //enkapsulasi
        //1. Information Hiding
        private string no_peminjaman;
        private string kd_peminjaman;
        private string id_Login;
        private string no_inven;
        private string kd_inven;
        private string nama_peminjam;
        private string tgl_pinjam;
        private string tgl_kembali;
        private string nama;
        private string nama_barang;

        //2. Interface for acc data
        public string GetNo_Peminjaman()
        {
            return no_peminjaman;
        }
        public void SetNo_Peminjaman(string no_peminjaman)
        {
            this.no_peminjaman = no_peminjaman;
        }
        public string GetKd_Peminjaman()
        {
            return kd_peminjaman;
        }
        public void SetKd_Peminjaman(string kd_peminjaman)
        {
            this.kd_peminjaman = kd_peminjaman;
        }

        public string GetId_Login()
        {
            return id_Login;
        }
        public void SetId_Login(string id_Login)
        {
            this.id_Login = id_Login;
        }

        public string GetNo_Inven()
        {
            return no_inven;
        }
        public void SetNo_Inven(string no_inven)
        {
            this.no_inven = no_inven;
        }

        public string GetKd_Inven()
        {
            return kd_inven;
        }
        public void SetKd_Inven(string kd_inven)
        {
            this.kd_inven = kd_inven;
        }

        public string GetNama_Peminjam()
        {
            return nama_peminjam;
        }
        public void SetNama_Peminjam(string nama_peminjam)
        {
            this.nama_peminjam = nama_peminjam;
        }

        public string GetNama()
        {
            return nama;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }

        public string GetNama_Barang()
        {
            return nama_barang;
        }
        public void SetNama_Barang(string nama_barang)
        {
            this.nama_barang = nama_barang;
        }

        public string GetTgl_Pinjam()
        {
            return tgl_pinjam;
        }
        public void SetTgl_Pinjam(string tgl_pinjam)
        {
            this.tgl_pinjam = tgl_pinjam;
        }

        public string GetTgl_Kembali()
        {
            return tgl_kembali;
        }
        public void SetTgl_Kembali(string tgl_kembali)
        {
            this.tgl_kembali = tgl_kembali;
        }

        //fungsi untuk menampilkan data
        public DataSet SelectLoan(string kd_peminjaman)
        {
            query = "SELECT P.kd_peminjaman, P.id_Login, A.nama, I.no_inven, I.kd_inven, I.nama_barang, P.nama_peminjam, P.tgl_pinjam, P.tgl_kembali FROM peminjaman P JOIN pengurus ON pengurus.id_Login = P.id_Login JOIN anggota A ON pengurus.nik = A.nik JOIN inventaris I ON I.no_inven = P.no_inven WHERE kd_peminjaman LIKE '%" + kd_peminjaman + "%'";
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "peminjaman");

            sqlConn.Close();
            return ds;
        }

        //fungsi untuk menambah data
        public bool InsertLoan()
        {
            hasil = false;

            try
            {
                query = "INSERT INTO peminjaman VALUES('" + id_Login + "','" + no_inven + "', '" + nama_peminjam + "', '" + tgl_pinjam + "', '" + tgl_kembali + "')";
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
        public bool DeleteLoan()
        {
            hasil = false;

            try
            {
                query = "DELETE FROM peminjaman WHERE kd_peminjaman = '" + kd_peminjaman + "'";
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
        public bool UpdateLoan()
        {
            hasil = false;

            try
            {
                query = "UPDATE peminjaman SET no_inven = '" + no_inven + "', nama_peminjam = '" + nama_peminjam + "', tgl_pinjam = '" + tgl_pinjam + "', tgl_kembali = '" +
                                                    tgl_kembali + "' WHERE kd_peminjaman = '" + kd_peminjaman + "'";
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
