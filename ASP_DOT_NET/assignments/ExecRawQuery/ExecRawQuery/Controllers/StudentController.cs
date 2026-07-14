using ExecRawQuery.Data;
using ExecRawQuery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExecRawQuery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // SELECT
        [HttpGet]
        public List<Student> GetStudents()
        {
            return _context.Students
                           .FromSql($"SELECT * FROM Student")
                           .ToList();
        }

        // SELECT
        [HttpGet("department/{department}")]
        public List<Student> GetStudentsByDepartment(string department)
        {
            return _context.Students
                           .FromSql($"SELECT * FROM Student WHERE Department = {department}")
                           .ToList();
        }

        // SELECT
        [HttpGet("{id}")]
        public Student? GetStudentById(int id)
        {
            return _context.Students
                           .FromSql($"SELECT * FROM Student WHERE Id = {id}")
                           .AsEnumerable()
                           .FirstOrDefault();
        }

        // INSERT
        [HttpPost("add")]
        public string AddStudent(Student student)
        {
            int rows = _context.Database.ExecuteSql($@"
                INSERT INTO Student(Name, Age, Department)
                VALUES ({student.Name}, {student.Age}, {student.Department})");

            return $"{rows} row(s) inserted.";
        }

        // UPDATE
        [HttpPut("update-age/{id}/{age}")]
        public string UpdateAge(int id, int age)
        {
            int rows = _context.Database.ExecuteSql(
                $"UPDATE Student SET Age = {age} WHERE Id = {id}");

            return $"{rows} row(s) updated.";
        }

        // DELETE
        [HttpDelete("{id}")]
        public string DeleteStudent(int id)
        {
            int rows = _context.Database.ExecuteSql(
                $"DELETE FROM Student WHERE Id = {id}");

            return $"{rows} row(s) deleted.";
        }
    }
}