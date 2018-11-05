using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Courses.Models
{
    public class Education
    {
        [Key]
        [Display(Name = "Код образования")]
        public int EducationID { get; set; }

        [Display(Name = "Ступень образования")]
        public string Stage { get; set; }

        public virtual ICollection<Employee> Employes { get; set; }

        public Education()
        {
            Employes = new List<Employee>();
        }
    }
}
