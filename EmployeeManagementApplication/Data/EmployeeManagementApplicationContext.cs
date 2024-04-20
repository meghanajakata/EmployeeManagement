using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementApplication.Models;

namespace EmployeeManagementApplication.Data
{
    public class EmployeeManagementApplicationContext : DbContext
    {
        public EmployeeManagementApplicationContext (DbContextOptions<EmployeeManagementApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementApplication.Models.Employee> Employee { get; set; } = default!;
        public DbSet<EmployeeManagementApplication.Models.Skill> Skill { get; set; }
        public DbSet<EmployeeManagementApplication.Models.EmployeeSkill> EmployeeSkill { get; set; }
    }
}
