using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.ViewModels
{
    public class CourseViewModel
    {
        [Display(Name = "Код курса")]
        public int CourseID { get; set; }

        [Display(Name = "Фамилия руководящего сотрудника")]
        public string Surname{ get; set; }

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
    }
}
