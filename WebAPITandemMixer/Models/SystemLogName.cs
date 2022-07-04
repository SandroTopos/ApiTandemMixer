using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemLogName
    {
        public SystemLogName()
        {
            SystemLogSources = new HashSet<SystemLogSource>();
        }

        public string LogName { get; set; } = null!;

        public virtual ICollection<SystemLogSource> SystemLogSources { get; set; }
    }
}
