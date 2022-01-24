using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTSecurityDemo.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTSecurityDemo.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IJWTAuth jWTAuth;

        private readonly List<Member> memberList = new List<Member>()
        { new Member{ Id=1,Name="Ajay"},
            new Member{Id=2,Name="Raja"},
            new Member{Id=3,Name="Sudhan"}
        };

        public EmployeesController(IJWTAuth auth)
        {
            jWTAuth = auth;
        }
        // GET: api/<EmployeesController>
        [Authorize]
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return memberList;
        }
      
        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return memberList.Find(x => x.Id == id);
        }
     
        [AllowAnonymous]
        // POST api/<EmployeesController>
        [HttpPost("authentication")]
        public IActionResult Post([FromBody]UserCredential usercredential)
        {
            var token = jWTAuth.Authentication(usercredential.Username, usercredential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

