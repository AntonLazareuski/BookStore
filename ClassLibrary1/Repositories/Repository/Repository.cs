using BookStore.DAL.Entities.Interfaces;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStore.DAL.Repositories.Repository
{
    internal abstract class Repository : IBaseRepository
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<EntityEntry<T>> Create<T>(T item) where T : class, IBaseEntity
        {
            return await _context.Set<T>().AddAsync(item);
        }

        public async Task<bool> Delete<T>(int id) where T : class, IBaseEntity   
        {
            if(id > 0)
            {
                var item = await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
                if(item != null)
                {
                    _context.Set<T>().Remove(item);
                    return true;
                }
            }
            return false;   
        }

        public async Task<T> Get<T>(int id) where T: class, IBaseEntity
        {
            return await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class, IBaseEntity  
        {
            return await _context.Set<T>().ToListAsync();   
        }

        public async Task<EntityEntry<T>> Update<T>(T item, int id) where T : class, IBaseEntity    
        {
            if (id > 0)
            {
                var oldItem = await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
                if (oldItem != null)
                {
                   return _context.Set<T>().Update(item);
                }
            }
            return null;
        }
    }
}
