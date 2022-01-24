using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("Empl/All")]
        public string GetAllEmployees()
        {
            return "Response from GetAllEmployees Method";
        }
        public string GetEmployeeById()
        {
            return "Response from GetEmployeeById Method";
        }

    }
}
