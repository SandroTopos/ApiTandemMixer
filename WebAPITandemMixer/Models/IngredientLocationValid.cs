using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientLocationValid
    {
        public string Ingredient { get; set; } = null!;
        public string IngredientLocation { get; set; } = null!;
        public int IngredientLevel { get; set; }

        public virtual IngredientLocation IngredientLocationNavigation { get; set; } = null!;
        public virtual Ingredient IngredientNavigation { get; set; } = null!;
    }
}
