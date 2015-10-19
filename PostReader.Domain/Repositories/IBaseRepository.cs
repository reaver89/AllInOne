using System.Collections.Generic;

namespace PostReader.Data.Repositories
{
    public interface IBaseRepository<T> where T :class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
    }
}
