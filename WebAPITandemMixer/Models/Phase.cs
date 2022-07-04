using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Phase
    {
        public Phase()
        {
            PhaseChecks = new HashSet<PhaseCheck>();
            PhaseIngredients = new HashSet<PhaseIngredient>();
            PhaseMixSpeeds = new HashSet<PhaseMixSpeed>();
            PhaseParameters = new HashSet<PhaseParameter>();
            PhasePushers = new HashSet<PhasePusher>();
            PhaseRamControls = new HashSet<PhaseRamControl>();
            PhaseTransitions = new HashSet<PhaseTransition>();
        }

        public int PhaseId { get; set; }
        public string CompoundName { get; set; } = null!;
        public int Stage { get; set; }
        public int Phase1 { get; set; }
        public string PhaseType { get; set; } = null!;

        public virtual PhaseType PhaseTypeNavigation { get; set; } = null!;
        public virtual PhaseHoldParameter PhaseHoldParameter { get; set; } = null!;
        public virtual ICollection<PhaseCheck> PhaseChecks { get; set; }
        public virtual ICollection<PhaseIngredient> PhaseIngredients { get; set; }
        public virtual ICollection<PhaseMixSpeed> PhaseMixSpeeds { get; set; }
        public virtual ICollection<PhaseParameter> PhaseParameters { get; set; }
        public virtual ICollection<PhasePusher> PhasePushers { get; set; }
        public virtual ICollection<PhaseRamControl> PhaseRamControls { get; set; }
        public virtual ICollection<PhaseTransition> PhaseTransitions { get; set; }
    }
}
