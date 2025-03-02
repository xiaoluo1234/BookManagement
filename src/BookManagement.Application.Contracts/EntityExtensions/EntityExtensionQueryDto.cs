using Arim.DynamicQuery.Core.Filtering;
using Arim.DynamicQuery.Domain.Shared.Paging;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Arim.Ims.Equipments.EntityExtensions
{
    public class EntityExtensionQueryDto : PagedAndSortedResultRequestDto, IFilterable, IHasIsPage
    {
        public IEnumerable<FilterCriteria> Filters { get; set; } = new List<FilterCriteria>();

        public bool IsPage { get; set; }
    }
}
