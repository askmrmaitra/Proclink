using System.Data;
using System.Data.SqlClient;

namespace ADONETBasrics
{
    internal class Program
    {
        // string sql = "Data Source=localhost;Initial Catalog=BikeStores;Integrated Security=True;TrustServerCertificate=true";

        private static BSCustomerBusinessLogic bllObj = new BSCustomerBusinessLogic(); 
        static void Main(string[] args)
        {
            BSCustomerBusinessLogic.Customer newCust = new BSCustomerBusinessLogic.Customer();
            Console.WriteLine("First Name: ");
            newCust.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            newCust.LastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            newCust.Email = Console.ReadLine();
            Console.WriteLine("Phone: ");
            newCust.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Date Of Birth: ");
            newCust.DateOfBirth = DateTime.Parse(Console.ReadLine().ToString());

           int Status =  bllObj.SaveCustomer(newCust);

            if (Status == 0)
            {
                Console.WriteLine("Data Saved...");
            }
            else {
                Console.WriteLine("Something Went Wrong...");
            }
            ////FetchData();
            //InsertQuery(newCust);
            //Console.WriteLine("Total Number of Customer: "+bllObj.CustomerCount());
            //DataSet ds = bllObj.FetchStoreAndBrand();

            //DataTable dtBrand = ds.Tables[0];
            //DataTable dtStore = ds.Tables[1];

            //Console.WriteLine("Brand Table");
            ////for (int i = 0; i < dtBrand.Rows.Count; i++)
            ////{
            ////    Console.WriteLine(dtBrand.Rows[i].ItemArray[1].ToString());
            ////}
            //foreach (DataRow dr in dtBrand.Rows) {
            //    Console.WriteLine($"Brand ID: {dr["brand_id"]} and Brand Name: {dr["brand_name"]}");
            //}
            //Console.WriteLine("****Finished******");
            //Console.WriteLine("Now Showing Stores...");
            //Console.ReadKey();
            //for (int i = 0; i < dtStore.Rows.Count; i++)
            //{
            //    Console.WriteLine(dtStore.Rows[i].ItemArray[1].ToString());
            //}
            DataTable customerTable = bllObj.FetchCustomerData();

            //// Perform LINQ query on the "customerTable" to all the Data 
            //var customerList = from customer in customerTable.AsEnumerable()
            //                   select new
            //                   {
            //                       CustomerID = customer.Field<int>("CustomerID"),
            //                       FirstName = customer.Field<string>("FirstName"),
            //                       LastName = customer.Field<string>("LastName"),
            //                       Email = customer.Field<string>("Email"),
            //                       PhoneNumber = customer.Field<string>("PhoneNumber"),
            //                       DateOfBirth = customer.IsNull("DateOfBirth") ? (DateTime?)null : customer.Field<DateTime>("DateOfBirth"),
            //                       CreatedAt = customer.Field<DateTime>("CreatedAt")
            //                   };

            //// Iterate through the query result and print the customer details
            //foreach (var customer in customerList)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, FirstName: {customer.FirstName}, " +
            //                      $"LastName: {customer.LastName}, Email: {customer.Email}, " +
            //                      $"PhoneNumber: {customer.PhoneNumber}, DateOfBirth: {(customer.DateOfBirth.HasValue ? customer.DateOfBirth.Value.ToString("yyyy-MM-dd") : "N/A")}, " +
            //                      $"CreatedAt: {customer.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss")}");
            //}

            //// Perform LINQ query on the "customerTable" with a 'Where' condition on CreatedAt
            //var filteredCustomers = customerTable.AsEnumerable()
            //                         .Where(customer => customer.Field<DateTime>("CreatedAt") > new DateTime(2024, 1, 1))
            //                         .Select(customer => new
            //                         {
            //                             CustomerID = customer.Field<int>("CustomerID"),
            //                             FirstName = customer.Field<string>("FirstName"),
            //                             LastName = customer.Field<string>("LastName"),
            //                             Email = customer.Field<string>("Email"),
            //                             PhoneNumber = customer.Field<string>("PhoneNumber"),
            //                             CreatedAt = customer.Field<DateTime>("CreatedAt")
            //                         });

            //// Iterate through the filtered result and print the customer details
            //foreach (var customer in filteredCustomers)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, FirstName: {customer.FirstName}, " +
            //                      $"LastName: {customer.LastName}, Email: {customer.Email}, " +
            //                      $"PhoneNumber: {customer.PhoneNumber}, CreatedAt: {customer.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss")}");
            //}

            //// Perform LINQ query on the "customerTable" with a 'Where' condition on DOB
            //var filteredCustomers = customerTable.AsEnumerable()
            //                                     .Where(customer => !customer.IsNull("DateOfBirth") && customer.Field<DateTime>("DateOfBirth") > new DateTime(1990, 1, 1))
            //                                     .Select(customer => new
            //                                     {
            //                                         CustomerID = customer.Field<int>("CustomerID"),
            //                                         FirstName = customer.Field<string>("FirstName"),
            //                                         LastName = customer.Field<string>("LastName"),
            //                                         Email = customer.Field<string>("Email"),
            //                                         PhoneNumber = customer.Field<string>("PhoneNumber"),
            //                                         DateOfBirth = customer.Field<DateTime>("DateOfBirth"),
            //                                         CreatedAt = customer.Field<DateTime>("CreatedAt")
            //                                     });

            //// Iterate through the filtered result and print the customer details
            //foreach (var customer in filteredCustomers)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, FirstName: {customer.FirstName}, " +
            //                      $"LastName: {customer.LastName}, Email: {customer.Email}, " +
            //                      $"PhoneNumber: {customer.PhoneNumber}, DateOfBirth: {customer.DateOfBirth.ToString("yyyy-MM-dd")}, " +
            //                      $"CreatedAt: {customer.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss")}");
            //}

            Console.ReadKey();
        }

        public static void InsertQuery(BSCustomerBusinessLogic.Customer cust)
        {
            int Status = bllObj.SaveCustomer(cust);
            if (Status == 0)
            {
                Console.WriteLine("OOPS!!! The Data Could not be Saved...");
            }
            else {
                Console.WriteLine("Data Saved...");
                //How many data is available now

            }
        }
        public static void FetchData()
        {
            
            DataTable dtCust = bllObj.FetchCustomerData();

            if (dtCust.Rows.Count > 0)
            {
                for (int i = 0; i < dtCust.Rows.Count; i++)
                {
                    Console.WriteLine($"Id:{dtCust.Rows[i].ItemArray[0].ToString()} and Name:{dtCust.Rows[i].ItemArray[1].ToString()}");
                }
            }

        }



    }
}
