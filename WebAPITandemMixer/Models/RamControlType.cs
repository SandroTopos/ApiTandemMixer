using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class RamControlType
    {
        public RamControlType()
        {
            PhaseRamControls = new HashSet<PhaseRamControl>();
        }

        public string RamControlType1 { get; set; } = null!;

        public virtual ICollection<PhaseRamControl> PhaseRamControls { get; set; }
    }
}
