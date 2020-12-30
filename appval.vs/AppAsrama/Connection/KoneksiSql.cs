using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;          //Header SQL Server, agar dapat dikenali

namespace AppAsrama.Connection
{
    class KoneksiSql
    {
        //inisialisasi variabel
        private static SqlConnection SqlConn;           

        public static SqlConnection GetSqlConn()
        {
            //Instansiasi(penghubung)
            SqlConn = new SqlConnection();
            SqlConn.ConnectionString = "Data Source=LAPTOP-KSJGEF6O\\SQLEXPRESS;" +
                                        "Initial Catalog=Asrama_DT;" + 
                                        "Integrated Security=True";

            return SqlConn;
        }
    }
}
