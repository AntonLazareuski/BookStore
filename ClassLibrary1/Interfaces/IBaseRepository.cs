using Microsoft.EntityFrameworkCore.ChangeTracking;
using BookStore.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    internal interface IBaseRepository
    {
        Task<EntityEntry<T>> Create<T>(T item) where T : class, IBaseEntity;
        Task<EntityEntry<T>> Update<T>(T item, int id) where T : class, IBaseEntity;
        Task<bool> Delete<T>(int id) where T : class, IBaseEntity;
        Task<T> Get<T>(int id) where T : class, IBaseEntity;
        Task<IEnumerable<T>> GetAll<T>() where T : class, IBaseEntity;

    }
}
