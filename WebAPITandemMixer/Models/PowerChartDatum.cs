using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PowerChartDatum
    {
        public float? TopMixerTimeInSeconds { get; set; }
        public float? TopMixerGateTopTempDriveSide { get; set; }
        public float? TopMixerGateTopTempWaterSide { get; set; }
        public float? TopMixerKwfromDrive { get; set; }
        public float? TopMixerKwh { get; set; }
        public float? RamPosition { get; set; }
        public float? RamWorkingPressure { get; set; }
        public float? TopMixerBatchNumber { get; set; }
        public DateTime? PlcTime { get; set; }
        public float? LotNumber { get; set; }
    }
}
