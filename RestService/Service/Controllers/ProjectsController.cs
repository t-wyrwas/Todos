using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Task = Domain.Models.Task;
using RestService.Services;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
		public ProjectsController(IProjectService projectService, ITaskService taskService)
		{
			_projectService = projectService;
            _taskService = taskService;
		}

        // GET api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
			return _projectService.GetAll();
        }

        // GET api/projects/5
        [Route("[[id]]")]
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
			return _projectService.Get(id);
        }

        // GET api/projects/5/tasks
        [Route("[[id]]/tasks")]
        [HttpGet("{id}/tasks")]
        public ActionResult<IEnumerable<Task>> GetTasks(int id)
        {
			return _taskService.GetAllInProject(id);
        }

		private readonly IProjectService _projectService;
		private readonly ITaskService _taskService;
    }
}
