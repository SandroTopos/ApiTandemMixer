using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseRamControl
    {
        public int PhaseRamControlId { get; set; }
        public int PhaseId { get; set; }
        public string? CompoundNameDeleteMe { get; set; }
        public int? StageDeleteMe { get; set; }
        public int? PhaseDeleteMe { get; set; }
        public string RamControlType { get; set; } = null!;
        public int RamControlIndex { get; set; }
        public string RamControlValue { get; set; } = null!;

        public virtual Phase Phase { get; set; } = null!;
        public virtual RamControlType RamControlTypeNavigation { get; set; } = null!;
    }
}
