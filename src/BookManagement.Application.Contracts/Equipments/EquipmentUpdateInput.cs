using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Arim.Ims.Equipments.Equipments;

/// <summary>
/// 设备更新入参
/// </summary>
[Serializable]
public class EquipmentUpdateInput
{
    /// <summary>
    /// 编码
    /// </summary>
    [Required]
    [StringLength(EquipmentConstants.MaxLength.Code)]
    public string Code { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.DisplayText)]
    public string? DisplayText { get; set; }

    ///// <summary>
    ///// 类型
    ///// </summary>
    //public Guid? EquipmentTypeId { get; set; }

    /// <summary>
    /// 设备类型编码
    /// </summary>
    public string? EquipmentTypeCode { get; set; }

    /// <summary>
    /// 产品Id
    /// </summary>
    public Guid? ProductId { get; set; }

    /// <summary>
    /// 规格型号
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.SpecificationCode)]
    public string? SpecificationCode { get; set; }

    /// <summary>
    /// 种类
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.Kind)]
    public string? Kind { get; set; }

    /// <summary>
    /// 安装位置Id
    /// </summary>
    public Guid? LocationId { get; set; }

    /// <summary>
    /// 级别
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.Level)]
    public string? Level { get; set; }

    /// <summary>
    /// 责任单位
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ResponsibleUnitName)]
    public string? ResponsibleUnitName { get; set; }

    /// <summary>
    /// 责任单位Id
    /// </summary>
    public Guid? ResponsibleUnitId { get; set; }

    /// <summary>
    /// 责任人
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ResponsiblePersonName)]
    public string? ResponsiblePersonName { get; set; }

    /// <summary>
    /// 责任人Id
    /// </summary>
    public Guid? ResponsiblePersonId { get; set; }

    /// <summary>
    /// 制造商
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ManufacturerName)]
    public string? ManufacturerName { get; set; }

    /// <summary>
    /// 制造商Id
    /// </summary>
    public Guid? ManufacturerId { get; set; }

    /// <summary>
    /// 设备使用状态
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.UsageStatus)]
    public string? UsageStatus { get; set; }

    /// <summary>
    /// 安装时间
    /// </summary>
    [Required]
    public DateTime SetupTime { get; set; }

    /// <summary>
    /// 上线时间
    /// </summary>
    [Required]
    public DateTime OnlineTime { get; set; }

    /// <summary>
    /// 父设备
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// 资源Json
    /// </summary>
    public List<EquipmentResourceSimpleDto>? Resources { get; set; }
    public string? ResourceJson { get; set; }

    [Required]
    public bool IsStatic { get; set; }

    /// <summary>
    /// 顺序值
    /// </summary>
    [Required]
    public int Rank { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.Remark)]
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
    /// 是否封锁
    /// </summary>
    [Required]
    public bool Blocked { get; set; }

    /// <summary>
    /// 使用次数
    /// </summary>
    [Required]
    public int UsageCount { get; set; }

    /// <summary>
    /// 当前使用次数
    /// </summary>
    [Required]
    public int CurrentUsageCount { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string Status { get; set; }
}