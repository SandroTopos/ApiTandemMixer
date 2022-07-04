using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventLogSeverity
    {
        public EventLogSeverity()
        {
            EventLogs = new HashSet<EventLog>();
        }

        /// <summary>
        /// Severity ID
        /// </summary>
        public byte SeverityId { get; set; }
        /// <summary>
        /// Event Log Severity Name
        /// </summary>
        public string SeverityName { get; set; } = null!;
        /// <summary>
        /// Event Log Severity Description
        /// </summary>
        public string SeverityDescription { get; set; } = null!;

        public virtual ICollection<EventLog> EventLogs { get; set; }
    }
}
