using System;
using System.Collections.Generic;
using System.Text;

namespace LINQToObject
{
    namespace LINQToObjectDemo
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public string Designation { get; set; }
            public decimal Salary { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }

        public static class EmployeeRepository
        {
            public static List<Employee> GetEmployees()
            {
                return new List<Employee>
                    {
                        new Employee { EmployeeId = 101, Name = "Amit",    Department = "IT",      Designation = "Developer", Salary = 65000, Age = 25, City = "Kolkata" },
                        new Employee { EmployeeId = 102, Name = "Priya",   Department = "HR",      Designation = "HR Executive", Salary = 45000, Age = 28, City = "Delhi" },
                        new Employee { EmployeeId = 103, Name = "Rahul",   Department = "IT",      Designation = "Senior Developer", Salary = 85000, Age = 32, City = "Bangalore" },
                        new Employee { EmployeeId = 104, Name = "Sneha",   Department = "Finance", Designation = "Accountant", Salary = 55000, Age = 29, City = "Mumbai" },
                        new Employee { EmployeeId = 105, Name = "Arjun",   Department = "IT",      Designation = "Team Lead", Salary = 95000, Age = 35, City = "Hyderabad" },
                        new Employee { EmployeeId = 106, Name = "Neha",    Department = "HR",      Designation = "Manager", Salary = 75000, Age = 38, City = "Pune" },
                        new Employee { EmployeeId = 107, Name = "Rohit",   Department = "Finance", Designation = "Analyst", Salary = 60000, Age = 30, City = "Chennai" },
                        new Employee { EmployeeId = 108, Name = "Ananya",  Department = "IT",      Designation = "Developer", Salary = 70000, Age = 26, City = "Kolkata" },
                        new Employee { EmployeeId = 109, Name = "Vikram",  Department = "Sales",   Designation = "Sales Executive", Salary = 50000, Age = 27, City = "Delhi" },
                        new Employee { EmployeeId = 110, Name = "Meera",   Department = "Sales",   Designation = "Sales Manager", Salary = 90000, Age = 36, City = "Mumbai" }
                    };
            }
        }
    }
}
