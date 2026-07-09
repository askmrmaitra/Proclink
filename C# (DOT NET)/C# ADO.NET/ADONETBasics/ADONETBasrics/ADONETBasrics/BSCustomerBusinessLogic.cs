using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static ADONETBasrics.BSCustomerBusinessLogic;

namespace ADONETBasrics
{

    internal class BSCustomerBusinessLogic
    {
        public class Customer
        {
           public int CustomerID { get; set; }
           public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime CreatedAt { get; set; }

        }

        private DB1 dalObject = new DB1();
        public int SaveCustomer(Customer customer)
        {
            //string InsertQuery = @"INSERT INTO [dummy].[Customer]
            //                           ([FirstName]
            //                           ,[LastName]
            //                           ,[Email]
            //                           ,[PhoneNumber]
            //                           ,[DateOfBirth]
            //                           ,[CreatedAt]
            //                           )
            //                     VALUES
            //                           (@FirstName
            //                           ,@LastName
            //                           ,@Email
            //                           ,@PhoneNumber
            //                           ,@DateOfBirth
            //                           ,@CreatedAt
            //                           )";

            string InsertQuery = "[dummy].[SaveCustomer]";

            nameValuePairList nvpList = new nameValuePairList();
            nvpList.Add(new nameValuePair("@FirstName", customer.FirstName));
            nvpList.Add(new nameValuePair("@LastName", customer.LastName));
            nvpList.Add(new nameValuePair("@Email", customer.Email));
            nvpList.Add(new nameValuePair("@Phone", customer.PhoneNumber));
            nvpList.Add(new nameValuePair("@DoB", customer.DateOfBirth));
            //nvpList.Add(new nameValuePair("CreatedAt", customer.CreatedAt));

            int Status = dalObject.InsertUpdateOrDelete(InsertQuery, nvpList,true);

       
            if (Status != 0)
            {
               return Status;
            }
            else
            {
                return 0;
                Console.WriteLine("OOPS!!!! Error");
            }
        }
        public DataTable FetchCustomerData()
        {
            string SelectQuery = "Select * from dummy.Customer ";
            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
          return dt;
        }

        public int CustomerCount()
        {
            string CustomerCountQ = "Select Count(*) 'Total Customer' from dummy.Customer";
            object countVal = dalObject.FetchCount(CustomerCountQ);
            int count = (int)countVal;
            return count;
        }
        public DataTable FetCustomerData(string Phone)
        {
            string SelectQuery = "Select * from dummy.Customer Where PhoneNumber='" + Phone + "'"; ;
            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
            return dt;
        }

        public DataSet FetchStoreAndBrand()
        {
            string firstQuery = "Select * from production.brands";
            string secondQuery = "Select* from sales.stores";

            DataSet dataSet = dalObject.FillMultipleTables(firstQuery, secondQuery);
            return dataSet;
        }

        public DataSet FetchProductStockfromDB()
        {
            string Query = "Select * from production.products;Select * from production.stocks";
            DataSet ds = dalObject.FillAndReturnDataSet(Query);
            return ds;
        }

       
    }
}
