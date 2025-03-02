using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】领域服务
/// </summary>
public class EquipmentTypeManager(
    IEquipmentTypeRepository equipmentTypeRepository)
    : DomainService,
        IEquipmentTypeManager
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
    public async Task<EquipmentType> CreateAsync(
        [Required] bool isStatic,
        [Required] int rank,
        string? code = null,
        string? displayText = null,
        string? remark = null
    )
    {
        // 检查设备类型是否已存在
        //if (await equipmentTypeRepository.AnyAsync(x => x. == ))
        //{
        //    throw new EquipmentTypeAlreadyExistException();
        //}

        // 创建设备类型
        var equipmentType = new EquipmentType(
            GuidGenerator.Create(),
            isStatic,
            rank,
            code,
            displayText,
            remark
            );

        // 返回设备类型
        return equipmentType;
    }
}