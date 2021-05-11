using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/Student
        [HttpGet("")]
        public ActionResult<List<Student>> Get()
        {
            return Ok(DB.studentsList);
        }
        // GET: api/Student/5
        [HttpGet("{id}/GetById")]
        public ActionResult<Student> GetById(int id)
        {
            return Ok(DB.studentsList.FirstOrDefault(x => x.id == id));
        }
        [HttpGet("{str}/SearchName")]
        public List<Student> SearchName(string str)
        {
            if (str == null)
                return DB.studentsList;
            return DB.studentsList.Where(x => x.firstName.Contains(str) || x.lastName.Contains(str)).ToList();
        }
        [HttpGet("{str}/SearchId")]
        public List<Student> SearchId(string str)
        {
            if (str == null)
                return DB.studentsList;
            return DB.studentsList.Where(x => x.StudentId.Contains(str)).ToList();
        }

    }
}
