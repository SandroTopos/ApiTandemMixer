using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class TransitionType
    {
        public TransitionType()
        {
            EquipmentPhaseTransitionTypes = new HashSet<EquipmentPhaseTransitionType>();
            PhaseTransitions = new HashSet<PhaseTransition>();
        }

        public string TransitionType1 { get; set; } = null!;
        public short? TransitionTypeId { get; set; }

        public virtual ICollection<EquipmentPhaseTransitionType> EquipmentPhaseTransitionTypes { get; set; }
        public virtual ICollection<PhaseTransition> PhaseTransitions { get; set; }
    }
}
