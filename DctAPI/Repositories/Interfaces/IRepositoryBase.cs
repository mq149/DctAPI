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

        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}
