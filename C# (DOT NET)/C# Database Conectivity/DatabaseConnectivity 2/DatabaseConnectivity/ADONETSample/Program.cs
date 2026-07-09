using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace ADONETSample
{
    internal class Program
    {

        static Student student = new Student();
        private static BSCustomerBusinessLogic bllObj = new BSCustomerBusinessLogic();

        static void Main(string[] args)
        {
            #region Student Table
            //Console.Write("Name? :   ");
            //string sName = Console.ReadLine();

            //Console.Write("Phone? :   ");
            //string sPhone = Console.ReadLine();

            //Console.Write("Email? :   ");
            //string sEmail = Console.ReadLine();


            //int insertStatus = student.SaveData(sName, sPhone, sEmail);

            //if (insertStatus == 1)
            //{
            //    Console.WriteLine("Data Saved...");
            //    Console.WriteLine("The List of Students we have...\n");
            //    DisplayStudents();
            //} 
            #endregion

            #region BSCustomer
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

            int Status = bllObj.SaveCustomer(newCust);

            if (Status == 0)
            {
                Console.WriteLine("Data Saved...");
            }
            else
            {
                Console.WriteLine("Something Went Wrong...");
            }
            #endregion
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();

        }
        public static void DisplayStudents()
        {
            DataTable dtStudent = student.FetchStudent();
            foreach (DataRow dr in dtStudent.Rows)
            {
                Console.WriteLine($"Student ID: {dr.ItemArray[0].ToString()}; Student Name:{dr.ItemArray[1].ToString()} and Phone:{dr.ItemArray[2].ToString()}");
            }
        }

    }
}
