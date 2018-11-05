using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses.ViewModels
{
    public class GroupViewModel
    {
        [Display(Name = "Код группы")]
        public int GroupId { get; set; }

        [Display(Name = "Название курса")]
        public string NameOfCourse { get; set; }

        [Display(Name = "Фамилия слушателя")]
        public string SurnameListener { get; set; }

        
    }
}
