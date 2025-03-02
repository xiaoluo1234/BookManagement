using Arim.Ims.Equipments.EntityExtensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Arim.Ims.Equipments.EquipmentTypes;

/// <summary>
/// 【设备类型】查询参数
/// </summary>
[Serializable]
public class EquipmentTypeGetListInput : PropertyPagedAndSortedResultRequestDto
{
    /// <summary>
    /// 【编码】精准查询
    /// </summary>
    [StringLength(EquipmentTypeConstants.MaxLength.Code)]
    public string? Code { get; set; }

    /// <summary>
    /// 【关键字】模糊查询
    /// </summary>
    public string? Keyword { get; set; }

    /// <summary>
    /// 【显示名称】精准查询
    /// </summary>
    [StringLength(EquipmentTypeConstants.MaxLength.DisplayText)]
    public string? DisplayText { get; set; }

    public bool? IsStatic { get; set; }


}