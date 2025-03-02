using System;

namespace BookManagement.Equipments;
public class EquipmentEdto
{
    /// <summary>
    /// 编码
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string DisplayText { get; set; }

    /// <summary>
    /// 规格型号
    /// </summary>
    public string SpecificationCode { get; set; }

    /// <summary>
    /// 类型编码
    /// </summary>
    public string EquipmentTypeCode { get; set; }

    /// <summary>
    /// 等级
    /// </summary>
    public string Level { get; set; }

    /// <summary>
    /// 制造商
    /// </summary>
    public string ManufacturerName { get; set; }

    /// <summary>
    /// 设备使用状态
    /// </summary>
    public string UsageStatus { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// 安装时间
    /// </summary>
    public DateTime SetupTime { get; set; }

    /// <summary>
    /// 上线时间
    /// </summary>
    public DateTime OnlineTime { get; set; }

    /// <summary>
    /// 使用次数
    /// </summary>
    public int UsageCount { get; set; }

    /// <summary>
    /// 责任人
    /// </summary>
    public string ResponsiblePersonName { get; set; }

    /// <summary>
    /// 当前使用次数
    /// </summary>
    public int CurrentUsageCount { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Remark { get; set; }
}
