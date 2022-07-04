using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LotReportBatchDetail
    {
        public long BatchDetailsId { get; set; }
        public int LotNumber { get; set; }
        public int? BatchNumber { get; set; }
        public short? EventArea { get; set; }
        public DateTime? BwbStartTime { get; set; }
        /// <summary>
        /// Batch Start Time
        /// </summary>
        public DateTime? MixerStartTime { get; set; }
        public DateTime? ChargeStartTime { get; set; }
        public DateTime? MixStartTime { get; set; }
        public DateTime? DischargeStartTime { get; set; }
        public DateTime? DischargeEndTime { get; set; }
        /// <summary>
        /// Batch End Time
        /// </summary>
        public DateTime? MixerEndTime { get; set; }
        public float? DischargeTemp { get; set; }
        public float? DischargeKWh { get; set; }
        public float? Meq { get; set; }
        public float? FIndex { get; set; }
    }
}
