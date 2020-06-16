using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Drive.Data;
using Drive.Dtos;
using Drive.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Drive.Controllers
{
    /*
     https://medium.com/net-core/repository-pattern-implementation-in-asp-net-core-21e01c6664d7
    https://code-maze.com/net-core-web-development-part6/
     */
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
        public async Task<IActionResult> UpdateDriver(int id, [FromBody]Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var userFromRepo = await _repo.GetDriverById(id);
                if (userFromRepo == null)
                {
                    return NotFound();
                }

                _mapper.Map(driver, userFromRepo);
                await _repo.UpdateDriver(userFromRepo);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var driver = await _repo.Delete(id);
                if (driver == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem", ex);
            }
            return NoContent();
        }
    }
}
