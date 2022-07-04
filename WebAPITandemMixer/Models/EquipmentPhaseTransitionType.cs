using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EquipmentPhaseTransitionType
    {
        public string EquipmentType { get; set; } = null!;
        public string PhaseType { get; set; } = null!;
        public string TransitionType { get; set; } = null!;

        public virtual EquipmentType EquipmentTypeNavigation { get; set; } = null!;
        public virtual PhaseType PhaseTypeNavigation { get; set; } = null!;
        public virtual TransitionType TransitionTypeNavigation { get; set; } = null!;
    }
}
