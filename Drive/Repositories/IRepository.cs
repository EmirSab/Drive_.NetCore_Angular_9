using Abp.Domain.Entities;
using Drive.Models;
using EO.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Repositories
{
    public interface IRepository

    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<List<Driver>> GetAll();
    }
}
