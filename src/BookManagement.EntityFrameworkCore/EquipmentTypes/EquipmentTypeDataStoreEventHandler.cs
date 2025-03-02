using System;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;

namespace BookManagement.EquipmentTypes
{
    public class EquipmentTypeDataStoreEventHandler(IDistributedCache<EquipmentType, Guid> cache) : DataStoreEventHandler<EquipmentType>(cache), ITransientDependency
    {

    }
}
