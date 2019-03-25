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
    public class TasksController : ControllerBase
    {
		public TasksController(ITaskService taskService)
		{
            _taskService = taskService;
		}

        // GET api/tasks/5
        [HttpGet("{id}")]
        public ActionResult<Task> Get(int id)
        {
			return _taskService.Get(id);
        }

		private readonly ITaskService _taskService;
    }
}
