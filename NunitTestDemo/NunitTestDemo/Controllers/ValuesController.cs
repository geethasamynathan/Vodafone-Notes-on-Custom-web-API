using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NunitTestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public ValuesController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public  Employee Getemployees(int id)
        {
            return   _service.GetEmployeeById(id);
        }

    }
}
