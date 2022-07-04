using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionParameterLog
    {
        public long ActionLogId { get; set; }
        public int ParameterIndex { get; set; }
        public string ParameterId { get; set; } = null!;
        public string ParameterValueType { get; set; } = null!;
        public string ParameterValue { get; set; } = null!;
        public string? ParameterValueKey { get; set; }
        public virtual ActionLog ActionLog { get; set; } = null!;
    }
}
