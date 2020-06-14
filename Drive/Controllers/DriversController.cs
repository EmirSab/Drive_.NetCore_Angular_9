using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Drive.Data;
using Drive.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Drive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverRepository _repo;
        private readonly IMapper _mapper;

        public DriversController(IDriverRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<List<Driver>> GetDrivers()
        {
            try
            {
                var drivers = await _repo.GetDrivers();
                return drivers;

            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem", ex);
            }
        }

        [HttpGet("{id}", Name = "GetDriver")]
        public async Task<IActionResult> GetDriver(int id)
        {
            try
            {
                var driver = await _repo.GetDriverById(id);
                return Ok(driver);
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem", ex);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddDriver(Driver driver)
        {
            try
            {
                await _repo.AddDriver(driver);
                return CreatedAtAction("GetDriver", new {id = driver.Id }, driver);
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem", ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDriver(int id, [FromBody] Driver driver)
        {
            try
            {
                if (id != driver.Id)
                {
                    return BadRequest();
                }
                else
                {
                    await _repo.UpdateDriver(driver);
                    return NoContent();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("There was a problem", ex);
            }

        }

    }
}
