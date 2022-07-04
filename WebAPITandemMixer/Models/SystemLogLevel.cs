using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemLogLevel
    {
        public SystemLogLevel()
        {
            SystemLogEvents = new HashSet<SystemLogEvent>();
        }

        public string LogLevel { get; set; } = null!;

        public virtual ICollection<SystemLogEvent> SystemLogEvents { get; set; }
    }
}
