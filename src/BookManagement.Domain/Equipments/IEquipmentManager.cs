using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】领域服务
/// </summary>
public interface IEquipmentManager : IDomainService
{
    /// <summary>
    /// 创建设备
    /// </summary>
    /// <param name="code"></param>
    /// <param name="displayText"></param>
    /// <param name="level"></param>
    /// <param name="isStatic"></param>
    /// <param name="rank"></param>
    /// <param name="equipmentTypeCode"></param>
    /// <param name="productId"></param>
    /// <param name="spec"></param>
    /// <param name="locationId"></param>
    /// <param name="responsibleUnitName"></param>
    /// <param name="responsibleUnitId"></param>
    /// <param name="responsiblePersonName"></param>
    /// <param name="responsiblePersonId"></param>
    /// <param name="manufacturerName"></param>
    /// <param name="manufacturerId"></param>
    /// <param name="usageStatus"></param>
    /// <param name="setupTime"></param>
    /// <param name="onlineTime"></param>
    /// <param name="parentId"></param>
    /// <param name="resourceJson"></param>
    /// <param name="remark"></param>
    /// <param name="longitude"></param>
    /// <param name="latitude"></param>
    /// <param name="status"></param>
    /// <param name="kind"></param>
    /// <param name="currentUsageCount"></param>
    /// <param name="usageCount"></param>
    /// <param name="blocked"></param>
    /// <returns></returns>
    public Task<Equipment> CreateAsync(
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
    );
}