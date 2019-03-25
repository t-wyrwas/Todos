using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> Get(Func<T, bool> filter);
    }
}