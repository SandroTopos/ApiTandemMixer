using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LotReportPowerChart
    {
        public int PowerId { get; set; }
        public DateTime? SqldateTime { get; set; }
        public long? PlceventTime { get; set; }
        public DateTime? PlceventDateTime { get; set; }
        public int? LotNumber { get; set; }
        public int? BatchNumber { get; set; }
        public short? PhaseNumber { get; set; }
        public short? PhaseType { get; set; }
        public short? EventArea { get; set; }
        public short? EventId { get; set; }
        public float? EventValue { get; set; }
        public float? MixTime { get; set; }
        public float? DriveTemp { get; set; }
        public float? WaterTemp { get; set; }
        public float? Kw { get; set; }
        public float? KWh { get; set; }
        public float? RamPosition { get; set; }
        public float? RamPressure { get; set; }
        public float? MixerSpeed { get; set; }
        public float? Temperature { get; set; }
    }
}
