namespace BookManagement;

public static class SharedConsts
{

    /// <summary>
    /// 设备在线状态
    /// </summary>
    public class OnlineStatus
    {
        /// <summary>
        /// 在线
        /// </summary>
        public const string Online = "Online";
        /// <summary>
        /// 离线
        /// </summary>
        public const string Offline = "Offline";
    }

    /// <summary>
    /// 设备运行状态
    /// </summary>
    public class RunningStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        public const string Unknown = "Unknown";
        /// <summary>
        /// 运行
        /// </summary>
        public const string Running = "Running";
        /// <summary>
        /// 停止
        /// </summary>
        public const string Stopped = "Stopped";
        /// <summary>
        /// 故障
        /// </summary>
        public const string Error = "Error";
    }

    /// <summary>
    /// 设备使用状态
    /// </summary>
    public class UsageStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const string Normal = "Normal";
        /// <summary>
        /// 维护中
        /// </summary>
        public const string Maintenance = "Maintenance";
        /// <summary>
        /// 已停用
        /// </summary>
        public const string Inactive = "Inactive";
        /// <summary>
        /// 已废弃
        /// </summary>
        public const string Decommissioned = "Decommissioned";
    }

    /// <summary>
    /// 设备级别
    /// </summary>
    public class EquipmentLevel
    {
        /// <summary>
        /// 常规
        /// </summary>
        public const string Normal = "Normal";
        /// <summary>
        /// 重要
        /// </summary>
        public const string Important = "Important";
    }

    /// <summary>
    /// 实体类型
    /// </summary>
    public class PositionEntityType
    {
        /// <summary>
        /// 设备
        /// </summary>
        public const string Device = "Device";

        /// <summary>
        /// 位置定义
        /// </summary>
        public const string Location = "Location";
    }

    /// <summary>
    /// 事件类型
    /// </summary>
    public class EventRecordType
    {
        /// <summary>
        /// 超过上限
        /// </summary>
        public const string GreaterThenMax = "GreaterThenMax";

        /// <summary>
        /// 低于下限
        /// </summary>
        public const string LessThenMin = "LessThenMin";

        /// <summary>
        /// 不等于目标值
        /// </summary>
        public const string NotEqualTarget = "NotEqualTarget";

        /// <summary>
        /// 等于目标值
        /// </summary>
        public const string EqualTarget = "EqualTarget";
    }

    /// <summary>
    /// 事件等级
    /// </summary>
    public class EventRecordLevel
    {
        public const string Info = "Info";

        public const string Warning = "Warning";

        public const string Error = "Error";
    }

    /// <summary>
    /// 事件状态
    /// </summary>
    public class EventRecordStatus
    {
        /// <summary>
        /// 未处理
        /// </summary>
        public const string NotHandle = "NotHandle";

        /// <summary>
        /// 处理中
        /// </summary>
        public const string Processing = "Processing";

        /// <summary>
        /// 已处理
        /// </summary>
        public const string Handled = "Handled";

        /// <summary>
        /// 已忽略
        /// </summary>
        public const string Ignore = "Ignore";
    }
}
