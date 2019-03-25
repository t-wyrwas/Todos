using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.Models;
using Domain.Enums;

namespace DataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {
		//todo mock
		private readonly List<Task> _tasks = new List<Task> { 
            new Task {
                Id = 0,
                Name = "buy bread",
                Details = "just buy it",
                ProjectId = 2,
                TaskStatus = TaskStatus.Todo
            },
            new Task {
                Id = 1,
                Name = "Do laundry",
                Details = "First, buy a washing machine",
                ProjectId = 2,
                TaskStatus = TaskStatus.Doing
            },
            new Task {
                Id = 2,
                Name = "Buy a car",
                Details = "First, earn some money",
                ProjectId = 2,
                TaskStatus = TaskStatus.Done
            },
            new Task {
                Id = 3,
                Name = "Get a promostion",
                Details = "Drink more coffe",
                ProjectId = 0,
                TaskStatus = TaskStatus.Doing
            },
            new Task {
                Id = 4,
                Name = "End this very important task",
                Details = "talk to the client to get some requirements",
                ProjectId = 0,
                TaskStatus = TaskStatus.Doing
            },
            // new Task {
            //     Id = 2,
            //     Name = "Day to day",
            //     Details = "",
            //     ProjectId = ,
            //     TaskStatus = 
            // },
            // new Task {
            //     Id = 0,
            //     Name = "Work",
            //     Details = "",
            //     ProjectId = ,
            //     TaskStatus = 
            // }
            // new Task {
            //     Id = 1,
            //     Name = "University",
            //     Details = "",
            //     ProjectId = ,
            //     TaskStatus = 
            // },
            // new Task {
            //     Id = 2,
            //     Name = "Day to day",
            //     Details = "",
            //     ProjectId = ,
            //     TaskStatus = 
            // },
          
        };

        public Task GetById(int id)
        {
            return _tasks.FirstOrDefault(p => p.Id == id);
        }

        public List<Task> Get(Func<Task, bool> filter)
        {
            return _tasks.Where(filter).ToList();
        }
    }
}