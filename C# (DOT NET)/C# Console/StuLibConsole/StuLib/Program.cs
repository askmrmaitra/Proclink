using System;
using System.Collections.Generic;
using StudentLib;

namespace StuLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                s.GetData();
                students.Add(s);
            }

            Console.WriteLine("\nStudent Details");

            foreach (Student s in students)
            {
                s.Display();
            }
        }
    }
}