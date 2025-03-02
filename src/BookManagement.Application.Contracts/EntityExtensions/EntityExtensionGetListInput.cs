using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Arim.Ims.Equipments.EntityExtensions
{
    public class EntityExtensionGetListInput : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 属性编码
        /// </summary>
        public List<string>? PropertyCodes { get; set; }
        /// <summary>
        /// 属性类型
        /// </summary>
        public string? PropertyType { get; set; }
        /// <summary>
        /// 属性分类
        /// </summary>
        public string? PropertyCategory { get; set; }

        /// <summary>
        /// 实体ID(Ims中作为设备编码-Code使用)
        /// </summary>
        public string? EntityId { get; set; }

        public IEnumerable<string>? EntityIds { get; set; }

        /// <summary>
        /// 是否分页
        /// </summary>
        public bool IsPage { get; set; } = false;

        /// <summary>
        /// 是否包含属性信息
        /// </summary>
        public bool IsInclude { get; set; } = false;
    }
}
