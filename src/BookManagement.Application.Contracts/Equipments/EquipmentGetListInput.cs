using Arim.Ims.Equipments.EntityExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Arim.Ims.Equipments.Equipments;

/// <summary>
/// 获取设备列表入参
/// </summary>
public class EquipmentGetListInput : PropertyPagedAndSortedResultRequestDto
{
    /// <summary>
    /// 【编码】精准查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.Code)]
    public string? Code { get; set; }
    /// <summary>
    /// 【关键字】模糊查询
    /// </summary>
    public string? Keyword { get; set; }

    /// <summary>
    /// 批量查询
    /// </summary>
    public List<Guid>? Ids { get; set; }
    /// <summary>
    /// 【显示名称】精准查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.DisplayText)]
    public string? DisplayText { get; set; }

    // Ims开发删除EquipmentTypeId，使用Code作查询
    ///// <summary>
    ///// 【类型】精准查询
    ///// </summary>
    //public Guid? EquipmentTypeCode { get; set; }

    public string? EquipmentTypeCode{ get; set; }
    public List<string>? EquipmentTypeCodes { get; set; }
    /// <summary>
    /// 【产品Id】精准查询
    /// </summary>
    public Guid? ProductId { get; set; }
    public string? ProductCode { get; set; }

    /// <summary>
    /// 【规格型号】精准查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.SpecificationCode)]
    public string? SpecificationCode { get; set; }


    /// <summary>
    /// 【种类】精准查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.Kind)]
    public string? Kind { get; set; }
    public List<string>? Kinds { get; set; }

    /// <summary>
    /// 【安装位置Id】精准查询
    /// </summary>
    public Guid? LocationId { get; set; }
    public string? LocationCode { get; set; }

    /// <summary>
    /// 【责任单位】模糊查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ResponsibleUnitName)]
    public string? ResponsibleUnitName { get; set; }

    /// <summary>
    /// 【责任单位Id】精准查询
    /// </summary>
    public Guid? ResponsibleUnitId { get; set; }


    /// <summary>
    /// 【责任人】模糊查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ResponsiblePersonName)]
    public string? ResponsiblePersonName { get; set; }

    /// <summary>
    /// 【责任人Id】精准查询
    /// </summary>
    public Guid? ResponsiblePersonId { get; set; }


    /// <summary>
    /// 【制造商】模糊查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.ManufacturerName)]
    public string? ManufacturerName { get; set; }

    /// <summary>
    /// 【制造商Id】精准查询
    /// </summary>
    public Guid? ManufacturerId { get; set; }


    /// <summary>
    /// 【设备使用状态】模糊查询
    /// </summary>
    [StringLength(EquipmentConstants.MaxLength.UsageStatus)]
    public string? UsageStatusContain { get; set; }

    /// <summary>
    /// 【安装时间】精准查询
    /// </summary>
    public DateTime? SetupTime { get; set; }

    /// <summary>
    /// 【父设备】精准查询
    /// </summary>
    public Guid? ParentId { get; set; }

    public string? Status { get; set; }

    public List<PropertyValueInput>? PropertyValues { get; set; }
    /// <summary>
    /// 分类编码
    /// </summary>
    public string? CategoryCode { get; set; }
    public List<string>? CategoryCodes { get; set; }

    /// <summary>
    /// 包含设备类型
    /// </summary>
    public bool IncludeEquipmentType { get; set; } = false;
    /// <summary>
    /// 包含设备位置
    /// </summary>
    public bool IncludeLocation { get; set; } = false;
    /// <summary>
    /// 包含设备坐标
    /// </summary>
    public bool IncludePosition { get; set; } = false;
    /// <summary>
    /// 包含产品
    /// </summary>
    public bool IncludeProduct { get; set; } = false;
    /// <summary>
    /// 包含制造商
    /// </summary>
    public bool IncludeManufacturer { get; set; } = false;
    /// <summary>
    /// 包含资源
    /// </summary>
    public bool IncludeResources { get; set; } = false;
    /// <summary>
    /// 包含状态快照
    /// </summary>
    public bool IncludeState { get; set; } = false;

    /// <summary>
    /// 包含设备关联关系
    /// </summary>
    public bool IncludeRelations { get; set; } = false;

    /// <summary>
    /// 包含设备分类
    /// </summary>
    public bool IncludeCategories { get; set; } = false;
    /// <summary>
    /// 包含属性信息
    /// </summary>
    public bool IncludeProperties { get; set; } = false;

}
public class PropertyValueInput
{
    public string PropertyCode { get; set; }
    public string PropertyValue { get; set; }

}
public class EquipmentGetInfoInput: EntityExtensionGetListInput
{
    /// <summary>
    /// 包含设备类型
    /// </summary>
    public bool IncludeEquipmentType { get; set; } = false;
    /// <summary>
    /// 包含设备位置
    /// </summary>
    public bool IncludeLocation { get; set; } = false;
    /// <summary>
    /// 包含设备坐标
    /// </summary>
    public bool IncludePosition { get; set; } = false;
    /// <summary>
    /// 包含产品
    /// </summary>
    public bool IncludeProduct { get; set; } = false;
    /// <summary>
    /// 包含制造商
    /// </summary>
    public bool IncludeManufacturer { get; set; } = false;
    /// <summary>
    /// 包含资源
    /// </summary>
    public bool IncludeResources { get; set; } = false;
    /// <summary>
    /// 包含状态快照
    /// </summary>
    public bool IncludeState { get; set; } = false;
    /// <summary>
    /// 包含设备关联关系
    /// </summary>
    public bool IncludeRelations { get; set; } = false;

    /// <summary>
    /// 包含设备分类
    /// </summary>
    public bool IncludeCategories { get; set; } = false;
    /// <summary>
    /// 包含设备属性信息
    /// </summary>
    public bool IncludeProperties { get; set; } = false;
}
