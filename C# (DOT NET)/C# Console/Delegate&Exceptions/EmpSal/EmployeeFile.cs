using System.IO;

namespace FileHandling
{
    class EmployeeFile
    {
        string path = @"C:\Users\venkata.srikanth\source\repos\Delegate&Exceptions\EmployeeDetails.txt";

        public void CreateFile()
        {
            StreamWriter writer = new StreamWriter(path, false);
            writer.Close();
        }

        public void Save(string data)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(data);
            writer.Close();
        }
    }
}