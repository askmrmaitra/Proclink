using Emp;
using System;

namespace EmpM
{
    class EmployeeManager
    {
        Func<double, double, double> calculateSalary = (basic, allowance) => basic + allowance;

        public double CalculateSalary(Employee employee)
        {
            return calculateSalary(employee.BasicSalary, employee.Allowance);
        }
    }
}