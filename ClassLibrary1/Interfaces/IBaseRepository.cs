using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    internal interface IBaseRepository<T>
    {
        void Create(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Delete(T item);
        void Update(T item);    
    }
}
