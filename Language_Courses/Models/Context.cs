using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Language_Courses.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        { }

        public DbSet<Education> Education { get; set; }
        public DbSet<Employee> Employes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Listener> Listeners { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
