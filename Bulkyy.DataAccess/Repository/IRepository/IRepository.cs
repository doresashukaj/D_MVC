using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulkyy.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Will be category or any other generic model on which we want to interact with the DB Context
        // T - Category
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
