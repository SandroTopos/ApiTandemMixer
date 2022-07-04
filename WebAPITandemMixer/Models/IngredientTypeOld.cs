using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientTypeOld
    {
        public string IngredientType { get; set; } = null!;
        public decimal LowerTolerance { get; set; }
        public decimal UpperTolerance { get; set; }
        public int IngredientSortOrder { get; set; }
    }
}
