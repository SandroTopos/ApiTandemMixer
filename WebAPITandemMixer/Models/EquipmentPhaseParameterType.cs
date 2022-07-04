using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EquipmentPhaseParameterType
    {
        public string EquipmentType { get; set; } = null!;
        public string PhaseType { get; set; } = null!;
        public string PhaseParameterType { get; set; } = null!;

        public virtual EquipmentType EquipmentTypeNavigation { get; set; } = null!;
        public virtual PhaseParameterType PhaseParameterTypeNavigation { get; set; } = null!;
        public virtual PhaseType PhaseTypeNavigation { get; set; } = null!;
    }
}
