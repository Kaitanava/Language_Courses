using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.Models
{
    public class Listener
    {
        public Listener()
        {
            Groups = new List<Group>();
            Payments = new List<Payment>();
        }
        
        [Key]
        [Display(Name = "Код слушателя")]
        public int ListenerID { get; set; }

        [Display(Name = "Имя слушателя")]
        public string NameListener { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "День Рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth  { get; set; }

        [Display(Name = "Адрес")]
        public string Adress  { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }   
        
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
