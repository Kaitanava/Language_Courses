using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public CourseViewModel CourseViewModel { get; set; }
    }
}
