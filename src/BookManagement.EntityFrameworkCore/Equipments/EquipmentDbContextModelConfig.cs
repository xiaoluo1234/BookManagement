using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace BookManagement.Equipments;

internal static class EquipmentDbContextModelConfig
{
    /// <summary>
    /// 【设备定义 定义一个设备】模型配置
    /// </summary>
    public static void ConfigureEquipment(this ModelBuilder builder)
    {
        builder.Entity<Equipment>(b =>
        {
            b.ToTable(EquipmentsDbProperties.DbTablePrefix + nameof(Equipment), EquipmentsDbProperties.DbSchema, table => table.HasComment("设备定义 定义一个设备"));
            b.ConfigureByConvention();

            // 属性
            b.Property(x => x.Code).IsRequired().HasMaxLength(EquipmentConstants.MaxLength.Code).HasComment("编码");
            b.Property(x => x.DisplayText).IsRequired().HasMaxLength(EquipmentConstants.MaxLength.DisplayText).HasComment("显示名称");
            b.Property(x => x.EquipmentTypeCode).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.EquipmentTypeCode).HasComment("类型");
            b.Property(x => x.ProductId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ProductId).HasComment("产品Id");
            b.Property(x => x.SpecificationCode).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.SpecificationCode).HasComment("规格型号");
            b.Property(x => x.Kind).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.Kind).HasComment("种类");
            b.Property(x => x.LocationId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.LocationId).HasComment("安装位置Id");
            b.Property(x => x.Level).IsRequired().HasMaxLength(EquipmentConstants.MaxLength.Level).HasComment("级别");
            b.Property(x => x.ResponsibleUnitName).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ResponsibleUnitName).HasComment("责任单位");
            b.Property(x => x.ResponsibleUnitId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ResponsibleUnitId).HasComment("责任单位Id");
            b.Property(x => x.ResponsiblePersonName).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ResponsiblePersonName).HasComment("责任人");
            b.Property(x => x.ResponsiblePersonId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ResponsiblePersonId).HasComment("责任人Id");
            b.Property(x => x.ManufacturerName).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ManufacturerName).HasComment("制造商");
            b.Property(x => x.ManufacturerId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ManufacturerId).HasComment("制造商Id");
            b.Property(x => x.UsageStatus).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.UsageStatus).HasComment("设备使用状态");
            b.Property(x => x.SetupTime).IsRequired(false).HasComment("安装时间");
            b.Property(x => x.OnlineTime).IsRequired(false).HasComment("上线时间");
            b.Property(x => x.ParentId).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ParentId).HasComment("父设备");
            b.Property(x => x.ResourceJson).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.ResourceJosn).HasComment("资源对象");
            b.Property(x => x.IsStatic).IsRequired().HasComment("是否静态");
            b.Property(x => x.Status).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.Status).HasComment("状态");
            b.Property(x => x.Rank).IsRequired().HasMaxLength(EquipmentConstants.MaxLength.Rank).HasComment("顺序值");
            b.Property(x => x.Blocked).IsRequired().HasComment("是否封锁");
            b.Property(x => x.UsageCount).IsRequired().HasComment("使用次数");
            b.Property(x => x.Latitude).IsRequired(false).HasComment("纬度");
            b.Property(x => x.Longitude).IsRequired(false).HasComment("经度");
            b.Property(x => x.Remark).IsRequired(false).HasMaxLength(EquipmentConstants.MaxLength.Remark).HasComment("描述");
            b.Property(x => x.CurrentUsageCount).IsRequired().HasComment("当前使用次数");
        });
    }
}
