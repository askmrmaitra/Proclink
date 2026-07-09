using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static string filePath = "D:\\Training\\Proclink\\Codebase\\C#\\Basic CS\\Files\\Test.txt";
        static void Main(string[] args)
        {
            //CreateFile(filePath);
            //FileDetails(filePath);

            //WriteFile(filePath, "India is Great...");

            //Console.WriteLine(ReadFile(filePath));

            //AppendFile(filePath, "I love my Country...");
            //Console.WriteLine(ReadFile(filePath));
            DeleteFile(filePath);
            //Console.WriteLine("File Removed...");
            Console.WriteLine("Enter to Exit");
            Console.ReadKey();
        }

        static void FileDetails(string FileWithPath)
        {
            FileInfo fileInformation = new FileInfo(FileWithPath);
            long fileSize = fileInformation.Length;
            Console.WriteLine("This File has got a length of: " + fileSize);
            Console.WriteLine("This file created on: " + fileInformation.CreationTime.ToString());
        }
        static void CreateFile(string FileWithPath)
        {
            File.Create(FileWithPath);
        }
        static string ReadFile(string FileWithPath)
        {
            ////Read the Data Available in the File 
            using (StreamReader sr = new StreamReader(FileWithPath))
            {
                string dataValues = sr.ReadToEnd();
                return dataValues;
            }
        }
        static void WriteFile(string FileWithPath, string Content)
        {
            ////Write some data on the file 
            //// Use of using Statement 
            using (StreamWriter sw = new StreamWriter(FileWithPath))
            {
                sw.WriteLine(Content);
            }
        }
        static void AppendFile(string FileWithPath,string Content)
        {
            //Adding some more text on to the file 
            using (StreamWriter sw = new StreamWriter(FileWithPath, true))
            {
                //Now Append will work
                sw.WriteLine(Content);
            }
            Console.WriteLine("Data got Added...");

        }
        static void DeleteFile(string FileWithPath) {

            if (File.Exists(FileWithPath))
            {
                File.Delete(FileWithPath);
            }
            else
            {
                throw new FileNotFoundException("Specified File does not exists");
            }
        }


    }

    public class TestClass : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
