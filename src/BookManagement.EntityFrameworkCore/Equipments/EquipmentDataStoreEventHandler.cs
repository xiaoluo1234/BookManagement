using System;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;

namespace BookManagement.Equipments
{
    public class EquipmentDataStoreEventHandler(IDistributedCache<Equipment, Guid> cache) : DataStoreEventHandler<Equipment>(cache), ITransientDependency
    {

    }
}
