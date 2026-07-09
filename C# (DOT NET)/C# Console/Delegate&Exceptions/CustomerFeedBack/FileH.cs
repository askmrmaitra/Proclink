using Exp;
using System;
using System.IO;

namespace FileHandling
{
    class FeedbackFile
    {
        string path = @"C:\Users\venkata.srikanth\source\repos\Delegate&Exceptions\PositiveFeedback.txt";

        public void CreateFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, false);
                writer.Close();
            }
            catch (IOException)
            {
                throw new FileOperationException("Unable to create the feedback file.");
            }
        }

        public void Save(string data)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, true);
                writer.WriteLine(data);
                writer.Close();
            }
            catch (IOException)
            {
                throw new FileOperationException("Unable to save positive feedback.");
            }
        }
    }
}