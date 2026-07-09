using Microsoft.AspNetCore.Mvc;

namespace FirstASPNETApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListOfStudents()
        {
            return View();
        }
    }
}
