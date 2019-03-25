using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace RestService.Services 
{
    public interface IProjectService
    {
        List<Project> GetAll();
        Project Get(int id);
    }
}