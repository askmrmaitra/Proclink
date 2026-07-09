using System.Data;

namespace CMC_Three_Layer_Arch
{
    internal class CustomerAddress
    {
        DB dalObj = new DB();

        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }

        public int SaveAddress()
        {
            string InsertQuery = @"INSERT INTO CustomerAddress
                                   (CustomerID, AddressLine, City, State, Pincode)
                                   VALUES
                                   (@CustomerID, @AddressLine, @City, @State, @Pincode)";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@CustomerID", CustomerID));
            ParameterList.Add(new NameValuePair("@AddressLine", AddressLine));
            ParameterList.Add(new NameValuePair("@City", City));
            ParameterList.Add(new NameValuePair("@State", State));
            ParameterList.Add(new NameValuePair("@Pincode", Pincode));

            return dalObj.ExecuteQuery(InsertQuery, ParameterList);
        }

        public DataTable FetchAddresses()
        {
            string SelectQuery = "SELECT * FROM CustomerAddress";

            return dalObj.FetchData(SelectQuery);
        }

        public int UpdateAddress()
        {
            string UpdateQuery = @"UPDATE CustomerAddress
                                   SET CustomerID=@CustomerID,
                                       AddressLine=@AddressLine,
                                       City=@City,
                                       State=@State,
                                       Pincode=@Pincode
                                   WHERE AddressID=@AddressID";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@AddressID", AddressID));
            ParameterList.Add(new NameValuePair("@CustomerID", CustomerID));
            ParameterList.Add(new NameValuePair("@AddressLine", AddressLine));
            ParameterList.Add(new NameValuePair("@City", City));
            ParameterList.Add(new NameValuePair("@State", State));
            ParameterList.Add(new NameValuePair("@Pincode", Pincode));

            return dalObj.ExecuteQuery(UpdateQuery, ParameterList);
        }

        public int DeleteAddress()
        {
            string DeleteQuery = "DELETE FROM CustomerAddress WHERE AddressID=@AddressID";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@AddressID", AddressID));

            return dalObj.ExecuteQuery(DeleteQuery, ParameterList);
        }

        public DataTable FetchCustomerAddressDetails()
        {
            string SelectQuery = @"SELECT
                                    C.CustomerID,
                                    C.CustomerName,
                                    C.Email,
                                    C.PhoneNumber,
                                    A.AddressID,
                                    A.AddressLine,
                                    A.City,
                                    A.State,
                                    A.Pincode
                                   FROM Customer C
                                   INNER JOIN CustomerAddress A
                                   ON C.CustomerID = A.CustomerID";

            return dalObj.FetchData(SelectQuery);
        }

        public DataTable FetchAddressByCustomer(int CustomerID)
        {
            string SelectQuery = "SELECT * FROM CustomerAddress WHERE CustomerID=@CustomerID";

            NameValuePairList ParameterList = new NameValuePairList();

            ParameterList.Add(new NameValuePair("@CustomerID", CustomerID));

            return dalObj.FetchDataWithParameters(SelectQuery, ParameterList);
        }
    }
}