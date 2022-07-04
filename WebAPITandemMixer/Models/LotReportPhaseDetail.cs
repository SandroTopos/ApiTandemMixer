using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LotReportPhaseDetail
    {
        public long PhaseDetailsId { get; set; }
        public int LotNumber { get; set; }
        public short EventArea { get; set; }
        public int BatchNumber { get; set; }
        public int PhaseNumber { get; set; }
        public int? PhaseType { get; set; }
        public DateTime? PhaseStartTime { get; set; }
        public DateTime? PhaseEndTime { get; set; }
        public float? PhaseEndTemp { get; set; }
        public float? PhaseEndKwh { get; set; }
        public float? PhaseCheckResults1 { get; set; }
        public float? PhaseCheckResults2 { get; set; }
        public float? PhaseCheckResults3 { get; set; }
        public float? TargetTemperature { get; set; }
        public float? StdTemperature { get; set; }
        public float? AvgDriveSideTemp { get; set; }
        public float? AvgWaterSideTemp { get; set; }
        public float? StdDriveSideTemp { get; set; }
        public float? StdWaterSideTemp { get; set; }
        public float? AverageRpm { get; set; }
        public float? RpmStd { get; set; }
    }
}
