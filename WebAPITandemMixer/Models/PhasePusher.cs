using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhasePusher
    {
        public int PhasePusherId { get; set; }
        public int PhaseId { get; set; }
        public string? CompoundNameDeleteMe { get; set; }
        public int? StageDeleteMe { get; set; }
        public int? PhaseDeleteMe { get; set; }
        public string PusherType { get; set; } = null!;
        public int PusherIndex { get; set; }
        public string PusherValue { get; set; } = null!;

        public virtual Phase Phase { get; set; } = null!;
        public virtual PhasePusherType PusherTypeNavigation { get; set; } = null!;
    }
}
