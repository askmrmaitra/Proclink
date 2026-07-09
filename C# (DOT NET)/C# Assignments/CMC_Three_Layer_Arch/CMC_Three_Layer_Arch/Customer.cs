using System.Data;

namespace CMC_Three_Layer_Arch
{
    internal class Customer
    {
        DB dalObj = new DB();

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int SaveCustomer()
        {
            string InsertQuery = @"INSERT INTO Customer
                                   (CustomerName, Email, PhoneNumber)
                                   VALUES
                                   (@CustomerName, @Email, @PhoneNumber)";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@CustomerName", CustomerName));
            ParameterList.Add(new NameValuePair("@Email", Email));
            ParameterList.Add(new NameValuePair("@PhoneNumber", PhoneNumber));

            return dalObj.ExecuteQuery(InsertQuery, ParameterList);
        }

        public DataTable FetchCustomers()
        {
            string SelectQuery = "SELECT * FROM Customer";

            return dalObj.FetchData(SelectQuery);
        }

        public int UpdateCustomer()
        {
            string UpdateQuery = @"UPDATE Customer
                                   SET CustomerName=@CustomerName,
                                       Email=@Email,
                                       PhoneNumber=@PhoneNumber
                                   WHERE CustomerID=@CustomerID";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@CustomerID", CustomerID));
            ParameterList.Add(new NameValuePair("@CustomerName", CustomerName));
            ParameterList.Add(new NameValuePair("@Email", Email));
            ParameterList.Add(new NameValuePair("@PhoneNumber", PhoneNumber));

            return dalObj.ExecuteQuery(UpdateQuery, ParameterList);
        }

        public int DeleteCustomer()
        {
            string DeleteQuery = "DELETE FROM Customer WHERE CustomerID=@CustomerID";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@CustomerID", CustomerID));

            return dalObj.ExecuteQuery(DeleteQuery, ParameterList);
        }
    }
}