using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemLogEvent
    {
        public SystemLogEvent()
        {
            SystemLogs = new HashSet<SystemLog>();
        }

        public string LogEvent { get; set; } = null!;
        public string? LogSource { get; set; }
        public string? LogLevel { get; set; }
        public string LogEventDescription { get; set; } = null!;

        public virtual SystemLogLevel? LogLevelNavigation { get; set; }
        public virtual SystemLogSource? LogSourceNavigation { get; set; }
        public virtual ICollection<SystemLog> SystemLogs { get; set; }
    }
}
