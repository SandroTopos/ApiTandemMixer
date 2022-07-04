using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientLocationValids = new HashSet<IngredientLocationValid>();
            PhaseIngredients = new HashSet<PhaseIngredient>();
        }

        public string Ingredient1 { get; set; } = null!;
        public string IngredientType { get; set; } = null!;

        public virtual IngredientType IngredientTypeNavigation { get; set; } = null!;
        public virtual ICollection<IngredientLocationValid> IngredientLocationValids { get; set; }
        public virtual ICollection<PhaseIngredient> PhaseIngredients { get; set; }
    }
}
