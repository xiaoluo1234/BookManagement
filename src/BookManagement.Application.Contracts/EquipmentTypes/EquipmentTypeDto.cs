using Arim.Ims.Equipments.Equipments;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

#pragma warning disable CS8618 

namespace Arim.Ims.Equipments.EquipmentTypes;

/// <summary>
/// 【设备类型】信息
/// </summary>
[Serializable]
public class EquipmentTypeDto : EntityDto<Guid>
{
    /// <summary>
    /// 编码
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    public string? DisplayText { get; set; }

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
    /// 属性
    /// </summary>
    public List<EquipmentPropertyDto> Properties { get; set; }
}