using System;
using System.Collections.Generic;
using System.Linq;
using RestService.Model;

namespace RestService.Services 
{
    public class ProjectService : IProjectService
    {
		//todo mock
		private readonly List<Project> _projects = new List<Project> { 
            new Project {
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

        public List<Project> GetAll()
        {
            return _projects;
        }

        public Project Get(int id) 
        {
            return _projects.FirstOrDefault(p => p.Id == id);
        }
    }
}