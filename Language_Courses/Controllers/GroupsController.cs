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
    public class GroupsController : Controller
    {
        private readonly Context db;
        private GroupViewModel _groups = new GroupViewModel
        {
            NameOfCourse = "",
            SurnameListener = ""
        };

        public GroupsController(Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var groupContext = db.Groups.Include(p => p.Listener).Include(p => p.Course);
            GroupsViewModel groups = new GroupsViewModel
            {
                Groups = groupContext.ToList(),
                GroupViewModel = _groups
            };
            
            return View(groups);
        }
    }
}