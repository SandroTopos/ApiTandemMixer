using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientLocation
    {
        public IngredientLocation()
        {
            IngredientLocationValids = new HashSet<IngredientLocationValid>();
        }

        public int IngredientLocationId { get; set; }
        public string IngredientLocation1 { get; set; } = null!;
        public int IngredientLocationIndex { get; set; }

        public virtual ICollection<IngredientLocationValid> IngredientLocationValids { get; set; }
    }
}
