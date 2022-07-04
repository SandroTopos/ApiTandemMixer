using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EquipmentTypePhase
    {
        public string EquipmentType { get; set; } = null!;
        public string PhaseType { get; set; } = null!;
        public bool? IsHasPhaseParameter { get; set; }
        public bool? IsHasPhaseHoldParameter { get; set; }
        public bool? IsHasPhaseTransition { get; set; }
        public bool? IsHasPhaseCheck { get; set; }
        public bool? IsHasPhaseIngredient { get; set; }
        public bool? IsHasPhaseMixSpeed { get; set; }
        public bool? IsHasPhaseRamControl { get; set; }
        public bool? IsHasPhasePusher { get; set; }

        public virtual EquipmentType EquipmentTypeNavigation { get; set; } = null!;
        public virtual PhaseType PhaseTypeNavigation { get; set; } = null!;
    }
}
