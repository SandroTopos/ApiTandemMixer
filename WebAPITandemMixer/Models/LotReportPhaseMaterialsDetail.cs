using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LotReportPhaseMaterialsDetail
    {
        public long PhaseMaterialsDetailsId { get; set; }
        public int LotNumber { get; set; }
        public short EventArea { get; set; }
        public int BatchNumber { get; set; }
        public int PhaseNumber { get; set; }
        public int? PhaseType { get; set; }
        public float? Slab1Weight { get; set; }
        public float? Slab2Weight { get; set; }
        public float? Bale1Weight { get; set; }
        public float? Bale2Weight { get; set; }
        public float? Bale3Weight { get; set; }
        public float? Bale4Weight { get; set; }
        public float? TmaWeight { get; set; }
        public float? CanDump1Weight { get; set; }
        public float? PitchPack1Weight { get; set; }
        public float? PitchPack2Weight { get; set; }
        public float? PitchPack3Weight { get; set; }
        public float? PitchPack4Weight { get; set; }
        public float? PitchPack5Weight { get; set; }
        public float? PitchPack6Weight { get; set; }
        public float? PitchPack7Weight { get; set; }
        public float? PitchPack8Weight { get; set; }
        public float? PitchPack9Weight { get; set; }
        public float? PitchPack10Weight { get; set; }
        public float? Carbon1Weight { get; set; }
        public float? Carbon2Weight { get; set; }
        public float? Carbon3Weight { get; set; }
        public float? Carbon4Weight { get; set; }
        public float? Carbon5Weight { get; set; }
        public float? Pigment1Weight { get; set; }
        public float? Pigment2Weight { get; set; }
        public float? Pigment3Weight { get; set; }
        public float? Pigment4Weight { get; set; }
        public float? Pigment5Weight { get; set; }
        public float? Oil1Weight { get; set; }
        public float? Oil2Weight { get; set; }
        public float? Oil3Weight { get; set; }
        public float? Oil4Weight { get; set; }
        public float? Oil5Weight { get; set; }
        public float? Oil6Weight { get; set; }
    }
}
