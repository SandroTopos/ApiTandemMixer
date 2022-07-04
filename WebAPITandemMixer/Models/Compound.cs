using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Compound
    {
        public int CompoundId { get; set; }
        public string CompoundName { get; set; } = null!;
        public DateTime CompoundVersionDate { get; set; }
        public decimal BatchSize { get; set; }
        public int ChuteLevel { get; set; }
        public int TopMixerBodyTcuz1 { get; set; }
        public int TopMixerRotorsTcuz2 { get; set; }
        public int TopMixerGateTcuz3 { get; set; }
        public int BottomMixerBodyTcuz1 { get; set; }
        public int BottomMixerRotorsTcuz2 { get; set; }
        public int BottomMixerGateTcuz3 { get; set; }
        public int TsrtopRollZ1 { get; set; }
        public int TsrbottomRollZ2 { get; set; }
        public int TsrscrewZ3 { get; set; }
        public int TsrbodyZ4 { get; set; }
        public bool? IsCompoundActive { get; set; }
        public bool IsCompoundLocked { get; set; }
        public string? CompoundNotes { get; set; }
    }
}
