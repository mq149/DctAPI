using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        Task<T> Find(int id);
       
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
