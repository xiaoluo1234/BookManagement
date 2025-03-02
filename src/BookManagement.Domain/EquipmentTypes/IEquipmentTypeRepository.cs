using System;
using Volo.Abp.Domain.Repositories;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】仓储
/// </summary>
public interface IEquipmentTypeRepository : IRepository<EquipmentType, Guid>
{
}