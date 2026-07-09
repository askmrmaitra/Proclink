using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CMC_Three_Layer_Arch
{
    internal class DB
    {
        SqlConnection Connection;

        public SqlConnection GetConnection()
        {
            string ConnectionString = @"Data Source=PLK-LAP0487\SQLEXPRESS;
                                        Initial Catalog=Customer_Management;
                                        Integrated Security=True;
                                        TrustServerCertificate=True;
                                        Encrypt=True;";

            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }

        private SqlParameter CreateSqlParameter(string Name, object Value)
        {
            return new SqlParameter(Name, Value);
        }

        public int ExecuteQuery(string Query, NameValuePairList ParameterList)
        {
            SqlCommand cmdObject = new SqlCommand(Query, GetConnection());

            foreach (NameValuePair item in ParameterList)
            {
                cmdObject.Parameters.Add(CreateSqlParameter(item.Name, item.Value));
            }

            int Status = 0;

            try
            {
                Status = cmdObject.ExecuteNonQuery();
                return Status;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable FetchData(string SelectQuery)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(SelectQuery, GetConnection());

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            CloseConnection();

            return dt;
        }

        public DataTable FetchDataWithParameters(string SelectQuery, NameValuePairList ParameterList)
        {
            SqlCommand cmdObject = new SqlCommand(SelectQuery, GetConnection());

            foreach (NameValuePair item in ParameterList)
            {
                cmdObject.Parameters.Add(CreateSqlParameter(item.Name, item.Value));
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmdObject);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            CloseConnection();

            return dt;
        }
    }

    internal class NameValuePair
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public NameValuePair(string Name, object Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }

    internal class NameValuePairList : List<NameValuePair>
    {
    }
}