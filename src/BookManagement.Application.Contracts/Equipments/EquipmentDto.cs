using Arim.Ims.Equipments.EquipmentStates;
using Arim.Ims.Equipments.EquipmentTypes;
using Arim.Infrastructure.Definitions.Categories;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

#pragma warning disable CS8618 

namespace Arim.Ims.Equipments.Equipments;

/// <summary>
/// 设备信息
/// </summary>
[Serializable]
public class EquipmentDto : EquipmentSimpleDto
{
    /// <summary>
    /// 资源
    /// </summary>
    public List<EquipmentResourceSimpleDto> Resources { get; set; }

    /// <summary>
    /// 属性
    /// </summary>
    public List<EquipmentPropertyDto> Properties { get; set; }

    /// <summary>
    /// 状态快照
    /// </summary>
    public List<EquipmentStateDto> States { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public EquipmentTypeDto EquipmentType { get; set; }

    /// <summary>
    /// 分类
    /// </summary>
    public List<CategoryDefinitionDto> Categories { get; set; }


}

public class EquipmentSimpleDto : EntityDto<Guid>
{
    /// <summary>
    /// 编码
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    public string DisplayText { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    public string? EquipmentTypeCode { get; set; }

    /// <summary>
    /// 产品Id
    /// </summary>
    public Guid? ProductId { get; set; }

    /// <summary>
    /// 规格型号
    /// </summary>
    public string? SpecificationCode { get; set; }

    /// <summary>
    /// 种类
    /// </summary>
    public string? Kind { get; set; }

    /// <summary>
    /// 安装位置Id
    /// </summary>
    public Guid? LocationId { get; set; }

    /// <summary>
    /// 级别
    /// </summary>
    public string Level { get; set; }

    /// <summary>
    /// 责任单位
    /// </summary>
    public string? ResponsibleUnitName { get; set; }

    /// <summary>
    /// 责任单位Id
    /// </summary>
    public Guid? ResponsibleUnitId { get; set; }

    /// <summary>
    /// 责任人
    /// </summary>
    public string? ResponsiblePersonName { get; set; }

    /// <summary>
    /// 责任人Id
    /// </summary>
    public Guid? ResponsiblePersonId { get; set; }

    /// <summary>
    /// 制造商
    /// </summary>
    public string? ManufacturerName { get; set; }

    /// <summary>
    /// 制造商Id
    /// </summary>
    public Guid? ManufacturerId { get; set; }

    /// <summary>
    /// 设备使用状态
    /// </summary>
    public string? UsageStatus { get; set; }

    /// <summary>
    /// 安装时间
    /// </summary>
    public DateTime? SetupTime { get; set; }

    /// <summary>
    /// 上线时间
    /// </summary>
    public DateTime? OnlineTime { get; set; }

    /// <summary>
    /// 父设备
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// 图片地址
    /// </summary>
    public string? ResourceJson { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool IsStatic { get; set; }

    /// <summary>
    /// 顺序值
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 纬度
    /// </summary>
    public float? Latitude { get; set; }

    /// <summary>
    /// 经度
    /// </summary>
    public float? Longitude { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 是否封锁
    /// </summary>
    public bool Blocked { get; set; }

    /// <summary>
    /// 使用次数
    /// </summary>
    public int UsageCount { get; set; }

    /// <summary>
    /// 当前使用次数
    /// </summary>
    public int CurrentUsageCount { get; set; }
}