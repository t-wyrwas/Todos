using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestService.Model;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
		//todo mock
		private readonly List<Project> _projects = new List<Project> { new Project {
                Id = 0,
                Name = "Work",
            },
            new Project {
                Id = 1,
                Name = "University",
            },
            new Project {
                Id = 2,
                Name = "Day to day",
            },
            };

        // GET api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
			return _projects;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            return _projects.FirstOrDefault(p => p.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
