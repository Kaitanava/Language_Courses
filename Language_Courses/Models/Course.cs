using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "Код курса")]
        public int CourseID { get; set; }

        [Display(Name = "Код сотрудника")]
        public int EmployeeID { get; set; }

        [Display(Name = "Название курса")]
        public string NameOfCourse { get; set; }

        [Display(Name = "Программа обучения")]
        public string TrainingProgram { get; set; }

        [Display(Name = "Описание курса")]
        public string DescriptionOfCourses { get; set; }

        [Display(Name = "Интенсивность занятий")]
        public string IntensityOfTraining { get; set; }

        [Display(Name = "Количество мест")]
        public int NumberOfPlaces { get; set; }

        [Display(Name = "Количество часов")]
        public int Hourse { get; set; }

        [Display(Name = "Стоимость обучения")]
        public decimal Cost { get; set; }

        public Employee Employee { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

        public Course()
        {
            Groups = new List<Group>();
            Payments = new List<Payment>();
        }
    }
}
