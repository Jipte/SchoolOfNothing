using Microsoft.AspNetCore.Mvc;
using SchoolOfNothing.Models;

namespace SchoolOfNothing.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClassroomModel model)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
