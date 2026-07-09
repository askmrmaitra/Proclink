using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADONETSample
{
    public class DB
    {
        SqlConnection Connection;
        public SqlConnection GetConenction()
        {
            string ConnectionString = "Server=localhost\\SQLEXPRESS;DataBase=BikeStore;TrustServerCertificate=true;Encrypt=True; Integrated Security=SSPI;Persist Security Info=False;";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        private SqlParameter createSqlParameter(string name, object value)
        {
            SqlParameter objSqlParameter = new SqlParameter(name, value);
            return objSqlParameter;
        }
        public int InsertUpdateOrDelete(string QueryOrSPName, nameValuePairList NameValuePairObject, bool IsSP = false)
        {
            SqlCommand cmdObject = new SqlCommand(QueryOrSPName, GetConenction());

            if (IsSP)
            {
                cmdObject.CommandType = CommandType.StoredProcedure;
            }

            foreach (nameValuePair objList in NameValuePairObject)
            {
                cmdObject.Parameters.Add(createSqlParameter(objList.ColName, objList.Value));
            }

            int status = 0;

            try
            {
                status = cmdObject.ExecuteNonQuery();

                return status;
            }
            catch (Exception exp)
            {
                return status;
            }
            finally
            {
                CloseConnection();
            }


        }
        public int InsertUpdateOrDelete(string InsertQuery)
        {
            SqlCommand cmdObject = new SqlCommand(InsertQuery, GetConenction());

            int status = 0;

            try
            {
                status = cmdObject.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
                return status;
            }
            catch (Exception exp)
            {
                return status;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }


        }
        public object FetchScalar(string Query)
        {
            SqlCommand sqlCommand = new SqlCommand(Query, GetConenction());

            object Count = sqlCommand.ExecuteScalar();
            return Count;
        }
        public DataSet FillMultipleTables(string FirstQuery, string SecondQuery)
        {
            string Query = FirstQuery + ";" + SecondQuery;
            SqlCommand cmdObject = new SqlCommand(Query, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmdObject);
            DataSet dsQuery = new DataSet();
            adapter.Fill(dsQuery);
            CloseConnection();
            return dsQuery;
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


    public class nameValuePairList : List<nameValuePair>
    {

    }


    public class nameValuePair 
    {
        public string ColName { get; set; }
        public object Value { get; set; }
        public nameValuePair(string Name, object ColValue)
        {
            this.ColName = Name;
            this.Value = ColValue;
        }
    }
}
