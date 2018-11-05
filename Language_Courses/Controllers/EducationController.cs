using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Courses.Models;

namespace Language_Courses.Controllers
{
    public class EducationController : Controller
    {
        private Context db;

        public EducationController (Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var education = db.Education.ToList();
            return View(education);
        }
    }
}