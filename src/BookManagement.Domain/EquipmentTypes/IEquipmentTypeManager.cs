using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】领域服务
/// </summary>
public interface IEquipmentTypeManager : IDomainService
{
    /// <summary>
    /// 创建【设备类型】信息
    /// </summary>
    /// <param name="code">编码</param>
    /// <param name="displayText">显示名称</param>
    /// <param name="isStatic"></param>
    /// <param name="rank">顺序值</param>
    /// <param name="remark">描述</param>
    /// <returns>设备类型实例</returns>
    public Task<EquipmentType> CreateAsync(
        bool isStatic,
        int rank,
        string? code = null,
        string? displayText = null,
        string? remark = null
    );
}