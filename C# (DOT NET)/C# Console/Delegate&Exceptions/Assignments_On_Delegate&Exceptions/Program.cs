using exp;
using Stu;
using StuM;
using System;

namespace FirstQes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            Console.Write("Enter Number of Students : ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter Student Details");
                Console.Write("Roll No : ");
                int rollNo = int.Parse(Console.ReadLine());

                Console.Write("Name : ");
                string name = Console.ReadLine();
                int marks;
                while (true)
                {
                    try
                    {
                        Console.Write("Marks : ");
                        marks = int.Parse(Console.ReadLine());

                        if (marks < 0 || marks > 100)
                        {
                            throw new InvalidMarksException("Marks should be between 0 and 100.");
                        }

                        break;
                    }
                    catch (InvalidMarksException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                students[i] = new Student(rollNo, name, marks);
            }

            Console.WriteLine("\nStudent Results\n");

            foreach (Student student in students)
            {
                Console.WriteLine("Roll No : " + student.RollNo);
                Console.WriteLine("Name : " + student.Name);
                Console.WriteLine("Marks : " + student.Marks);
                Console.WriteLine("Result : " + manager.Evaluate(student));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}