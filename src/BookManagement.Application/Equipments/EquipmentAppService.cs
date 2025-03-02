using Arim.Ims.Equipments.EntityExtensions;
using Arim.Ims.Equipments.EquipmentTypes;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using static BookManagement.SharedConsts;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】应用服务  
/// </summary>
public class EquipmentAppService(
    IEquipmentRepository equipmentRepository,
    IEquipmentManager equipmentManager,
    IDataStore dataStore,
    IEntityExtensionIntegrationService entityExtensionIntegrationService,
    IEquipmentTypeRepository equipmentTypeRepository,
    IGuidGenerator guidGenerator,
    // IEquipmentFilter equipmentFilter,
    IDynamicQueryRepository<Equipment> dynamicQueryRepository,
    IOptions<OrganizationUnitFilter> options)
    : DynamicQueryCrudAppService<EquipmentDto, Guid, EquipmentGetListInput, EquipmentCreateInput, EquipmentUpdateInput, Equipment>(equipmentRepository, dynamicQueryRepository),
        IEquipmentAppService
{
    //protected override string GetPolicyName { get; set; } = EquipmentsPermissions.Equipment.Default;
    //protected override string GetListPolicyName { get; set; } = EquipmentsPermissions.Equipment.Default;
    //protected override string CreatePolicyName { get; set; } = EquipmentsPermissions.Equipment.Create;
    //protected override string UpdatePolicyName { get; set; } = EquipmentsPermissions.Equipment.Update;
    //protected override string DeletePolicyName { get; set; } = EquipmentsPermissions.Equipment.Delete;
    #region ==设备相关==
    /// <summary>
    /// 添加一个设备
    /// <param name="input">input</param>
    /// </summary>
    /// <returns>添加一个设备</returns>
    public override async Task<EquipmentDto> CreateAsync(EquipmentCreateInput input)
    {
        var resourceJson = "";
        if (input.Resources.IsAny())
        {
            resourceJson = JsonConvert.SerializeObject(input.Resources);
        }
        if (input.Level == null)
        {
            input.Level = EquipmentLevel.Normal;
        }

        // 根据设备类型编码获取设备类型Id
        if (input.EquipmentTypeId == null && !string.IsNullOrWhiteSpace(input.EquipmentTypeCode))
        {
            var equipmentType = await equipmentTypeRepository.FirstOrDefaultAsync(x => x.Code == input.EquipmentTypeCode);
            if (equipmentType != null)
            {
                input.EquipmentTypeId = equipmentType.Id;
            }
        }

        var equipment = await equipmentManager.CreateAsync(
            input.Code,
            input.DisplayText,
            input.Level,
            input.IsStatic,
            input.Rank,
            input.EquipmentTypeCode,
            input.ProductId,
            input.SpecificationCode,
            input.LocationId,
            input.ResponsibleUnitName,
            input.ResponsibleUnitId,
            input.ResponsiblePersonName,
            input.ResponsiblePersonId,
            input.ManufacturerName,
            input.ManufacturerId,
            input.UsageStatus,
            input.SetupTime,
            input.OnlineTime,
            input.ParentId,
            resourceJson,
            input.Remark,
            input.Longitude,
            input.Latitude,
            input.Status,
            input.Kind,
            input.CurrentUsageCount,
            input.UsageCount,
            input.Blocked
            );

        await equipmentRepository.InsertAsync(equipment, true);
        return await MapToGetOutputDtoAsync(equipment);
    }


    public override async Task<EquipmentDto> UpdateAsync(Guid id, EquipmentUpdateInput input)
    {
        if (input.Level == null)
        {
            input.Level = EquipmentLevel.Normal;
        }
        input.ResourceJson = JsonConvert.SerializeObject(input.Resources);

        var entity = await base.UpdateAsync(id, input);

        return entity;
    }
    /// <summary>
    /// 批量删除设备
    /// </summary>
    /// <param name="input">批量删除信息</param>
    public async Task DeleteManyAsync(BulkDeleteInput<Guid> input)
    {
        // 批量删除设备
        await equipmentRepository.DeleteManyAsync(input.Items);
    }

    /// <summary>
    /// 创建查询过滤条件
    /// </summary>
    /// <param name="input">查询参数</param>
    /// <returns>查询语句</returns>
    protected override async Task<IQueryable<Equipment>> CreateFilteredQueryAsync(EquipmentGetListInput input)
    {
        var querable = await base.CreateFilteredQueryAsync(input);
        if (options.Value.IsEnabled)
        {
            //querable = await equipmentFilter.GetEquipmentQuerableAsync();
        }
        var query = querable
                .WhereIf(!input.Code.IsNullOrWhiteSpace(), x => x.Code!.Contains(input.Code!))
                .WhereIf(!input.DisplayText.IsNullOrWhiteSpace(), x => x.DisplayText!.Contains(input.DisplayText!))
                .WhereIf(input.Ids.IsAny(), x => input.Ids!.Contains(x.Id))
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => (x.DisplayText ?? "").Contains(input.Keyword!) || (x.Code ?? "").Contains(input.Keyword!))
                .WhereIf(input.ProductId != null, x => x.ProductId == input.ProductId!)
                .WhereIf(input.EquipmentTypeCode != null, x => x.EquipmentTypeCode == input.EquipmentTypeCode!)
                .WhereIf(!input.SpecificationCode.IsNullOrWhiteSpace(), x => x.SpecificationCode != null && x.SpecificationCode.Contains(input.SpecificationCode!))
                .WhereIf(!input.Kind.IsNullOrWhiteSpace(), x => x.Kind != null && x.Kind.Contains(input.Kind!))
                .WhereIf(!input.ResponsibleUnitName.IsNullOrWhiteSpace(), x => x.ResponsibleUnitName != null && x.ResponsibleUnitName.Contains(input.ResponsibleUnitName!))
                .WhereIf(input.ResponsibleUnitId != null, x => x.ResponsibleUnitId == input.ResponsibleUnitId!)
                .WhereIf(!input.ResponsiblePersonName.IsNullOrWhiteSpace(), x => x.ResponsiblePersonName != null && x.ResponsiblePersonName.Contains(input.ResponsiblePersonName!))
                .WhereIf(input.ResponsiblePersonId != null, x => x.ResponsiblePersonId == input.ResponsiblePersonId!)
                .WhereIf(!input.ManufacturerName.IsNullOrWhiteSpace(), x => x.ManufacturerName != null && x.ManufacturerName.Contains(input.ManufacturerName!))
                .WhereIf(input.ManufacturerId != null, x => x.ManufacturerId == input.ManufacturerId!)
                .WhereIf(!input.UsageStatusContain.IsNullOrWhiteSpace(), x => x.UsageStatus != null && x.UsageStatus.Contains(input.UsageStatusContain!))
                .WhereIf(input.SetupTime.HasValue, x => x.SetupTime == input.SetupTime!.Value)
                .WhereIf(input.ParentId != null, x => x.ParentId == input.ParentId!)
                .WhereIf(!input.Status.IsNullOrEmpty(), x => x.Status == input.Status!)
                .WhereIf(input.Kinds.IsAny(), x => input.Kinds!.Contains(x.Kind));

        if (input.PropertyValues.IsAny())
        {
            var propertyValues = input.PropertyValues.Select(x => x.PropertyValue).ToList();
            var propertyCodes = input.PropertyValues.Select(x => x.PropertyCode).ToList();
            input.PropertyCodes = input.PropertyCodes.IsAny() ? propertyCodes : input.PropertyCodes.AddIfNotContains(propertyCodes).ToList();
            var entityProperties = await entityPropertyRepository.GetListAsync(x => propertyCodes.Contains(x.PropertyCode));
            entityProperties = entityProperties.Where(x => !string.IsNullOrEmpty(x.Value) && propertyValues.Any(pv => x.Value.Contains(pv))).ToList();
            var entityIds = entityProperties.Where(x => Guid.TryParse(x.EntityId, out _)).Select(x => Guid.Parse(x.EntityId)).ToList();
            if (entityIds.IsAny())
            {
                query = query.WhereIf(entityIds.IsAny(), x => entityIds.Contains(x.Id));
            }
            else
            {
                return Enumerable.Empty<Equipment>().AsQueryable();
            }
        }
        return query;
    }
    public override async Task<PagedResultDto<EquipmentDto>> GetListAsync(EquipmentGetListInput input)
    {
        var query = await CreateFilteredQueryAsync(input);
        var totalCount = await AsyncExecuter.CountAsync(query);
        if (totalCount == 0) return new PagedResultDto<EquipmentDto>();

        if (input.IsPage)
        {
            query = query.PageBy(input.SkipCount, input.MaxResultCount);
        }
        var entities = await AsyncExecuter.ToListAsync(query);
        var result = await MapToGetListOutputDtosAsync(entities);

        var equipmentIds = result.Select(x => x.Id).ToList();
        var equipmentStates = input.IncludeState
            ? await GetEquipmentStatesAsync(equipmentIds)
            : [];
        var infoInput = ObjectMapper.Map<EquipmentGetListInput, EquipmentGetInfoInput>(input);
        infoInput.EntityIds = entities.Select(x => x.Id.ToString());
        // 此处不能使用分页查询，否则会导致有些设备没有属性信息
        infoInput.IsPage = false;

        var entityProperties = input.IncludeProperties
            ? (await entityExtensionIntegrationService.GetEntityPropertiesAsync(infoInput.EntityId,infoInput)).Items.ToList()
            : [];
        foreach (var item in result)
        {
            await PopulateEquipmentDtoAsync(item, infoInput, entityProperties, equipmentStates);
        }

        return new PagedResultDto<EquipmentDto>(totalCount, result);
    }
    public async Task<EquipmentDto> GetAsync(Guid id, EquipmentGetInfoInput input)
    {
        var result = await GetAsync(id);

        input.EntityId = result.Id.ToString();
        var entityProperties = input.IncludeProperties
            ? (await entityExtensionIntegrationService.GetEntityPropertiesAsync(input.EntityId,input)).Items.ToList()
            : [];

        var equipmentStates = input.IncludeState
            ? await GetEquipmentStatesAsync([result.Id])
            : [];

        await PopulateEquipmentDtoAsync(result, input, entityProperties, equipmentStates);

        return result;
    }

    public override async Task<EquipmentDto> GetAsync(Guid id)
    {
        var result = await dataStore.GetAsync<Equipment>(id);
        return MapToGetOutputDto(result);
    }

    /// <summary>
    /// 填充 EquipmentDto 的属性
    /// </summary>
    private async Task PopulateEquipmentDtoAsync(
    EquipmentDto item,
    EquipmentGetInfoInput input,
    List<EquipmentPropertyDto> entityProperties,
    List<EquipmentStateDto> equipmentStates)
    {
        if (input.IncludeProperties)
        {
            item.Properties = entityProperties.Where(x => x.EntityId == item.Id.ToString()).ToList();
        }
        if (input.IncludeState)
        {
            item.States = equipmentStates.Where(x => x.EquipmentId == item.Id).ToList();
        }
        if (input.IncludeEquipmentType && !item.EquipmentTypeCode.IsNullOrWhiteSpace())
        {
            var equipmentType = await dataStore.GetAsync<EquipmentType>(new Guid(item.EquipmentTypeCode));
            item.EquipmentType = ObjectMapper.Map<EquipmentType, EquipmentTypeDto>(equipmentType);
        }
    }

    /// <summary>
    /// 获取设备状态列表
    /// </summary>
    private async Task<List<EquipmentStateDto>> GetEquipmentStatesAsync(List<Guid> equipmentIds)
    {
        var equipmentStates = await equipmentStateRepository.GetListAsync(x => equipmentIds.Contains(x.EquipmentId));
        return ObjectMapper.Map<List<EquipmentState>, List<EquipmentStateDto>>(equipmentStates);
    }

    /// <summary>
    /// 更新设备状态
    /// </summary>
    /// <param name="id"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    public async Task UpdateStatusAsync(Guid id, string status)
    {
        var entity = await equipmentRepository.GetAsync(id);
        entity.SetStatus(status);
        await equipmentRepository.UpdateAsync(entity);
    }
    #endregion

    #region ==设备属性相关==

    /// <summary>
    /// 获取设备属性
    /// </summary>
    /// <param name="equipmentCode"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<PagedResultDto<EquipmentPropertyDto>> GetPropertiesAsync(string equipmentCode, EntityExtensionGetListInput input)
    {
        //TODO:考虑并发，先做校验再添加
        input.IsInclude = true;
        var entityProperties = await entityExtensionIntegrationService.GetEntityPropertiesAsync(equipmentCode, input);
        return entityProperties;
    }

    /// <summary>
    /// 添加设备属性
    /// </summary>
    /// <param name="equipmentCode"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<EntityPropertyDto> CreatePropertyAsync(string equipmentCode, EquipmentPropertyCreateInput input)
    {
        //TODO:考虑并发，先做校验再添加
        var id = guidGenerator.Create();
        var propertyCode = input.PropertyCode.IsNullOrEmpty() ? id.ToString() : input.PropertyCode;
        var entityProperty = new EntityProperty(propertyCode, equipmentCode, input.EntityType, input.Value, input.ValueKind, input.MaxValue, input.MinValue, input.Remark, id: id);
        var result = await entityPropertyRepository.InsertAsync(entityProperty);
        return ObjectMapper.Map<EntityProperty, EntityPropertyDto>(result);
    }

    /// <summary>
    /// 更新设备属性
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<EntityPropertyDto> UpdatePropertyAsync(Guid id, EquipmentPropertyUpdateInput input)
    {
        var entityPropertyUpdate = new UpdateEntityPropertyInput
        {
            ValueKind = input.ValueKind,
            Value = input.Value,
            MaxValue = input.MaxValue,
            MinValue = input.MinValue,
            Remark = input.Remark,
            Rank = input.Rank,
        };
        return await entityPropertyIntegrationService.UpdateEntityPropertyAsync(id, entityPropertyUpdate);
    }

    public async Task DeletePropertyAsync(Guid id)
    {
        await entityPropertyIntegrationService.DeleteEntityPropertyByIdAsync(id);
    }

    #endregion

}
