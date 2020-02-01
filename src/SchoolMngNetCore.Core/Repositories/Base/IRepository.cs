using SchoolMngNetCore.Core.Entities.Base;
using SchoolMngNetCore.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Core.Repositories.Base
{
    public interface IRepository<T> : IRepository<T, int> where T : IEntity<int>
    {
    }

    public interface IRepository<T, TId> where T : IEntity<TId>
    {
        Task<T> GetByIdAsync(TId id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null,
            bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true);

        Task<int> CountAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);
    }
}