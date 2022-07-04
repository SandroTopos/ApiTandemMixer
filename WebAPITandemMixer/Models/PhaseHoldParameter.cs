using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseHoldParameter
    {
        public int PhaseHoldParameterId { get; set; }
        public int PhaseId { get; set; }
        public decimal MixTempTarget { get; set; }
        public decimal MixTempMinimum { get; set; }
        public decimal MixTempMaximum { get; set; }
        public decimal MixSpeedTarget { get; set; }
        public decimal MixSpeedMinimum { get; set; }
        public decimal MixSpeedMaximum { get; set; }

        public virtual Phase Phase { get; set; } = null!;
    }
}
