using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstDemo.Models;

namespace CodeFirstDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _repository.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Employee employee = _repository.GetEmployee(id);
           if(employee== null)
            { 
                return NotFound("The Given Employee id is not found");
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest(" employee is null");
            }
            _repository.AddEmployee(employee);
            return CreatedAtRoute("Get", new { Id = employee.EmployeeId }, employee);

           //return Ok(employee);
           
        }

        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            if(employee==null)
            {
                return BadRequest(" Employee is null");
            }
            _repository.UpdateEmployee(employee);
            return NoContent();
                 
        }
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteEmployee(id);
            return NoContent();
        }
    }
}
 