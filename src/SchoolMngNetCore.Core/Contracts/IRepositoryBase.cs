using SchoolMngNetCore.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Core.Contracts
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        void Add(T entity);

        Task AddAsync(T entity);

        int Count(ISpecification<T> spec);

        Task<int> CountAsync(ISpecification<T> spec);

        void Delete(T entity);

        IReadOnlyList<T> Get(ISpecification<T> spec);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null,
            bool disableTracking = true);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true);

        IReadOnlyList<T> GetAll();

        Task<IReadOnlyList<T>> GetAllAsync();

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

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        void Update(T entity);
    }
}