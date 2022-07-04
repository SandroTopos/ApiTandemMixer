using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseType
    {
        public PhaseType()
        {
            EquipmentPhaseParameterTypes = new HashSet<EquipmentPhaseParameterType>();
            EquipmentPhaseTransitionTypes = new HashSet<EquipmentPhaseTransitionType>();
            EquipmentTypePhases = new HashSet<EquipmentTypePhase>();
            Phases = new HashSet<Phase>();
        }

        public string PhaseType1 { get; set; } = null!;
        public int PhaseTypeId { get; set; }

        public virtual ICollection<EquipmentPhaseParameterType> EquipmentPhaseParameterTypes { get; set; }
        public virtual ICollection<EquipmentPhaseTransitionType> EquipmentPhaseTransitionTypes { get; set; }
        public virtual ICollection<EquipmentTypePhase> EquipmentTypePhases { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }
    }
}
