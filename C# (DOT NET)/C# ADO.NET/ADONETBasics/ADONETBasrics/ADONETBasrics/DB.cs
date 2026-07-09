using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.;
using System.Web.UI.WebControls;

namespace JobCirkitAdmin.Common
{
    public class DB
    {
        public DB()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        SqlConnection connectionString = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

        #region Control Specific

        public DropDownList FillAndReturnDropDownList(DropDownList DropDownListName, string SQLSelect)
        {
            DataTable dt = FillAndReturnDataTable(SQLSelect);

            DropDownListName.Items.Add("--Select--");
            DropDownListName.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownListName.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            return DropDownListName;
        }

        public DropDownList FillAndReturnDropDownList(DropDownList DropDownListName, DataTable DataTableName)
        {

            DropDownListName.Items.Add("--Select--");
            DropDownListName.Items.Clear();

            for (int i = 0; i < DataTableName.Rows.Count; i++)
            {
                DropDownListName.Items.Add(DataTableName.Rows[i].ItemArray[0].ToString());
            }

            return DropDownListName;
        }

        public GridView FillAndReturnGridView(GridView GridViewName, DataTable DataTableName)
        {
            if (DataTableName.Rows.Count != 0)
            {
                GridViewName.DataSource = DataTableName;
                GridViewName.DataBind();
            }
            return GridViewName;

        }

        #endregion

        #region SQL Specific
        public int InsertUpdateOrDelete(string SPName, nameValuePairList NameValuePairObject)
        {
            SqlCommand cmdObject = new SqlCommand(SPName, GetConnection());
            cmdObject.CommandType = CommandType.StoredProcedure;
            foreach (nameValuePair objList in NameValuePairObject)
            {
                cmdObject.Parameters.AddWithValue(objList.getName, objList.getValue);
            }

            int status = 0;

            try
            {
                status = cmdObject.ExecuteNonQuery();
                CloseConnection();
                return status;
            }
            catch (Exception exp)
            {
                return status;
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }


        }
        public int InsertUpdateOrDelete(string InsertQuery)
        {
            SqlCommand cmdObject = new SqlCommand(InsertQuery, GetConnection());
            
            int status = 0;

            try
            {
                status = cmdObject.ExecuteNonQuery();
                CloseConnection();
                return status;
            }
            catch (Exception exp)
            {
                return status;
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }


        }

        public DataSet AddTableToDataSet(DataTable dtName)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dtName);
            return ds;
        }

        public DataTable FillAndReturnDataTable(string SelectQuery)
        {

            SqlDataAdapter adp = new SqlDataAdapter(SelectQuery, GetConnection());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            CloseConnection();
            return dt;

        }

        public DataSet FillAndReturnDataSet(string SelectQuery)
        {
            SqlDataAdapter adp = new SqlDataAdapter(SelectQuery, GetConnection());
            DataSet ds = new DataSet();
            adp.Fill(ds);
            CloseConnection();

            return ds;
        }

        public DataTable FillAndReturnDataSet(string StoredProcedureName, nameValuePairList NameValuePairObject)
        {
            try
            {
                SqlCommand CommandObject = new SqlCommand(StoredProcedureName, GetConnection());

                //CommandObject.CommandType = CommandType.StoredProcedure;

                foreach (nameValuePair objList in NameValuePairObject)
                {
                    CommandObject.Parameters.Add(createSqlParameter(objList.getName, objList.getValue));
                }

                SqlDataReader ReaderObject = CommandObject.ExecuteReader();

                DataSet ds = ConvertDataReaderToDataSet(ReaderObject);

                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }




        }
        
        public DataSet FillAndResturnMultipleTable(string StoredProcedureName, nameValuePairList NameValuePairObject)
        {
            try
            {
                SqlCommand CommandObject = new SqlCommand(StoredProcedureName, GetConnection());

                CommandObject.CommandType = CommandType.StoredProcedure;

                foreach (nameValuePair objList in NameValuePairObject)
                {
                    CommandObject.Parameters.Add(createSqlParameter(objList.getName, objList.getValue));
                }

                SqlDataReader ReaderObject = CommandObject.ExecuteReader();

                DataSet ds = ConvertDataReaderToDataSet(ReaderObject);


                return ds;                
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }
        }
        #endregion

        #region Connection Oriented Functions
        public SqlConnection GetConnection()
        {
            connectionString.Open();
            return connectionString;

        }
        public void CloseConnection()
        {

            connectionString.Close();
           // connectionString.Dispose();
        }
        #endregion

        #region DataReader to DataSet

        public DataSet ConvertDataReaderToDataSet(SqlDataReader reader)
        {
            DataSet dataSet = new DataSet();
            do
            {
                // Create new data table

                DataTable schemaTable = reader.GetSchemaTable();
                DataTable dataTable = new DataTable();

                if (schemaTable != null)
                {
                    // A query returning records was executed

                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        // Create a column name that is unique in the data table
                        string columnName = (string)dataRow["ColumnName"]; //+ "<C" + i + "/>";
                                                                           // Add the column definition to the data table
                        DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                        dataTable.Columns.Add(column);
                    }

                    dataSet.Tables.Add(dataTable);

                    // Fill the data table we just created

                    while (reader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                            dataRow[i] = reader.GetValue(i);

                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // No records were returned

                    DataColumn column = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = reader.RecordsAffected;
                    dataTable.Rows.Add(dataRow);
                }
            }
            while (reader.NextResult());
            return dataSet;
        }

        #endregion

        private SqlParameter createSqlParameter(string name, object value)
        {
            SqlParameter objSqlParameter = new SqlParameter(name, value);
            return objSqlParameter;
        }
    }

    #region Name Value Pair and List...
    public class nameValuePairList : List<nameValuePair>
    {

    }

    public class nameValuePair
    {
        string _name;
        object _value;

        public nameValuePair(string iName, object iValue)
        {
            _name = iName;
            _value = iValue;
        }

        public string getName
        {
            get { return _name; }
            set { _name = value; }
        }

        public object getValue
        {
            get { return _value; }
            set { _value = value; }
        }
    }
    #endregion
}