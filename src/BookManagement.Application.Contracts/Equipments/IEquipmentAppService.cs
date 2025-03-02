using Arim.DynamicQuery.Services;
using Arim.Ims.Equipments.EntityExtensions;
using Arim.Infrastructure.EntityExtension.EntityProperties;
using Arim.Infrastructure.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Arim.Ims.Equipments.Equipments;

/// <summary>
/// 设备应用服务
/// </summary>
public interface IEquipmentAppService
    : IDynamicQueryCrudAppService<EquipmentDto, Guid, EquipmentGetListInput, EquipmentCreateInput, EquipmentUpdateInput>
{
    /// <summary>
    /// 批量删除设备
    /// </summary>
    /// <param name="input">批量删除信息</param>
    public Task DeleteManyAsync([Required] BulkDeleteInput<Guid> input);

    /// <summary>
    /// 获取设备详情
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EquipmentDto> GetAsync(Guid id, EquipmentGetInfoInput input);

    /// <summary>
    /// 获取设备属性列表
    /// </summary>
    /// <param name="equipmentCode"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<PagedResultDto<EquipmentPropertyDto>> GetPropertiesAsync(string equipmentCode, EntityExtensionGetListInput input);

    /// <summary>
    /// 创建设备属性
    /// </summary>
    /// <param name="equipmentCode"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EntityPropertyDto> CreatePropertyAsync(string equipmentCode, EquipmentPropertyCreateInput input);

    /// <summary>
    /// 更新设备属性
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EntityPropertyDto> UpdatePropertyAsync(Guid id, EquipmentPropertyUpdateInput input);

    /// <summary>
    /// 删除属性
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeletePropertyAsync(Guid id);

    /// <summary>
    /// 更新设备状态
    /// </summary>
    /// <param name="id"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    Task UpdateStatusAsync(Guid id, string status);
    
}