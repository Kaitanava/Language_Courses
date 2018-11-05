using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Courses.Models;
using Language_Courses.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Language_Courses.Controllers
{
    public class CoursesController : Controller
    {
        private readonly Context db;
        private CourseViewModel _courses = new CourseViewModel
        {
            NameOfCourse = ""
        };

        public CoursesController(Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var courseContext = db.Courses.Include(p => p.Employee);
            CoursesViewModel courses = new CoursesViewModel
            {
                Courses = courseContext.ToList(),
                CourseViewModel = _courses
            }; 
            return View(courses);
        }
    }
}