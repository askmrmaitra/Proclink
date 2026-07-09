using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace ADONETSample
{
    internal class Program
    {

       static Student student = new Student();
        static void Main(string[] args)
        {
            Console.Write("Name? :   ");
            string sName = Console.ReadLine();
            
            Console.Write("Phone? :   ");
            string sPhone = Console.ReadLine();
            
            Console.Write("Email? :   ");
            string sEmail = Console.ReadLine();
            

            int insertStatus = student.SaveData(sName, sPhone, sEmail);

            if (insertStatus == 1)
            {
                Console.WriteLine("Data Saved...");
                Console.WriteLine("The List of Students we have...\n");
                DisplayStudents();
            }
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
