using System.Linq;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】查询扩展
/// </summary>
public static class EquipmentEfCoreQueryableExtensions
{
    public static IQueryable<Equipment> IncludeDetails(this IQueryable<Equipment> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            ;
    }
}
