using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            Employee emp = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            _context.Employees.Remove(emp);
            _context.SaveChanges();
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }
        public void UpdateEmployee(Employee employee)
        {
            
            _context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           
            _context.SaveChanges();
        }
    }
}
