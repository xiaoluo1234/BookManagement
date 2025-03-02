using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace BookManagement
{
    /// <summary>
    /// 数据新增，删除，更新操作的本地事件
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="cache"></param>
    public class DataStoreEventHandler<TEntity>(IDistributedCache<TEntity, Guid> cache) : ILocalEventHandler<EntityCreatedEventData<TEntity>>,
        ILocalEventHandler<EntityUpdatedEventData<TEntity>>,
        ILocalEventHandler<EntityDeletedEventData<TEntity>>,
        ITransientDependency
        where TEntity : class, IEntity<Guid>
    {
        /// <summary>
        /// 新增操作
        /// </summary>
        /// <param name="eventData"></param>
        /// <returns></returns>
        public async Task HandleEventAsync(EntityCreatedEventData<TEntity> eventData)
        {
            await UpdateCache(eventData.Entity);
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="eventData"></param>
        /// <returns></returns>
        public async Task HandleEventAsync(EntityUpdatedEventData<TEntity> eventData)
        {
            await UpdateCache(eventData.Entity);
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="eventData"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task HandleEventAsync(EntityDeletedEventData<TEntity> eventData)
        {
            var id = eventData.Entity.Id;
            await cache.RemoveAsync(id);
        }

        /// <summary>
        /// 更新缓存数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private async Task UpdateCache(TEntity entity)
        {
            PrefixContext.Prefix.Value = string.Empty;

            var id = entity.Id;

            var options = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromDays(30));

            await cache.SetAsync(id, entity, options);
        }
    }
}
