using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseMixSpeed
    {
        public int PhaseMixSpeedId { get; set; }
        public int PhaseId { get; set; }
        public string? CompoundNameDeleteMe { get; set; }
        public int? StageDeleteMe { get; set; }
        public int? PhaseDeleteMe { get; set; }
        public string MixSpeedType { get; set; } = null!;
        public int MixSpeedIndex { get; set; }
        public string MixSpeedValue { get; set; } = null!;

        public virtual MixSpeedType MixSpeedTypeNavigation { get; set; } = null!;
        public virtual Phase Phase { get; set; } = null!;
    }
}
