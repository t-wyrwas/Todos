using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
    }
}