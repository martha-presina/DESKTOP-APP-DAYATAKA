using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //Header untuk Sql Server agar dikenali
using System.Data;   //Namespace untuk DataSet

namespace AppAsrama.Model
{
    class ReportModel
    {
        //object class connection
        private SqlConnection sqlConn;

        //declare variabel(opsional)
        private string query;
        private bool hasil;

        //koneksi ke db (constructor)
        public ReportModel()
        {
            sqlConn = Connection.KoneksiSql.GetSqlConn();
        }

        //enkapsulasi
        //1. Information Hiding
        private string no_keu;
        private string kd_keu;
        private string tgl;
        private string id_Login;
        private string nama;
        private string jml_masuk;
        private string jml_keluar;
        private string keterangan;
        private string bulan;
        private string tot_masuk;
        private string tot_keluar;
        private string saldo;
        private string tot_saldo;

        //2. int for acc
        public string GetNo_Keu()
        {
            return no_keu;
        }
        public void SetNo_Keu(string no_keu)
        {
            this.no_keu = no_keu;
        }

        public string GetKd_Keu()
        {
            return kd_keu;
        }
        public void SetKd_Keu(string kd_keu)
        {
            this.kd_keu = kd_keu;
        }

        public string GetTgl()
        {
            return tgl;
        }
        public void SetTgl(string tgl)
        {
            this.tgl = tgl;
        }

        public string GetId_Login()
        {
            return id_Login;
        }
        public void SetId_Login(string id_Login)
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

        public string GetJml_Masuk()
        {
            return jml_masuk;
        }
        public void SetJml_Masuk(string jml_masuk)
        {
            this.jml_masuk = jml_masuk;
        }

        public string GetJml_Keluar()
        {
            return jml_keluar;
        }
        public void SetJml_Keluar(string jml_keluar)
        {
            this.jml_keluar = jml_keluar;
        }

        public string GetKeterangan()
        {
            return keterangan;
        }
        public void SetKeterangan(string keterangan)
        {
            this.keterangan = keterangan;
        }

        public string GetBulan()
        {
            return bulan;
        }
        public void SetBulan(string bulan)
        {
            this.bulan = bulan;
        }

        public string GetTot_Masuk()
        {
            return tot_masuk;
        }
        public void SetTot_Masuk(string tot_masuk)
        {
            this.tot_masuk = tot_masuk;
        }
        public string GetTot_Keluar()
        {
            return tot_keluar;
        }
        public void SetTot_Keluar(string tot_keluar)
        {
            this.tot_keluar = tot_keluar;
        }

        public string GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(string saldo)
        {
            this.saldo = saldo;
        }

        public string GetTot_Saldo()
        {
            return tot_saldo;
        }
        public void SetTot_Saldo(string tot_saldo)
        {
            this.tot_saldo = tot_saldo;
        }

        //fungsi untuk menampilkan data
        public DataSet SelectReport()
        {
            query = "SELECT K.no_keu, K.kd_keu, K.tgl, K.id_Login, A.nama, K.jml_masuk, K.jml_keluar, K.keterangan FROM keuangan K JOIN pengurus P ON P.id_Login = K.id_Login JOIN anggota A on P.nik = A.nik";
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "keuangan");

            sqlConn.Close();
            return ds;
        }

        //fungsi untuk menambah data
        public bool InsertReport()
        {
            hasil = false;

            try
            {
                query = "INSERT INTO keuangan VALUES('" + tgl + "','" + id_Login + "','" + jml_masuk + "', '"+jml_keluar+"', '"+keterangan+"')";
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
        public bool DeleteReport()
        {
            hasil = false;

            try
            {
                query = "DELETE FROM keuangan WHERE kd_keu = '" + kd_keu + "'";
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
        public bool UpdateReport()
        {
            hasil = false;

            try
            {
                query = "UPDATE keuangan SET tgl = '" + tgl + "', jml_masuk = '" + jml_masuk + "', jml_keluar = '"+jml_keluar+"', keterangan = '"+keterangan
                        +"' WHERE no_keu = '" + no_keu + "'";
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
        //fungsi untuk menampilkan data
        public DataSet SelectMonthlyReport()
        {
            query = "SELECT CAST(MONTH(tgl) as VARCHAR) as bulan, CAST(YEAR(tgl) as VARCHAR) AS tahun, SUM(jml_masuk) AS tot_masuk," +
                    "SUM(jml_keluar) AS tot_keluar, SUM(jml_masuk)-SUM(jml_keluar)as saldo FROM keuangan GROUP BY MONTH(tgl), YEAR(tgl)";

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "keuangan");

            sqlConn.Close();
            return ds;
        }

        //fungsi untuk menampilkan data
        public DataSet SelectTotSaldo()
        {
            query = "SELECT SUM(jml_masuk) AS tot_masuk, SUM(jml_keluar) AS tot_keluar, SUM(jml_masuk)-SUM(jml_keluar)AS tot_saldo FROM keuangan";

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "keuangan");

            sqlConn.Close();
            return ds;
        }

        public DataSet SelectDetail(string bulan, string tahun)
        {
            query = "SELECT * FROM keuangan WHERE MONTH(tgl) LIKE '%" + bulan + "%' AND YEAR(tgl) LIKE '%" + tahun + "%'";
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds, "keuangan");

            sqlConn.Close();
            return ds;
        }

    }
}
 