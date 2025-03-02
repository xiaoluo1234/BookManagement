using System.Linq;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】查询扩展
/// </summary>
public static class EquipmentTypeEfCoreQueryableExtensions
{
    public static IQueryable<EquipmentType> IncludeDetails(this IQueryable<EquipmentType> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            ;
    }
}
