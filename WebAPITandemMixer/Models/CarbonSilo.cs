using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class CarbonSilo
    {
        public int? DayBin { get; set; }
        public int? Silo { get; set; }
        public string? Material { get; set; }
        public string? Notes { get; set; }
        public int? Active { get; set; }
    }
}
