using Arim.DynamicQuery.Services;
using Arim.Infrastructure.Inputs;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

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
}