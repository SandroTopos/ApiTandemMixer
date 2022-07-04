using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientTiming
    {
        public IngredientTiming()
        {
            PhaseIngredients = new HashSet<PhaseIngredient>();
        }

        public string IngredientTimingType { get; set; } = null!;
        public int IngredientTimingTypeId { get; set; }

        public virtual ICollection<PhaseIngredient> PhaseIngredients { get; set; }
    }
}
