using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionParameter
    {
        public string ActionId { get; set; } = null!;
        public int ParameterIndex { get; set; }
        public string ParameterId { get; set; } = null!;
        public string ParameterValueType { get; set; } = null!;
        public string? ParameterValueKey { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual ActionParameterType ParameterValueTypeNavigation { get; set; } = null!;
    }
}
