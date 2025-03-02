using Arim.Infrastructure.EntityExtension.EntityProperties;

namespace Arim.Ims.Equipments.Equipments
{
    public class EquipmentPropertyDto : EntityPropertyDto
    {
        /// <summary>
        /// 采集点编码
        /// </summary>
        public string TagCode { get; set; }

        /// <summary>
        /// 采集点名称
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 是否多个值
        /// </summary>
        public bool Multiple { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        public string DataSource { get; set; }
    }
}
