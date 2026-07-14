using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnderstandingDbContext.Data;

namespace UnderstandingDbContext.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            return View(students);
        }
    }
}