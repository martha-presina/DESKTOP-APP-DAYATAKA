using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //Header untuk Sql Server agar dikenali
using System.Data;  //Namespace untuk DataSet

namespace AppAsrama.Model
{
    class InventoryModel
    {
        //object class connection
        private SqlConnection sqlConn;
        private SqlCommand command;

        //declare variabel(opsional)
        private string query;
        private bool hasil;

        //koneksi ke db (constructor)
        public InventoryModel()
        {
            sqlConn = Connection.KoneksiSql.GetSqlConn();
        }


        //enkapsulasi
        //1. Information Hiding
        private string no_inven;
        private string kd_inven;
        private string nama_barang;
        private string stock;

        //2. Interface for acc data
        public string GetNo_Inven()
        {
            return no_inven;
        }
        public void SetNo_Inven(string No_inven)
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

        public string GetNama_Barang()
        {
            return nama_barang;
        }
        public void SetNama_Barang(string nama_barang)
        {
            this.nama_barang = nama_barang;
        }

        public string GetStock()
        {
            return stock;
        }
        public void SetStock(string stock)
        {
            this.stock = stock;
        }

        //fungsi untuk menampilkan data
        public DataSet SelectInventory()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                command = new SqlCommand();
                command.Connection = sqlConn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT no_inven, kd_inven, nama_barang, stock FROM inventaris";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "inventaris");
                sqlConn.Close();
            }
            catch (SqlException) { }
            return ds;
        }

        public DataSet SelectNo_Inven()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                command = new SqlCommand();
                command.Connection = sqlConn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT DISTINCT no_inven FROM inventaris";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "inventaris");
                sqlConn.Close();
            }
            catch (SqlException) { }
            return ds;
        }

        //fungsi untuk menambah data
        public bool InsertInventory()
        {
            hasil = false;

            try
            {
                query = "INSERT INTO inventaris VALUES('" + nama_barang + "','" + stock + "')";
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
        public bool DeleteInventory()
        {
            hasil = false;

            try
            {
                query = "DELETE FROM inventaris WHERE kd_inven = '" + kd_inven + "'";
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
        public bool UpdateInventory()
        {
            hasil = false;

            try
            {
                query = "UPDATE inventaris SET nama_barang = '" + nama_barang + "', stock = '" + stock + "' WHERE kd_inven = '" + kd_inven + "'";
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
