using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】领域服务
/// </summary>
public class EquipmentManager(
    IEquipmentRepository equipmentRepository)
    : DomainService,
        IEquipmentManager
{
    public async Task<Equipment> CreateAsync(
        [Required] string code,
        [Required] string displayText,
        [Required] string level,
        [Required] bool isStatic,
        [Required] int rank,
        string? equipmentTypeCode = null,
        Guid? productId = null,
        string? spec = null,
        Guid? locationId = null,
        string? responsibleUnitName = null,
        Guid? responsibleUnitId = null,
        string? responsiblePersonName = null,
        Guid? responsiblePersonId = null,
        string? manufacturerName = null,
        Guid? manufacturerId = null,
        string? usageStatus = null,
        DateTime? setupTime = null,
        DateTime? onlineTime = null,
        Guid? parentId = null,
        string? resourceJson = null,
        string? remark = null,
        float? longitude = null,
        float? latitude = null,
        string? status = null,
        string? kind = null,
        [Required] int currentUsageCount = 0,
        [Required] int usageCount = 0,
        [Required] bool blocked = false
    )
    {
        // 创建设备定义 定义一个设备
        var equipment = new Equipment(
            GuidGenerator.Create(),
            code,
            displayText,
            level,
            isStatic,           
            rank,
            equipmentTypeCode,
            productId,
            spec,
            locationId,
            responsibleUnitName,
            responsibleUnitId,
            responsiblePersonName,
            responsiblePersonId,
            manufacturerName,
            manufacturerId,
            usageStatus,
            setupTime,
            onlineTime,
            parentId,
            resourceJson,
            remark,
            longitude,
            latitude,
            status,
            kind,
            currentUsageCount,
            usageCount,
            blocked
            );

        // 返回设备定义 定义一个设备
        return equipment;
    }
}