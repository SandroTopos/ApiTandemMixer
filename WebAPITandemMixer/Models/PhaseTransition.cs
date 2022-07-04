using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseTransition
    {
        public int PhaseTransitionId { get; set; }
        public int PhaseId { get; set; }
        public string? CompoundNameDeleteMe { get; set; }
        public int? StageDeleteMe { get; set; }
        public int? PhaseDeleteMe { get; set; }
        public string Transition { get; set; } = null!;
        public string TransitionType { get; set; } = null!;
        public decimal TransitionValue { get; set; }
        public int TransitionDuration { get; set; }

        public virtual Phase Phase { get; set; } = null!;
        public virtual TransitionType TransitionTypeNavigation { get; set; } = null!;
    }
}
