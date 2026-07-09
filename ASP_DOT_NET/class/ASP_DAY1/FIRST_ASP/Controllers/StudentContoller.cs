using Microsoft.AspNetCore.Mvc;

namespace FIRST_ASP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentsOfList()
        {
            return View();
        }
    }
}