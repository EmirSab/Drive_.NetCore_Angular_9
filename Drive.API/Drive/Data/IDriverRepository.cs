﻿using Drive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Data
{
    public interface IDriverRepository
    {
        //Task<List<Driver>> GetDrivers();
        IEnumerable<Driver> GetAllDrivers();
        Task<Driver> GetDriverById(int id);
        Task<Driver> UpdateDriver(Driver driver);
        Task<Driver> AddDriver(Driver driver);
        Task<Driver> Delete(int id);

    }
}
