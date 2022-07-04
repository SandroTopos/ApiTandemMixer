using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class CompoundVariableMapping
    {
        public int CompoundVariableId { get; set; }
        public string CompoundVariableColumnName { get; set; } = null!;
        public string CompoundVariableName { get; set; } = null!;
        public short CompoundVariableOrder { get; set; }
        public bool? IsValidateLimitsEnabled { get; set; }
        public bool? IsSetDefaultValue { get; set; }
        public bool? IsVariableTypeInt { get; set; }
        public bool IsVariableTypeDecimal { get; set; }
        public bool IsVariableTypeString { get; set; }
        public string? GlobalSettingNameMinLimit { get; set; }
        public string? GlobalSettingNameMaxLimit { get; set; }
        public string? GlobalSettingNameDefaultValue { get; set; }
    }
}
