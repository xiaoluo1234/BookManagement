using Arim.Infrastructure;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】常量
/// </summary>
public static class EquipmentConstants
{
    /// <summary>
    /// 默认值
    /// </summary>
    public class DefaultValue
    {
        /// <summary>
        /// 版本的默认值
        /// </summary>
        public const int Version = 1;

        /// <summary>
        /// 状态的默认值
        /// </summary>
        public const string Status = ArimConstants.Status.Created;

        /// <summary>
        /// 是否激活的默认值
        /// </summary>
        public const bool IsActive = false;
    }

    /// <summary>
    /// 最大长度限制
    /// </summary>
    public class MaxLength
    {
        /// <summary>
        /// 【编码】的最大长度限制
        /// </summary>
        public const int Code = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【显示名称】的最大长度限制
        /// </summary>
        public const int DisplayText = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【规格型号】的最大长度限制
        /// </summary>
        public const int SpecificationCode = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【种类】的最大长度限制
        /// </summary>
        public const int Kind = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【级别】的最大长度限制
        /// </summary>
        public const int Level = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【责任单位】的最大长度限制
        /// </summary>
        public const int ResponsibleUnitName = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【责任人】的最大长度限制
        /// </summary>
        public const int ResponsiblePersonName = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【制造商】的最大长度限制
        /// </summary>
        public const int ManufacturerName = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【设备使用状态】的最大长度限制
        /// </summary>
        public const int UsageStatus = ArimConstants.StringLength.Default;

        public const int Status = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【图片地址】的最大长度限制
        /// </summary>
        public const int ResourceJosn = 5000;

        /// <summary>
        /// 【描述】的最大长度限制
        /// </summary>
        public const int Remark = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【类型】的最大长度限制
        /// </summary>
        public const int EquipmentTypeCode = ArimConstants.StringLength.Medium;

        /// <summary>
        /// 【产品Id】的最大长度限制
        /// </summary>
        public const int ProductId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【安装位置】的最大长度限制
        /// </summary>
        public const int LocationId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【责任单位Id】的最大长度限制
        /// </summary>
        public const int ResponsibleUnitId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【责任人Id】的最大长度限制
        /// </summary>
        public const int ResponsiblePersonId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【制造商Id】的最大长度限制
        /// </summary>
        public const int ManufacturerId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【父设备】的最大长度限制
        /// </summary>
        public const int ParentId = ArimConstants.StringLength.Default;

        /// <summary>
        /// 【顺序值】的最大长度限制
        /// </summary>
        public const int Rank = ArimConstants.StringLength.Medium;
    }
}
