using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemParameter
    {
        public string ParameterName { get; set; } = null!;
        public string ParameterValue { get; set; } = null!;
        public DateTime ParameterChanged { get; set; }
    }
}
