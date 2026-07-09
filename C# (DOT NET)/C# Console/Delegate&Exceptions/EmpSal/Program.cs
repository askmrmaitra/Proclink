using Emp;
using EmpM;
using FileHandling;
using System;
using System.IO;

namespace SecondQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            EmployeeFile file = new EmployeeFile();

            file.CreateFile();

            Console.Write("Enter Number of Employees : ");
            int n = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();

                Console.WriteLine("\nEnter Employee " + (i + 1) + " Details");

                Console.Write("Employee Id : ");
                employee.EmployeeId = int.Parse(Console.ReadLine());

                Console.Write("Name : ");
                employee.Name = Console.ReadLine();

                Console.Write("Basic Salary : ");
                employee.BasicSalary = double.Parse(Console.ReadLine());

                Console.Write("Allowance : ");
                employee.Allowance = double.Parse(Console.ReadLine());

                employees[i] = employee;
            }

            try
            {
                foreach (Employee employee in employees)
                {
                    double netSalary = manager.CalculateSalary(employee);

                    Console.WriteLine();
                    Console.WriteLine("Employee Id : " + employee.EmployeeId);
                    Console.WriteLine("Name : " + employee.Name);
                    Console.WriteLine("Basic Salary : " + employee.BasicSalary);
                    Console.WriteLine("Allowance : " + employee.Allowance);
                    Console.WriteLine("Net Salary : " + netSalary);

                    string data = "Employee Id : " + employee.EmployeeId + "\n" +
                                  "Name : " + employee.Name + "\n" +
                                  "Basic Salary : " + employee.BasicSalary + "\n" +
                                  "Allowance : " + employee.Allowance + "\n" +
                                  "Net Salary : " + netSalary + "\n\n";

                    file.Save(data);
                }

                Console.WriteLine("\nEmployee details saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}