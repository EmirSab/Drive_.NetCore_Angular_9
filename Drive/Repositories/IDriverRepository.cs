using Drive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Repositories
{
    public interface IDriverRepository
    {
        Task<Driver> GetDrivers();
        Task<Driver> GetDriver(int id);
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
