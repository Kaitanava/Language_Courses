using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Courses.Models;

namespace Language_Courses.Controllers
{
    public class ListenersController : Controller
    {
        private Context db;

        public ListenersController(Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var listeners = db.Listeners.ToList();
            return View(listeners);
        }
    }
}