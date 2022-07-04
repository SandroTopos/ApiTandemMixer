using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class MixSpeedType
    {
        public MixSpeedType()
        {
            PhaseMixSpeeds = new HashSet<PhaseMixSpeed>();
        }

        public string MixSpeedType1 { get; set; } = null!;

        public virtual ICollection<PhaseMixSpeed> PhaseMixSpeeds { get; set; }
    }
}
