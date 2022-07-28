using Microsoft.AspNetCore.Mvc;
using SchoolOfNothing.Models;
using SchoolOfNothing.repository.Repositories.StudentRepository;

namespace SchoolOfNothing.Controllers
{
    public class StudentController : Controller

    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentRepository.ReadAll();

            return View(students);
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentModel model)
        {
            await _studentRepository.create(model);

            return View();
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _studentRepository.Read(id);

            return View("Create",student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
