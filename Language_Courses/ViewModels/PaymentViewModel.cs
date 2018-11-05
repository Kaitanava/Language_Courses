using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.ViewModels
{
    public class PaymentViewModel
    {
        [Display(Name = "Код платежа")]
        public int PaymentId { get; set; }

        [Display(Name = "Название курса")]
        public string NameOfCourse { get; set; }

        [Display(Name = "Фамилия слушателя")]
        public string SurnameListener { get; set; }

        [Display(Name = "Дата платежа")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Сумма оплаты")]
        public decimal Amount { get; set; }

    }
}
