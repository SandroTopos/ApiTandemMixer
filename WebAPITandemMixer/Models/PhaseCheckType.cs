using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseCheckType
    {
        public PhaseCheckType()
        {
            PhaseChecks = new HashSet<PhaseCheck>();
        }

        public string Type { get; set; } = null!;
        public int TypeId { get; set; }

        public virtual ICollection<PhaseCheck> PhaseChecks { get; set; }
    }
}
