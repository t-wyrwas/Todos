using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Domain.Repositories;

namespace RestService.Services
{
    public class TaskService : ITaskService
    {
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Task> GetAllInProject(int projectId)
        {
            return _taskRepository.Get(t => t.ProjectId == projectId);
        }

        public Task Get(int id)
        {
            return _taskRepository.GetById(id);
        }

        private readonly ITaskRepository _taskRepository;
    }
}