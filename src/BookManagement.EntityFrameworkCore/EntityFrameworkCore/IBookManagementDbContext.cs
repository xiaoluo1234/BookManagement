using BookManagement;
using BookManagement.Equipments;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Arim.Ims.Equipments.EntityFrameworkCore;

[ConnectionStringName(EquipmentsDbProperties.ConnectionStringName)]
public interface IBookManagementDbContext : IEfCoreDbContext
{
    /// <summary>
    /// 设备类型
    /// </summary>
    public DbSet<EquipmentType> EquipmentTypes { get; set; }

    /// <summary>
    /// 设备定义 定义一个设备
    /// </summary>
    public DbSet<Equipment> Equipment { get; set; }
}
