using Drive.Data;
using Drive.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Repositories
{
    public class DriverRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public DriverRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        /*
         https://code-maze.com/net-core-web-development-part4/
        https://medium.com/net-core/repository-pattern-implementation-in-asp-net-core-21e01c6664d7
        https://medium.com/@chathuranga94/generic-repository-pattern-for-asp-net-core-9e3e230e20cb
        https://www.growthaccelerationpartners.com/tech/implement-repository-pattern-net-core/
        https://code-maze.com/net-core-web-development-part4/
         */
    }
}
