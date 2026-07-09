using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADONETSample
{
    internal class DB
    {
        SqlConnection Connection;
        public SqlConnection GetConenction()
        {
            string ConnectionString = "Server=localhost\\SQLEXPRESS;DataBase=BikeStore;TrustServerCertificate=true;Encrypt=True; Integrated Security=SSPI;Persist Security Info=False;";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
        public DataTable FetchAndReturnDataTable(string SelectQuery)
        {
            

            SqlDataAdapter adpStudent = new SqlDataAdapter(SelectQuery, GetConenction());
            DataTable dt = new DataTable();
            adpStudent.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
