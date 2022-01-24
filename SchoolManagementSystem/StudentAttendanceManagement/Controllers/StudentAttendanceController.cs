using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        [HttpGet]
        public IEnumerable<StudentAttendanceDetail> Get()
        {
            StudentAttendanceDetail attendanceObj1 = new StudentAttendanceDetail();
            StudentAttendanceDetail attendanceObj2 = new StudentAttendanceDetail();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Geetha";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Murthi";
            attendanceObj2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetail> listObj = new List<StudentAttendanceDetail>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
