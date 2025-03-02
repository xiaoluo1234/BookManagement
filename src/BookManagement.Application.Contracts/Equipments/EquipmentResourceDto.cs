namespace Arim.Ims.Equipments.Equipments
{
    public class EquipmentResourceSimpleDto
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string? DisplayText { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Url地址
        /// </summary>
        public string? Uri { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string? Kind { get; set; }

        /// <summary>
        /// Url地址
        /// </summary>
        public int? Rank { get; set; }
    }
}
