using System;
using Volo.Abp;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Entities;
using static BookManagement.SharedConsts;

namespace BookManagement.Equipments
{
    /// <summary>
    /// 设备定义 定义一个设备
    /// </summary>
    [CacheName(nameof(Equipment))]
    public class Equipment : Entity<Guid>
    {
        #region Prop

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayText { get; private set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string? EquipmentTypeCode { get; private set; }

        /// <summary>
        /// 产品Id
        /// </summary>
        public Guid? ProductId { get; private set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string? SpecificationCode { get; private set; }

        /// <summary>
        /// 种类
        /// </summary>
        public string? Kind { get; private set; }

        /// <summary>
        /// 安装位置Id
        /// </summary>
        public Guid? LocationId { get; private set; }

        /// <summary>
        /// 级别
        /// </summary>
        public string Level { get; private set; } = EquipmentLevel.Normal;

        /// <summary>
        /// 责任单位
        /// </summary>
        public string? ResponsibleUnitName { get; private set; }

        /// <summary>
        /// 责任单位Id
        /// </summary>
        public Guid? ResponsibleUnitId { get; private set; }

        /// <summary>
        /// 责任人
        /// </summary>
        public string? ResponsiblePersonName { get; private set; }

        /// <summary>
        /// 责任人Id
        /// </summary>
        public Guid? ResponsiblePersonId { get; private set; }

        /// <summary>
        /// 制造商
        /// </summary>
        public string? ManufacturerName { get; private set; }

        /// <summary>
        /// 制造商Id
        /// </summary>
        public Guid? ManufacturerId { get; private set; }

        /// <summary>
        /// 设备使用状态
        /// </summary>
        public string? UsageStatus { get; private set; }

        /// <summary>
        /// 安装时间
        /// </summary>
        public DateTime? SetupTime { get; private set; }

        /// <summary>
        /// 上线时间
        /// </summary>
        public DateTime? OnlineTime { get; private set; }

        /// <summary>
        /// 父设备
        /// </summary>
        public Guid? ParentId { get; private set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string? ResourceJson { get; private set; }

        /// <summary>
        /// 是否静态
        /// </summary>
        public bool IsStatic { get; private set; }

        /// <summary>
        /// 顺序值
        /// </summary>
        public int Rank { get; private set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string? Remark { get; private set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public float? Latitude { get; private set; }

        /// <summary>
        /// 经度
        /// </summary>
        public float? Longitude { get; private set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string? Status { get; private set; }

        /// <summary>
        /// 是否封锁
        /// </summary>
        public bool Blocked { get; private set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int UsageCount { get; private set; }

        /// <summary>
        /// 当前使用次数
        /// </summary>
        public int CurrentUsageCount { get; private set; }
        #endregion

        #region Ctor

        /// <summary>
        /// 设备定义 定义一个设备
        /// </summary>
        protected Equipment()
        {
        }

        /// <summary>
        /// 设备定义 定义一个设备
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="displayText">显示名称</param>
        /// <param name="equipmentTypeCode">类型</param>
        /// <param name="productId">产品Id</param>
        /// <param name="spec">规格型号</param>
        /// <param name="kind">种类</param>
        /// <param name="locationId">安装位置Id</param>
        /// <param name="level">级别</param>
        /// <param name="responsibleUnitName">责任单位</param>
        /// <param name="responsibleUnitId">责任单位Id</param>
        /// <param name="responsiblePersonName">责任人</param>
        /// <param name="responsiblePersonId">责任人Id</param>
        /// <param name="manufacturerName">制造商</param>
        /// <param name="manufacturerId">制造商Id</param>
        /// <param name="usageStatus">设备使用状态</param>
        /// <param name="setupTime">安装时间</param>
        /// <param name="onlineTime">上线时间</param>
        /// <param name="parentId">父设备</param>
        /// <param name="resourceJson">资源对象</param>
        /// <param name="isStatic">是否静态</param>
        /// <param name="rank">顺序值</param>
        /// <param name="remark">描述</param>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <param name="status">状态</param>
        /// <param name="blocked">是否封锁</param>
        /// <param name="currentUsageCount">当前使用次数</param>
        /// <param name="usageCount">使用次数</param>

        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment(
            Guid id,
            string code,
            string displayText,
            string level,
            bool isStatic,
            int rank,
            string? equipmentTypeCode = null,
            Guid? productId = null,
            string? spec = null,
            Guid? locationId = null,
            string? responsibleUnitName = null,
            Guid? responsibleUnitId = null,
            string? responsiblePersonName = null,
            Guid? responsiblePersonId = null,
            string? manufacturerName = null,
            Guid? manufacturerId = null,
            string? usageStatus = null,
            DateTime? setupTime = null,
            DateTime? onlineTime = null,
            Guid? parentId = null,
            string? resourceJson = null,
            string? remark = null,
            float? longitude = null,
            float? latitude = null,
            string? status = null,
            string? kind = null,
            int currentUsageCount = 0,
            int usageCount = 0,
            bool blocked = false
        ) : base(id)
        {
            SetCode(code)
            .SetDisplayText(displayText)
            .SetLevel(level)
            .SetIsStatic(isStatic)
            .SetRank(rank)
            .SetCurrentUsageCount(currentUsageCount)
            .SetUsageCount(usageCount)
            .SetBlocked(blocked)
            .SetEquipmentTypeCode(equipmentTypeCode)
            .SetProductId(productId)
            .SetSpec(spec)
            .SetLocationId(locationId)
            .SetResponsibleUnit(responsibleUnitName)
            .SetResponsibleUnitId(responsibleUnitId)
            .SetResponsiblePersonName(responsiblePersonName)
            .SetResponsiblePersonId(responsiblePersonId)
            .SetManufacturerName(manufacturerName)
            .SetManufacturerId(manufacturerId)
            .SetUsageStatus(usageStatus)
            .SetSetupTime(setupTime)
            .SetOnlineTime(onlineTime)
            .SetParentId(parentId)
            .SetResourceJson(resourceJson)
            .SetRemark(remark)
            .SetLongitude(longitude)
            .SetLatitude(latitude)
            .SetStatus(status)
            .SetKind(kind);
        }
        #endregion

        #region Method

        /// <summary>
        /// 设置编码
        /// </summary>
        /// <param name="code">编码</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetCode(string code)
        {
            Code = Check.Length(code, nameof(code), EquipmentConstants.MaxLength.Code);
            return this;
        }

        /// <summary>
        /// 设置显示名称
        /// </summary>
        /// <param name="displayText">显示名称</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetDisplayText(string displayText)
        {
            DisplayText = Check.Length(displayText, nameof(displayText), EquipmentConstants.MaxLength.DisplayText);
            return this;
        }
        public Equipment SetStatus(string? status)
        {
            Status = status;
            return this;
        }
        public Equipment SetBlocked(bool blocked)
        {
            Blocked = blocked;
            return this;
        }
        public Equipment SetUsageCount(int usageCount)
        {
            UsageCount = usageCount;
            return this;
        }
        /// <summary>
        /// 设置类型
        /// </summary>
        /// <param name="equipmentTypeCode">类型</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetEquipmentTypeCode(string? equipmentTypeCode)
        {
            EquipmentTypeCode = equipmentTypeCode;
            return this;
        }

        /// <summary>
        /// 设置产品Id
        /// </summary>
        /// <param name="productId">产品Id</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetProductId(Guid? productId)
        {
            ProductId = productId;
            return this;
        }

        /// <summary>
        /// 设置规格型号
        /// </summary>
        /// <param name="spec">规格型号</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetSpec(string? spec)
        {
            SpecificationCode = Check.Length(spec, nameof(spec), EquipmentConstants.MaxLength.SpecificationCode);
            return this;
        }

        /// <summary>
        /// 设置种类
        /// </summary>
        /// <param name="kind">种类</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetKind(string? kind)
        {
            Kind = kind;
            return this;
        }

        /// <summary>
        /// 设置安装位置Id
        /// </summary>
        /// <param name="locationId">安装位置Id</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetLocationId(Guid? locationId)
        {
            LocationId = locationId;
            return this;
        }

        /// <summary>
        /// 设置级别
        /// </summary>
        /// <param name="level">级别</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetLevel(string? level)
        {
            if (level.IsNullOrWhiteSpace())
            {
                Level = EquipmentLevel.Normal;
            }
            else
            {
                Level = Check.Length(level, nameof(level), EquipmentConstants.MaxLength.Level);
            }
            return this;
        }

        /// <summary>
        /// 设置责任单位
        /// </summary>
        /// <param name="responsibleUnit">责任单位</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetResponsibleUnit(string? responsibleUnit)
        {
            ResponsibleUnitName = Check.Length(responsibleUnit, nameof(responsibleUnit), EquipmentConstants.MaxLength.ResponsibleUnitName);
            return this;
        }

        /// <summary>
        /// 设置责任单位Id
        /// </summary>
        /// <param name="responsibleUnitId">责任单位Id</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetResponsibleUnitId(Guid? responsibleUnitId)
        {
            ResponsibleUnitId = responsibleUnitId;
            return this;
        }

        /// <summary>
        /// 设置责任人
        /// </summary>
        /// <param name="responsiblePersonName">责任人</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetResponsiblePersonName(string? responsiblePersonName)
        {
            ResponsiblePersonName = Check.Length(responsiblePersonName, nameof(responsiblePersonName), EquipmentConstants.MaxLength.ResponsiblePersonName);
            return this;
        }

        /// <summary>
        /// 设置责任人Id
        /// </summary>
        /// <param name="responsiblePersonId">责任人Id</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetResponsiblePersonId(Guid? responsiblePersonId)
        {
            ResponsiblePersonId = responsiblePersonId;
            return this;
        }

        /// <summary>
        /// 设置制造商
        /// </summary>
        /// <param name="manufacturer">制造商</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetManufacturerName(string? manufacturer)
        {
            ManufacturerName = Check.Length(manufacturer, nameof(manufacturer), EquipmentConstants.MaxLength.ManufacturerName);
            return this;
        }

        /// <summary>
        /// 设置制造商Id
        /// </summary>
        /// <param name="manufacturerId">制造商Id</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetManufacturerId(Guid? manufacturerId)
        {
            ManufacturerId = manufacturerId;
            return this;
        }

        /// <summary>
        /// 设置设备使用状态
        /// </summary>
        /// <param name="usageStatus">设备使用状态</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetUsageStatus(string? usageStatus)
        {
            UsageStatus = Check.Length(usageStatus, nameof(usageStatus), EquipmentConstants.MaxLength.UsageStatus);
            return this;
        }

        /// <summary>
        /// 设置安装时间
        /// </summary>
        /// <param name="setupTime">安装时间</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetSetupTime(DateTime? setupTime)
        {
            SetupTime = setupTime;
            return this;
        }

        /// <summary>
        /// 设置父设备
        /// </summary>
        /// <param name="parentId">父设备</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetParentId(Guid? parentId)
        {
            ParentId = parentId;
            return this;
        }

        /// <summary>
        /// 设置图片地址
        /// </summary>
        /// <param name="imageUrls">图片地址</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetResourceJson(string? imageUrls)
        {
            ResourceJson = Check.Length(imageUrls, nameof(imageUrls), EquipmentConstants.MaxLength.ResourceJosn);
            return this;
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="isStatic"></param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetIsStatic(bool isStatic)
        {
            IsStatic = isStatic;
            return this;
        }

        /// <summary>
        /// 设置顺序值
        /// </summary>
        /// <param name="rank">顺序值</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetRank(int rank)
        {
            Rank = rank;
            return this;
        }

        /// <summary>
        /// 设置描述
        /// </summary>
        /// <param name="remark">描述</param>
        /// <returns>设备定义 定义一个设备实例</returns>
        public Equipment SetRemark(string? remark)
        {
            Remark = Check.Length(remark, nameof(remark), EquipmentConstants.MaxLength.Remark);
            return this;
        }
        /// <summary>
        /// 设置纬度
        /// </summary>
        /// <param name="latitude">纬度</param>
        /// <returns>EquipmentLocationDto实例</returns>
        public Equipment SetLatitude(float? latitude)
        {
            Latitude = latitude;
            return this;
        }

        /// <summary>
        /// 设置经度
        /// </summary>
        /// <param name="longitude">经度</param>
        /// <returns>EquipmentLocationDto实例</returns>
        public Equipment SetLongitude(float? longitude)
        {
            Longitude = longitude;
            return this;
        }

        /// <summary>
        /// 设置上线时间
        /// </summary>
        /// <param name="onlineTime"></param>
        /// <returns>EquipmentLocationDto实例</returns>
        public Equipment SetOnlineTime(DateTime? onlineTime)
        {
            OnlineTime = onlineTime;
            return this;
        }

        /// <summary>
        /// 设置当前使用次数
        /// </summary>
        /// <param name="currentUsageCount"></param>
        /// <returns>EquipmentLocationDto实例</returns>
        public Equipment SetCurrentUsageCount(int currentUsageCount)
        {
            CurrentUsageCount = currentUsageCount;
            return this;
        }
        #endregion
    }

}
