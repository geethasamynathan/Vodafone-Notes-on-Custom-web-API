using DemoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
		
		static List<Employee> EmployeeList = new List<Employee>();

		public EmployeeController()
		{
			Employee emp1 = new Employee() { EmployeeId = 101, Name = "Fransy", Location = "Bangalore" };
			Employee emp2 = new Employee() { EmployeeId = 102, Name = "Ajay", Location = "Pune" };
			Employee emp3 = new Employee() { EmployeeId = 103, Name = "Sudharshan", Location = "Mumbai" };
			EmployeeList.Add(emp1);
			EmployeeList.Add(emp2);
			EmployeeList.Add(emp3);
		}
		[HttpGet]
		public List<Employee> GetEmployees()
		{
			return EmployeeList;
		}

		[HttpPost]
		public Employee Post(Employee employee)
        {
			EmployeeList.Add(employee);
			return employee;
        }
	}
}
