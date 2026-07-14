using Dapper_Apis.Models;

namespace Dapper_Apis.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDto> GetAllEmployees();

        Employee? GetEmployeeById(int id);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int DeleteEmployee(int id);
    }
}