using Dapper_Apis.Models;
using Dapper_Apis.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }

        // GET: api/Employee/1
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _employeeRepository.AddEmployee(employee);

            if (result > 0)
            {
                return Ok("Employee added successfully.");
            }

            return BadRequest("Failed to add employee.");
        }

        // PUT: api/Employee
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var result = _employeeRepository.UpdateEmployee(employee);

            if (result > 0)
            {
                return Ok("Employee updated successfully.");
            }

            return NotFound("Employee not found.");
        }

        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeRepository.DeleteEmployee(id);

            if (result > 0)
            {
                return Ok("Employee deleted successfully.");
            }

            return NotFound("Employee not found.");
        }
    }
}