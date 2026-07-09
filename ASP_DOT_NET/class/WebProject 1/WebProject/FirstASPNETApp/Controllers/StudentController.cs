using FirstASPNETApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNETApp.Controllers
{
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            List<string> studentNames =new List<string>{ "Aman","Vamsi","Abdul","Neha"};
            
           return View(studentNames);
        }

        public IActionResult Employee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Vishesh";
            employee.Phone = "9870098700";

            
            Employee employee1 = new Employee();
            employee1.ID = 2;
            employee1.Name = "Harish";
            employee1.Phone = "9840098400";

            

            List<Employee> employees = new List<Employee>();
            
            employees.Add(employee);
            employees.Add(employee1);
            return View(employees);
        }
        public IActionResult ListOfStudents()
        {
           
            return View();
        }
    }
}
