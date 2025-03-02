using System;
using System.ComponentModel.DataAnnotations;

namespace Arim.Ims.Equipments.EquipmentTypes;

[Serializable]
public class EquipmentTypeCreateInput
{
    /// <summary>
    /// 编码
    /// </summary>
    [StringLength(EquipmentTypeConstants.MaxLength.Code)]
    public string? Code { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    [StringLength(EquipmentTypeConstants.MaxLength.DisplayText)]
    public string? DisplayText { get; set; }

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
    [StringLength(EquipmentTypeConstants.MaxLength.Remark)]
    public string? Remark { get; set; }
}