using AuthApi.Data;
using AuthApi.Exceptions;
using AuthApi.Exceptions.AuthApi.Exceptions;
using AuthApi.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;


namespace AuthApi.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(ApplicationDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }




        public async Task<IEnumerable<T>> GetTAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<int> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new EntityNotFoundException($"Entity {typeof(T)} with id {id} not found");
            }

            return entity;
        }
    }
}
