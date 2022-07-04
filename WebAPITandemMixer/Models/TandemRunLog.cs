using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class TandemRunLog
    {
        public string? Mixer { get; set; }
        public int? Ibmnumber { get; set; }
        public string? RunNumber { get; set; }
        public int? SchedBatches { get; set; }
        public decimal? SpecBatchWeight { get; set; }
        public string? Compound { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? TagPrint { get; set; }
        public int? ActualBatches { get; set; }
        public DateTime? Sapusage { get; set; }
    }
}
