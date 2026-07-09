using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADONETSample
{
    internal class Student
    {

        DB dalObj = new();

        public int SaveData(string Name, string Phone, string Email)
        {
            string InsertQuery = "INSERT INTO [dbo].[student]([studentName],[studentPhone],[studentEmail]) VALUES(@studentName,@studentPhone,@studentEmail)";
            SqlCommand cmdObject = new SqlCommand(InsertQuery, dalObj.GetConenction());

            
            //Set Values in Params...
            cmdObject.Parameters.AddWithValue("@studentName", Name);
            cmdObject.Parameters.AddWithValue("@studentPhone", Phone);
            cmdObject.Parameters.AddWithValue("@studentEmail", Email);

            int Status = cmdObject.ExecuteNonQuery();
            dalObj.CloseConnection();
            return Status;

        }

        public DataTable FetchStudent()
        {
            string Select = "Select * from [dbo].[student]";

            DataTable dtStudent = dalObj.FetchAndReturnDataTable(Select);
            return dtStudent;
        }

      
    }
}
