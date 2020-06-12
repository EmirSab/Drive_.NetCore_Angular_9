using Drive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Data
{
    public interface IDriverRepository
    {
        Task<List<Driver>> GetDrivers();
        Task<Driver> GetDriverById(int id);
        Task<Driver> UpdateDriver(Driver driver);

    }
}
