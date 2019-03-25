using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> Get(Func<T, bool> filter);
    }
}