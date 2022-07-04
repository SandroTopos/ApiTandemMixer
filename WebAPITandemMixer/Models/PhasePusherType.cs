using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhasePusherType
    {
        public PhasePusherType()
        {
            PhasePushers = new HashSet<PhasePusher>();
        }

        public short PhasePusherTypeId { get; set; }
        public string PhasePusherTypeName { get; set; } = null!;

        public virtual ICollection<PhasePusher> PhasePushers { get; set; }
    }
}
