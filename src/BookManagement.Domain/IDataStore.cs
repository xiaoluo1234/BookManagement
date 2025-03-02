using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace BookManagement
{
    public interface IDataStore
    {
        /// <summary>
        /// 从缓存或数据库中获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync<TEntity>(Guid id)
            where TEntity : class, IEntity<Guid>;

        /// <summary>
        /// 从缓存中获取数据
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync<TEntity>(string key)
            where TEntity : class, new();

        /// <summary>
        /// 从缓存或数据库中批量获取实体数据
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetManyAsync<TEntity>(IEnumerable<Guid> ids)
            where TEntity : class, IEntity<Guid>;

        /// <summary>
        /// 从缓存中获取数据
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        Task<TEntity> GetCacheAsync<TEntity>(string key, string prefix)
            where TEntity : class, new();

        /// <summary>
        /// 设置缓存数据
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task SetAsync<TEntity>(string key, TEntity entity)
            where TEntity : class, new();
    }
}
