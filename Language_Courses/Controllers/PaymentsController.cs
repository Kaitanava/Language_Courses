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
    public class PaymentsController : Controller
    {
        private readonly Context db;
        private PaymentViewModel _payment = new PaymentViewModel
        {

            NameOfCourse = "",
            SurnameListener = ""

        };

        public PaymentsController(Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var paymentContext = db.Payments.Include(p => p.Course).Include(p => p.Listener);
            PaymentsViewModel payments = new PaymentsViewModel
            {
                Payments = paymentContext.ToList(),
                PaymentViewModel = _payment
            };
            return View(payments);

        }
    }
}
    
   