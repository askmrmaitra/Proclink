namespace Dapper_Apis.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public int DeptId { get; set; }

        public int DesgId { get; set; }
    }
}