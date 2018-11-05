using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses.ViewModels
{
    public class PaymentsViewModel
    {
        public IEnumerable<Payment> Payments;
        public PaymentViewModel PaymentViewModel;

    }
}
