using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Arim.Ims.Equipments.EntityExtensions
{
    public class PropertyPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 是否分页
        /// </summary>
        public bool IsPage { get; set; } = true;
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
    }
}