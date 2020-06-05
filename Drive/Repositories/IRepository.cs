using Abp.Domain.Entities;
using Drive.Models;
using EO.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Add(T entity);
        Task<List<T>> GetAll();
        Task<T> Update(T entity);
        Task<T> Delete(int id);

    }
}
