using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Courses.Models;
using Microsoft.EntityFrameworkCore;
using Language_Courses.ViewModels;

namespace Language_Courses.Controllers
{
    public class EmployesController : Controller
    {

        private Context db;
        private EmployeeViewModel _employes = new EmployeeViewModel
        {
            Stage = ""
        };

    public EmployesController(Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var employesContext = db.Employes.Include(p => p.Education);
            EmployesViewModel employes = new EmployesViewModel
            {
                Employes = employesContext.ToList(),
                EmployeeViewModel = _employes
            };
            return View(employes);
        }
    }
}