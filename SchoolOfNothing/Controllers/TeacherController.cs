﻿using Microsoft.AspNetCore.Mvc;
using SchoolOfNothing.Models;

namespace SchoolOfNothing.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TeacherModel model)
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
