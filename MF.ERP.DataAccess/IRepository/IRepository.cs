using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess
{
    public interface IRepository<T> where T : class
    {

        T GetFirstOrDefault(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool tracked = true);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool tracked = true);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool iQF = false);
        Task<IEnumerable<TType>> GetAllAsyncSelect<TType>(Expression<Func<T, TType>> select, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<EntityEntry<T>> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task<bool> IsExist(Expression<Func<T, bool>> predicate);
        Task<bool> Any(Expression<Func<T, bool>> predicate = null);
        Task<(int, IEnumerable<T>)> FindPagedAsync(Expression<Func<T, bool>> predicate = null, int skip = 0, int take = 0,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string orderCol = null, string orderDir = "asc"
            , Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disableTracking = true);

    }
}
