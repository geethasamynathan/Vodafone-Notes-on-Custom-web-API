using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstDemo.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(new Employee
        //    {
        //        EmployeeId=13,
        //        FirstName = "yash",
        //        LastName = "sam",
        //        DateOfBirth = new DateTime(1987, 05, 30),
        //        Email = "yash@gmail.com",
        //        Phonenumber = "950003433"
        //    }, new Employee
        //    {
        //        EmployeeId = 12,
        //        FirstName = "yash",
        //        LastName = "sam",
        //        DateOfBirth = new DateTime(1987, 05, 30),
        //        Email = "yash@gmail.com",
        //        Phonenumber = "950003433"
        //    });
        //}
    }
}
