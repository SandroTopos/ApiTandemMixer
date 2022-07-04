using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PhasePusherTimingType
    {
        /// <summary>
        /// Timing: 0=None, 1=Mix Time, 2=Temp, 3=KWH, 4=Phase Time
        /// </summary>
        public string TimingType { get; set; } = null!;
        public int TimingTypeId { get; set; }
    }
}
