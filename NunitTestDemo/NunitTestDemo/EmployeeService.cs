using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NunitTestDemo
{
    public class EmployeeService : IEmployeeService
    {
        public readonly EmployeeDbContext context;
        public EmployeeService(EmployeeDbContext dbContext)
        {
            context = dbContext;
        }
       

        public  Employee GetEmployeeById(int id)
        {
            var emp = context.Employees.FirstOrDefault(e => e.Id == id);
            return emp;
        }
    }
}
