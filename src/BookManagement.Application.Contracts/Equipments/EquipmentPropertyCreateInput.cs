using System.ComponentModel.DataAnnotations;
using static Arim.Infrastructure.EntityExtension.EntityProperties.EntityPropertyConst;

namespace Arim.Ims.Equipments.Equipments
{
    public class EquipmentPropertyCreateInput
    {
        [Required]
        public string PropertyCode { get; set; }

        public ValueKind ValueKind { get; set; } = ValueKind.Constant;

        public string? EntityType { get; set; }

        public string Value { get; set; }

        public float? MaxValue { get; set; }

        public float? MinValue { get; set; }

        public string? Remark { get; set; }

        public int Rank { get; set; } = 0;
    }
}
