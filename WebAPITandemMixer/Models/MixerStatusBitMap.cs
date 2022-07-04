using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class MixerStatusBitMap
    {
        public short MixerStatusBitNumber { get; set; }
        public long MixerStatusBitValue { get; set; }
        public string? MixerStatusMessageText { get; set; }
        public string MixerStatusMessageOn { get; set; } = null!;
        public string MixerStatusMessageOff { get; set; } = null!;
        public bool IsMixerStatusEnabled { get; set; }
    }
}
