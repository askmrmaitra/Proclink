using Dapper;
using Dapper_Apis.Data;
using Dapper_Apis.Models;

namespace Dapper_Apis.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _context;

        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var query = @"SELECT
                            e.EmployeeId,
                            e.Name,
                            e.Email,
                            e.Salary,
                            d.Name AS DepartmentName,
                            ds.Name AS DesignationName
                          FROM Employees e
                          INNER JOIN Departments d
                                ON e.DeptId = d.DeptId
                          INNER JOIN Designations ds
                                ON e.DesgId = ds.DesgId";

            using var connection = _context.CreateConnection();

            return connection.Query<EmployeeDto>(query);
        }

        public Employee? GetEmployeeById(int id)
        {
            var query = @"SELECT *
                          FROM Employees
                          WHERE EmployeeId = @Id";

            using var connection = _context.CreateConnection();

            return connection.QueryFirstOrDefault<Employee>(query, new { Id = id });
        }

        public int AddEmployee(Employee employee)
        {
            var query = @"INSERT INTO Employees
                          (Name, Email, Salary, DeptId, DesgId)
                          VALUES
                          (@Name, @Email, @Salary, @DeptId, @DesgId)";

            using var connection = _context.CreateConnection();

            return connection.Execute(query, employee);
        }

        public int UpdateEmployee(Employee employee)
        {
            var query = @"UPDATE Employees
                          SET Name = @Name,
                              Email = @Email,
                              Salary = @Salary,
                              DeptId = @DeptId,
                              DesgId = @DesgId
                          WHERE EmployeeId = @EmployeeId";

            using var connection = _context.CreateConnection();

            return connection.Execute(query, employee);
        }

        public int DeleteEmployee(int id)
        {
            var query = @"DELETE FROM Employees
                          WHERE EmployeeId = @Id";

            using var connection = _context.CreateConnection();

            return connection.Execute(query, new { Id = id });
        }
    }
}