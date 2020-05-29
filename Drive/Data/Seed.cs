using Drive.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedData()
        {
            if (!_context.Drivers.Any())
            {
                var rawData = System.IO.File.ReadAllText("Data/AppData.json");
                var datas = JsonConvert.DeserializeObject<List<Driver>>(rawData);
                foreach (var data in datas)
                {
                    _context.Drivers.Add(data);
                }
                _context.SaveChanges();
            }
        }
    }
}
