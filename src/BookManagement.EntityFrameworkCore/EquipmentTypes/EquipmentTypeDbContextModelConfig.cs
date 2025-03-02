using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace BookManagement.EquipmentTypes;

internal static class EquipmentTypeDbContextModelConfig
{
    /// <summary>
    /// 【设备类型】模型配置
    /// </summary>
    public static void ConfigureEquipmentType(this ModelBuilder builder)
    {
        builder.Entity<EquipmentType>(b =>
        {
            b.ToTable(EquipmentsDbProperties.DbTablePrefix + nameof(EquipmentType), EquipmentsDbProperties.DbSchema, table => table.HasComment("设备类型"));
            b.ConfigureByConvention(); 

            // 属性
            b.Property(x => x.Code).IsRequired(false).HasMaxLength(EquipmentTypeConstants.MaxLength.Code).HasComment("编码");
            b.Property(x => x.DisplayText).IsRequired(false).HasMaxLength(EquipmentTypeConstants.MaxLength.DisplayText).HasComment("显示名称");
            b.Property(x => x.IsStatic).IsRequired().HasComment("");
            b.Property(x => x.Rank).IsRequired().HasComment("顺序值");
            b.Property(x => x.Remark).IsRequired(false).HasMaxLength(EquipmentTypeConstants.MaxLength.Remark).HasComment("描述");
        });
    }
}
