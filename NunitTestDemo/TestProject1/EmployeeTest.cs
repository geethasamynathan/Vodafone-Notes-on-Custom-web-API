using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitTestDemo;
using Moq;
using Xunit;
using NunitTestDemo.Controllers;

namespace TestProject1
{
   public class EmployeeTest
    {
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        List<Employee> emps = new List<Employee>();
        [Fact]
        public  void Getemployees()
        {
          
            var empinfo = new Employee()
            {
                Id = 1,
                Name = "Geetha",
                Gender = "female"
            };

            mock.Setup(p => p.GetEmployeeById(1)).Returns(empinfo);
            ValuesController emp = new ValuesController(mock.Object);
            var result =  emp.Getemployees(1);
            Assert.True(empinfo.Equals(result));

        }
    }
}
