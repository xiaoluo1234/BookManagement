using System.ComponentModel.DataAnnotations;
using static Arim.Infrastructure.EntityExtension.EntityProperties.EntityPropertyConst;

namespace Arim.Ims.Equipments.Equipments
{
    public class EquipmentPropertyUpdateInput
    {
        [Required]
        public ValueKind ValueKind { get; set; }

        public string? Value { get; set; }

        public float? MaxValue { get; set; }

        public float? MinValue { get; set; }

        public string? Remark { get; set; }

        public int Rank { get; set; } = 0;
    }
}
