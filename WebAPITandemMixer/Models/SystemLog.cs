using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SystemLog
    {
        public long LogId { get; set; }
        public DateTime LogTimestamp { get; set; }
        public string LogEvent { get; set; } = null!;
        public string LogItem { get; set; } = null!;
        public string LogDevice { get; set; } = null!;

        public virtual SystemLogEvent LogEventNavigation { get; set; } = null!;
    }
}
