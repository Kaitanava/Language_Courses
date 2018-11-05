using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses.ViewModels
{
    public class GroupsViewModel
    {
        public IEnumerable<Group> Groups { get; set; }
        public GroupViewModel GroupViewModel { get; set; }
    }
}
