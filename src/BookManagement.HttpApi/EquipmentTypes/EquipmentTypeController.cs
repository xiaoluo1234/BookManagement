using Arim.Infrastructure.Inputs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Arim.Ims.Equipments.EquipmentTypes;

/// <summary>
/// 设备类型
/// </summary>
[Route("api/equipments/equipment-types/")]
public partial class EquipmentTypeController(IEquipmentTypeAppService equipmentTypeAppService)
{
    /// <summary>
    /// 添加设备类型
    /// </summary>
    /// <param name="input">Input</param>
    /// <returns>设备类型详情</returns>
    [HttpPost]
    public virtual async Task<EquipmentTypeDto> CreateAsync(EquipmentTypeCreateInput input)
    {
        return await equipmentTypeAppService.CreateAsync(input);
    }

    /// <summary>
    /// 删除设备类型
    /// </summary>
    /// <param name="id">设备类型id</param>
    [HttpDelete("{id}")]
    public async Task DeleteAsync([FromRoute] Guid id)
    {
        await equipmentTypeAppService.DeleteAsync(id);
    }

    /// <summary>
    /// 批量删除设备类型
    /// </summary>
    /// <param name="input">Input</param>
    [HttpDelete]
    public async Task BulkDeleteAsync([FromBody] BulkDeleteInput<Guid> input)
    {
        await equipmentTypeAppService.DeleteManyAsync(input);
    }

    /// <summary>
    /// 更新设备类型
    /// </summary>
    /// <param name="id">设备类型ID</param>
    /// <param name="input">Input</param>
    /// <returns>设备类型详情</returns>
    [HttpPut("{id}")]
    public virtual async Task<EquipmentTypeDto> UpdateAsync(Guid id, EquipmentTypeUpdateInput input)
    {
        return await equipmentTypeAppService.UpdateAsync(id, input);
    }

    /// <summary>
    /// 获取设备类型列表
    /// </summary>
    /// <param name="input">Input</param>
    /// <returns>设备类型列表</returns>
    [HttpGet]
    public virtual async Task<PagedResultDto<EquipmentTypeDto>> GetListAsync(EquipmentTypeGetListInput input)
    {
        return await equipmentTypeAppService.GetListAsync(input);
    }
}
