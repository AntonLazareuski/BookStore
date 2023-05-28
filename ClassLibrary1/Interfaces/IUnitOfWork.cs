using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    internal interface IUnitOfWork: IDisposable
    {
        IBaseRepository<Book> Books { get; }
        IBaseRepository<Store> Stores { get; }
        IBaseRepository<Employee> Employees { get; }
        void Save();
    }
}
