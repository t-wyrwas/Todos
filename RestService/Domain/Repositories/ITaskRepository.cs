using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Models
{
    public interface ITaskRepository : IRepository<Task>
    {
    }
}