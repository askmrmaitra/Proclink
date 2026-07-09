using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace ADONETSample
{
    internal class Program
    {
        static SqlConnection Connection;
        public static SqlConnection GetConenction()
        {
            string ConnectionString = "Server=localhost\\SQLEXPRESS;DataBase=BikeStore;TrustServerCertificate=true;Encrypt=True; Integrated Security=SSPI;Persist Security Info=False;";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }
        static void Main(string[] args)
        {
            Console.Write("Name? :   ");
            string sName = Console.ReadLine();
            
            Console.Write("Phone? :   ");
            string sPhone = Console.ReadLine();
            
            Console.Write("Email? :   ");
            string sEmail = Console.ReadLine();
            

            int insertStatus = SaveData(sName, sPhone, sEmail);

            if (insertStatus == 1)
            {
                Console.WriteLine("Data Saved...");
                Console.WriteLine("The List of Students we have...\n");
                DisplayStudents();
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();

        }

        public static int SaveData(string Name,string Phone,string Email)
        {
            string InsertQuery = "INSERT INTO [dbo].[student]([studentName],[studentPhone],[studentEmail]) VALUES(@studentName,@studentPhone,@studentEmail)";
            SqlCommand cmdObject = new SqlCommand(InsertQuery,GetConenction());

            //Set Values in Params...
            cmdObject.Parameters.AddWithValue("@studentName", Name);
            cmdObject.Parameters.AddWithValue("@studentPhone", Phone);
            cmdObject.Parameters.AddWithValue("@studentEmail", Email);

            int Status = cmdObject.ExecuteNonQuery();
            CloseConnection();
            return Status;

        }

        public static DataTable FetchStudent()
        {
            string Select = "Select * from [dbo].[student]";

            SqlDataAdapter adpStudent = new SqlDataAdapter(Select,GetConenction());
            DataTable dt = new DataTable();
            adpStudent.Fill(dt);
            CloseConnection();
            return dt;
        }

        public static void DisplayStudents()
        {
            DataTable dtStudent = FetchStudent();
            foreach(DataRow dr in dtStudent.Rows)
            {
                Console.WriteLine($"Student ID: {dr.ItemArray[0] }; Student Name:{dr.ItemArray[1].ToString()} and Phone:{dr.ItemArray[2].ToString()}");
            }
        }
    }
}
