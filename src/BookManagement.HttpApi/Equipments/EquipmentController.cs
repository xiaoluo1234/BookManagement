using Arim.Infrastructure.Inputs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Arim.Ims.Equipments.Equipments;

/// <summary>
/// 设备接口
/// </summary>
[Route("api/equipments/equipments/")]
public partial class EquipmentController(IEquipmentAppService equipmentAppService)
{
    /// <summary>
    /// 添加一个设备
    /// </summary>
    /// <param name="input">Input</param>
    /// <returns>添加一个设备</returns>
    [HttpPost]
    public virtual async Task<EquipmentDto> CreateAsync(EquipmentCreateInput input)
    {
        return await equipmentAppService.CreateAsync(input);
    }

    /// <summary>
    /// 删除设备
    /// </summary>
    /// <param name="id">设备id</param>
    [HttpDelete("{id}")]
    public async Task DeleteAsync([FromRoute] Guid id)
    {
        await equipmentAppService.DeleteAsync(id);
    }

    /// <summary>
    /// 批量删除设备
    /// </summary>
    /// <param name="input">批量删除设备</param>
    [HttpDelete]
    public async Task BulkDeleteAsync([FromBody] BulkDeleteInput<Guid> input)
    {
        await equipmentAppService.DeleteManyAsync(input);
    }

    /// <summary>
    /// 更新设备
    /// </summary>
    /// <param name="id">Id</param>
    /// <param name="input">Input</param>
    /// <returns>更新设备</returns>
    [HttpPut("{id}")]
    public virtual async Task<EquipmentDto> UpdateAsync(Guid id, EquipmentUpdateInput input)
    {
        return await equipmentAppService.UpdateAsync(id, input);
    }

    /// <summary>
    /// 获取设备列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns>获取设备列表</returns>
    [HttpGet]
    public virtual async Task<PagedResultDto<EquipmentDto>> GetListAsync(EquipmentGetListInput input)
    {
        return await equipmentAppService.GetListAsync(input);
    }

    /// <summary>
    /// 动态查询获取设备列表
    /// </summary>
    /// <param name="input">Input</param>
    /// <returns></returns>
    [HttpPost("dynamic-filter")]
    public virtual async Task<PagedResultDto<EquipmentDto>> DynamicQueryEquipmentAsync(EquipmentQueryDto input)
    {
        return await equipmentAppService.DynamicQueryAsync<EquipmentDto>(input);
    }

    /// <summary>
    /// 获取一个设备
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="input">设备属性</param>
    /// <returns>获取一个设备</returns>
    [HttpGet("{id}")]
    public virtual async Task<EquipmentDto> GetAsync(Guid id, [FromQuery] EquipmentGetInfoInput input)
    {
        return await equipmentAppService.GetAsync(id, input);
    }
}
