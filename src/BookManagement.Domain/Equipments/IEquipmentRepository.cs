using System;
using Volo.Abp.Domain.Repositories;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】仓储
/// </summary>
public interface IEquipmentRepository : IRepository<Equipment, Guid>
{
}
