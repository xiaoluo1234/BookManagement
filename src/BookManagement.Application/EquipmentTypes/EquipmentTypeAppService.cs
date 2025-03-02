using Arim.Infrastructure.Inputs;
using BookManagement;
using BookManagement.EntityExtensions;
using BookManagement.EquipmentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Arim.Ims.Equipments.EquipmentTypes;

/// <summary>
/// 设备类型服务
/// </summary>
public class EquipmentTypeAppService(
    IEquipmentTypeRepository equipmentTypeRepository,
    IEquipmentTypeManager equipmentTypeManager,
    IEntityExtensionIntegrationService entityExtensionIntegrationService,
    IDataStore dataStore)
    : CrudAppService<EquipmentType, EquipmentTypeDto, Guid, EquipmentTypeGetListInput, EquipmentTypeCreateInput, EquipmentTypeUpdateInput>(equipmentTypeRepository),
        IEquipmentTypeAppService
{

    /// <summary>
    /// 创建设备类型
    /// <param name="input"></param>
    /// </summary>
    /// <returns>EquipmentTypeDto</returns>
    public override async Task<EquipmentTypeDto> CreateAsync(EquipmentTypeCreateInput input)
    {
        await CheckCreatePolicyAsync();

        var equipmentType = await equipmentTypeManager.CreateAsync(
            input.IsStatic,
            input.Rank,
            input.Code,
            input.DisplayText,
            input.Remark
            );

        await equipmentTypeRepository.InsertAsync(equipmentType);

        return await MapToGetOutputDtoAsync(equipmentType);
    }

    /// <summary>
    /// 删除设备类型
    /// </summary>
    /// <param name="input"></param>
    public async Task DeleteManyAsync(BulkDeleteInput<Guid> input)
    {
        await CheckDeletePolicyAsync();

        await equipmentTypeRepository.DeleteManyAsync(input.Items);
    }

    /// <summary>
    ///构建查询
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    protected override async Task<IQueryable<EquipmentType>> CreateFilteredQueryAsync(EquipmentTypeGetListInput input)
    {
        return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Code.IsNullOrWhiteSpace(), x => x.Code!.Contains(input.Code!))
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => (x.DisplayText ?? "").Contains(input.Keyword!) || (x.Code ?? "").Contains(input.Keyword!))
                .WhereIf(!input.DisplayText.IsNullOrWhiteSpace(), x => x.DisplayText!.Contains(input.DisplayText!))
                .WhereIf(input.IsStatic.HasValue, x => x.IsStatic == input.IsStatic!.Value);
    }
    //public override async Task<PagedResultDto<EquipmentTypeDto>> GetListAsync(EquipmentTypeGetListInput input)
    //{

    //    var query = await CreateFilteredQueryAsync(input);
    //    var totalCount = await AsyncExecuter.CountAsync(query);
    //    if (totalCount == 0) return new PagedResultDto<EquipmentTypeDto>();

    //    if (input.IsPage)
    //    {
    //        query = query.PageBy(input.SkipCount, input.MaxResultCount);
    //    }
    //    var entities = await AsyncExecuter.ToListAsync(query);
    //    var result = await MapToGetListOutputDtosAsync(entities);
    //    var entityInput = ObjectMapper.Map<EquipmentTypeGetListInput, EntityExtensionGetListInput>(input);
    //    entityInput.EntityIds = entities.Select(x => x.Id.ToString());
    //    var entityProperties = (await entityExtensionIntegrationService.GetEntityPropertiesAsync(entityInput)).Items.ToList();
    //    foreach (var item in result)
    //    {
    //        if (entityProperties.IsAny())
    //        {
    //            item.Properties = entityProperties.Where(x => x.EntityId == item.Id.ToString()).ToList();
    //        }
    //    }
    //    return new PagedResultDto<EquipmentTypeDto>
    //    {
    //        TotalCount = totalCount,
    //        Items = result
    //    };
    //}

    /// <summary>
    /// 获取设备类型
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<EquipmentTypeDto> GetAsync(Guid id, EntityExtensionGetListInput input)
    {
        var result = await GetAsync(id);
        input.EntityId = result.Id.ToString();
        return result;
    }

    public override async Task<EquipmentTypeDto> GetAsync(Guid id)
    {
        var result = await dataStore.GetAsync<EquipmentType>(id);
        return MapToGetOutputDto(result);
    }
    /// <summary>
    /// 获取设备类型属性
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<EquipmentTypeDto> GetPropertiesAsync(Guid id, EntityExtensionGetListInput input)
    {
        var result = await base.GetAsync(id);
        input.EntityId = result.Id.ToString();
        return result;
    }
}
