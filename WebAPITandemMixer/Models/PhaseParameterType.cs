using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseParameterType
    {
        public PhaseParameterType()
        {
            EquipmentPhaseParameterTypes = new HashSet<EquipmentPhaseParameterType>();
            PhaseParameters = new HashSet<PhaseParameter>();
        }

        public string PhaseParameterType1 { get; set; } = null!;
        public string PhaseParameterUnit { get; set; } = null!;

        public virtual PhaseParameterUnit PhaseParameterUnitNavigation { get; set; } = null!;
        public virtual ICollection<EquipmentPhaseParameterType> EquipmentPhaseParameterTypes { get; set; }
        public virtual ICollection<PhaseParameter> PhaseParameters { get; set; }
    }
}
