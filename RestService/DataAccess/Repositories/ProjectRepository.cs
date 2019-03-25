using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ProjectRepository : IProjectRepository
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

        public Project GetById(int id)
        {
            return _projects.FirstOrDefault(p => p.Id == id);
        }

        public List<Project> Get(Func<Project, bool> filter)
        {
            return _projects.Where(filter).ToList();
        }
    }
}