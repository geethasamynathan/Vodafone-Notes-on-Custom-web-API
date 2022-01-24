using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CodeFirstdemo3.Models
{
    public class DepartmentEmployeeContext:DbContext
    {
        public DepartmentEmployeeContext(DbContextOptions<DepartmentEmployeeContext> options)
            : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
