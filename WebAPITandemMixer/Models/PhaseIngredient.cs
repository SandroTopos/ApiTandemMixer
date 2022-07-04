using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseIngredient
    {
        public int PhaseIngredientId { get; set; }
        public int PhaseId { get; set; }
        public string Ingredient { get; set; } = null!;
        public string IngredientLocation { get; set; } = null!;
        public decimal IngredientAmount { get; set; }
        public string IngredientTimingType { get; set; } = null!;
        public decimal IngredientTimingValue { get; set; }
        public virtual Ingredient IngredientNavigation { get; set; } = null!;
        public virtual IngredientTiming IngredientTimingTypeNavigation { get; set; } = null!;
        public virtual Phase Phase { get; set; } = null!;
    }
}
