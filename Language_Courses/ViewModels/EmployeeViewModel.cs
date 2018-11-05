using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Код сотрудника")]
        public int EmployeeID { get; set; }

        [Display(Name = "Имя сотрудника")]
        public string NameEmployee { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Display(Name = "Ступень образования")]
        public string Stage { get; set; }
    }
}
