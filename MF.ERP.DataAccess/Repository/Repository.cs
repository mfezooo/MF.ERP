using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (include != null)
            {
                query = include(query);
            }
            return query.ToList();
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool tracked = true)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            if (include != null)
            {
                query = include(query);
            }

            return query.FirstOrDefault();
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
        public async Task<(int, IEnumerable<T>)> FindPagedAsync(Expression<Func<T, bool>> predicate = null, int skip = 0, int take = 0,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string orderCol = null, string orderDir = "asc"
            , Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disableTracking = true)
        {

            IQueryable<T> query = dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            int count = query.Count();
            if (orderBy != null && orderCol == null)
            {
                query = orderBy(query);
            }

            query = query.Skip(skip).Take(take);
            if (include != null)
            {
                query = include(query).AsSplitQuery();
            }
            return (count, await query.ToListAsync());
        }

        public async Task<EntityEntry<T>> AddAsync(T entity)
        {
            return await dbSet.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool iQF = false)
        {
            IQueryable<T> query = dbSet;
            if (iQF) query = query.IgnoreQueryFilters();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = include(query);
            }
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<TType>> GetAllAsyncSelect<TType>(Expression<Func<T, TType>> select, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = include(query);
            }
            return await query.Select(select).ToListAsync();
        }
        public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool tracked = true)
        {
            var query = dbSet.AsQueryable();
            if (!tracked)
            {
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync();
        }
        public async Task<bool> IsExist(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet;
            return await query.AnyAsync(predicate);
        }
        public async Task<bool> Any(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = dbSet;
            return predicate == null ? await query.AnyAsync() : await query.AnyAsync(predicate);
        }
    }
}
