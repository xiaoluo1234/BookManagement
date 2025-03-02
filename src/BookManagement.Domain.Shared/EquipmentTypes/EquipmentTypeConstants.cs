using Arim.Infrastructure;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】常量
/// </summary>
public static class EquipmentTypeConstants
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
        /// 【顺序值】的最大长度限制
        /// </summary>

        /// <summary>
        /// 【描述】的最大长度限制
        /// </summary>
        public const int Remark = ArimConstants.StringLength.Default;
    }
}
