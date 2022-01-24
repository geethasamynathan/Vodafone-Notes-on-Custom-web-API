using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Models
{
    public class DepartmentRepo
    {
      static  List<Department> departments;
        public DepartmentRepo()
        {
            departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "HR", HeadofficeLocation = "Delhi" });
            departments.Add(new Department { Id = 2, Name = "Accounts", HeadofficeLocation = "Bangalore" });
        }
        public List<Department> GetDepartments()
        {
            return departments;
        }
        public void AddNewDepartment(Department dept)
        {
            departments.Add(dept);
        }
    }
}
