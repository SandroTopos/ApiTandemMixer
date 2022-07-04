using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LotReport
    {
        public int LotId { get; set; }
        public string CompoundName { get; set; } = null!;
        public int LotNumber { get; set; }
        public DateTime? DownloadTime { get; set; }
        public DateTime? LotStartTime { get; set; }
        public DateTime? LotEndTime { get; set; }
        public int? CurrentBatchNumber { get; set; }
        public int? NumBatches { get; set; }
        public int? ChuteLevel { get; set; }
        public string? SkidBarcode { get; set; }
        public DateTime? SapProcess { get; set; }
    }
}
