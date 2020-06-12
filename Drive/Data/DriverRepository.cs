using Drive.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Data
{
    public class DriverRepository : IDriverRepository
    {
        private readonly DataContext _context;

        public DriverRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Driver> GetDriverById(int id)
        {
            var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.Id == id);
            return  driver;
        }

        public async Task<List<Driver>> GetDrivers()
        {
            var drivers = _context.Drivers.ToListAsync();
            return await drivers;
        }

        public async  Task<Driver> UpdateDriver(Driver driver)
        {
            _context.Entry(driver).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return driver;
        }
    }
}
