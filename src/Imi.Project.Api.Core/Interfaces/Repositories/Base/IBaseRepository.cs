using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T, TKey>
    {
        Task<T> GetByIdAsync(TKey id);
        IQueryable<T> GetAllAsync();
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> GetByIdAsync(TKey id, string[] includes);
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> DeleteAsync(TKey id);
    }
}
