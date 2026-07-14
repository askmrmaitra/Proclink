namespace Dapper_Apis.Models
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public string DesignationName { get; set; } = string.Empty;
    }
}