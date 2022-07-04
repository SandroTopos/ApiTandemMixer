using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Alarm
    {
        public long AlarmId { get; set; }
        public DateTime AlarmDateTime { get; set; }
        public DateTime? AlarmDateTimeEnd { get; set; }
        public short? AlarmTypeId { get; set; }
        public short? AlarmEventIdNumber { get; set; }
        public int? AlarmLotNumber { get; set; }
        public short? AlarmEventArea { get; set; }
        public short? AlarmBatchNumber { get; set; }
        public short? AlarmPhaseNumber { get; set; }
        public bool? AlarmState { get; set; }
        public string? AlarmDescription { get; set; }
        public int? AlarmDuration { get; set; }
    }
}
