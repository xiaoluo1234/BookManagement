using Arim.DynamicQuery.Core.Filtering;
using Arim.DynamicQuery.Services;
using Arim.Ims.Equipments.Equipments;
using Arim.Ims.Equipments.EquipmentTypes;
using Arim.Infrastructure.Inputs;
using BookManagement.EquipmentTypes;
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
    IEquipmentTypeRepository equipmentTypeRepository,
    IGuidGenerator guidGenerator,
    // IEquipmentFilter equipmentFilter,
    IDynamicQueryRepository<Equipment> dynamicQueryRepository)
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

        var infoInput = ObjectMapper.Map<EquipmentGetListInput, EquipmentGetInfoInput>(input);
        infoInput.EntityIds = entities.Select(x => x.Id.ToString());
        // 此处不能使用分页查询，否则会导致有些设备没有属性信息
        infoInput.IsPage = false;
        foreach (var item in result)
        {
            await PopulateEquipmentDtoAsync(item, infoInput);
        }

        return new PagedResultDto<EquipmentDto>(totalCount, result);
    }
    public async Task<EquipmentDto> GetAsync(Guid id, EquipmentGetInfoInput input)
    {
        var result = await GetAsync(id);

        input.EntityId = result.Id.ToString();

        await PopulateEquipmentDtoAsync(result, input);

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
    EquipmentGetInfoInput input)
    {
        if (input.IncludeEquipmentType && !item.EquipmentTypeCode.IsNullOrWhiteSpace())
        {
            var equipmentType = await dataStore.GetAsync<EquipmentType>(new Guid(item.EquipmentTypeCode));
            item.EquipmentType = ObjectMapper.Map<EquipmentType, EquipmentTypeDto>(equipmentType);
        }
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
}
