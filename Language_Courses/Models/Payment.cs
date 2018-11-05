    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.Models
{
    public class Payment
    {
        
        [Key]
        [Display(Name = "Код платежа")]
        public int PaymentId { get; set; }

        [Display(Name = "Код курса")]
        public int? CourseId { get; set; }

        [Display(Name = "Код слушателя")]
        public int? ListenerId { get; set; }

        [Display(Name = "Дата Оплаты")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Сумма Оплаты")]
        public decimal Amount { get; set; }

        public Course Course { get; set; }
        public Listener Listener { get; set; }
    }
}
