using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhaseParameter
    {
        public int PhaseParameterId { get; set; }
        public int PhaseId { get; set; }
        public string? CompoundNameDeleteMe { get; set; }
        public int? StageDeleteMe { get; set; }
        public int? PhaseDeleteMe { get; set; }
        public string PhaseParameterType { get; set; } = null!;
        public decimal PhaseParameterValue { get; set; }

        public virtual Phase Phase { get; set; } = null!;
        public virtual PhaseParameterType PhaseParameterTypeNavigation { get; set; } = null!;
    }
}
