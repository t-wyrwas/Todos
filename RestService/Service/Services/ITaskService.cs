using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace RestService.Services 
{
    public interface ITaskService
    {
        List<Task> GetAllInProject(int projectId);
        Task Get(int id);
    }
}