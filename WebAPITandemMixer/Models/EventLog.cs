using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventLog
    {
        public long EventId { get; set; }
        public DateTimeOffset? EventStartTime { get; set; }
        public DateTimeOffset EventTime { get; set; }
        public int? EventDuration { get; set; }
        public string? EventInitialSource { get; set; }
        public string? EventSource { get; set; }
        public long? EventSequence { get; set; }
        public string? EventCurrentOperation { get; set; }
        public int? EventCompoundId { get; set; }
        public int? EventLotNumber { get; set; }
        public short? EventArea { get; set; }
        public int? EventBatchNumber { get; set; }
        public int? EventPhaseNumber { get; set; }
        public int? EventOperatorId { get; set; }
        public string? EventUserMsg { get; set; }
        public string? EventMsg { get; set; }
        public string? EventProcedureHistory { get; set; }
        public string? EventClientComputerName { get; set; }
        public long? EventRowCount { get; set; }
        public byte? EventDebugLevel { get; set; }
        public byte? EventSeverityId { get; set; }
        public int? EventReturnValue { get; set; }

        public virtual EventLogSeverity? EventSeverity { get; set; }
    }
}
