using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Arim.Ims.Equipments.EntityExtensions;
using Arim.Infrastructure.Inputs;
using Volo.Abp.Application.Services;

namespace Arim.Ims.Equipments.EquipmentTypes;

/// <summary>
/// 【设备类型】应用服务
/// </summary>
public interface IEquipmentTypeAppService 
    : ICrudAppService<EquipmentTypeDto, Guid, EquipmentTypeGetListInput, EquipmentTypeCreateInput, EquipmentTypeUpdateInput>
{
    /// <summary>
    /// 删除【设备类型】信息（批量）
    /// </summary>
    /// <param name="input">批量删除信息</param>
    public Task DeleteManyAsync([Required] BulkDeleteInput<Guid> input);

    /// <summary>
    /// 获取实体信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EquipmentTypeDto> GetAsync(Guid id, EntityExtensionGetListInput input);

    /// <summary>
    /// 获取设备类型属性
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EquipmentTypeDto> GetPropertiesAsync(Guid id, EntityExtensionGetListInput input);
}