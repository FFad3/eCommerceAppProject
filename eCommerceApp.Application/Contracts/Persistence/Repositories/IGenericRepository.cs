﻿using eCommerceApp.Domain;
using System.Linq.Expressions;

namespace eCommerceApp.Application.Contracts.Persistence
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        /// <summary>
        /// Add single element
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken token);

        /// <summary>
        /// Removes entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task RemoveAsync(TEntity entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// Returns dbSet as IQuerable
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> AsIQuerable();

        /// <summary>
        /// Gets single entity that match predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<TEntity?> FindSingleAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token);

        /// <summary>
        /// Gets all entities that match predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token);

        /// <summary>
        /// Counts entites that match predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<int> CountAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token);

        /// <summary>
        /// Check for uniqnes
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<bool> IsUniqueAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token);
    }
}