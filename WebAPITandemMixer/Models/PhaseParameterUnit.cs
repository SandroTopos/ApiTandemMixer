using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseParameterUnit
    {
        public PhaseParameterUnit()
        {
            PhaseParameterTypes = new HashSet<PhaseParameterType>();
        }

        public string PhaseParameterUnit1 { get; set; } = null!;

        public virtual ICollection<PhaseParameterType> PhaseParameterTypes { get; set; }
    }
}
