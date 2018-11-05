using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses.ViewModels
{
    public class EmployesViewModel
    {
        public IEnumerable<Employee> Employes { get; set; }
        public EmployeeViewModel EmployeeViewModel { get; set; }
    }
}
