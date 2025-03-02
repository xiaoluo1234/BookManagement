using System;
using Volo.Abp.Caching;

namespace Arim.Ims.Equipments.EntityExtensions
{

    [CacheName("TagValues")]
    public class TagValueDto
    {
        /// <summary>
        /// 采集点编码
        /// </summary>
        public string TagCode { get; set; }

        /// <summary>
        /// 采集值
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime Clock { get; set; }
    }
}
