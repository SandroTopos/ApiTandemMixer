using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseCheck
    {
        public int PhaseCheckId { get; set; }
        public int PhaseId { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int CheckTime { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }

        public virtual Phase Phase { get; set; } = null!;
        public virtual PhaseCheckType TypeNavigation { get; set; } = null!;
    }
}
