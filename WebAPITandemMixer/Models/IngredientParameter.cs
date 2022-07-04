using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class IngredientParameter
    {
        public string ParameterName { get; set; } = null!;
        public string ParameterValue { get; set; } = null!;
    }
}
