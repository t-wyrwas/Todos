using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Domain.Repositories;

namespace RestService.Services 
{
    public class ProjectService : IProjectService
    {
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public List<Project> GetAll()
        {
            return _projectRepository.Get(p => true);
        }

        public Project Get(int id) 
        {
            return _projectRepository.GetById(id);
        }

        private readonly IProjectRepository _projectRepository;
    }
}