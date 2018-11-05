using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.Models
{
    public class Group
    {
        [Key]
        [Display(Name = "Код группы")]
        public int GroupId { get; set; }

        [Display(Name = "Код курса")]
        public int? CourseId { get; set; }

        [Display(Name = "Код слушателя")]
        public int? ListenerId { get; set; }

        public Course Course { get; set; }
        public Listener Listener { get; set; }
    }
}
