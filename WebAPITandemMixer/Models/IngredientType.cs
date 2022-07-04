using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientType
    {
        public IngredientType()
        {
            Ingredients = new HashSet<Ingredient>();
            EquipmentTypes = new HashSet<EquipmentType>();
        }

        public string IngredientType1 { get; set; } = null!;
        public decimal LowToleranceRange { get; set; }
        public decimal MidToleranceRange { get; set; }
        public decimal LowToleranceAbsLbs { get; set; }
        public decimal MidToleranceAbsLbs { get; set; }
        public decimal HighToleranceAbsLbs { get; set; }
        public decimal LowTolerancePercent { get; set; }
        public decimal MidTolerancePercent { get; set; }
        public decimal HighTolerancePercent { get; set; }
        public int IngredientSortOrder { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
    }
}
