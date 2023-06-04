using BookStore.DAL.Interfaces;
using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public class StoreRepository : IBaseRepository<Store>
    {
        private readonly ApplicationDbContext _context;
        public StoreRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Store item)
        {
            _context.Store.Add(item);
        }

        public void Delete(Store item)
        {
            Store store = _context.Store.Find(item.Id);
            if(store != null)   
                _context.Store.Remove(store);   
        }

        public Store Get(int id)
        {
            return _context.Store.Find(id);
        }

        public IEnumerable<Store> GetAll()
        {
            return _context.Store;
        }

        public void Update(Store item)
        {
            _context.Update(item);
        }
    }
}
