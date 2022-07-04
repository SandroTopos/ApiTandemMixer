using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemLogSource
    {
        public SystemLogSource()
        {
            SystemLogEvents = new HashSet<SystemLogEvent>();
        }

        public string LogSource { get; set; } = null!;
        public string LogName { get; set; } = null!;

        public virtual SystemLogName LogNameNavigation { get; set; } = null!;
        public virtual ICollection<SystemLogEvent> SystemLogEvents { get; set; }
    }
}
