using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionLog
    {
        public ActionLog()
        {
            ActionParameterLogs = new HashSet<ActionParameterLog>();
        }

        public long ActionLogId { get; set; }
        public DateTime ActionTimestamp { get; set; }
        public string ScannerId { get; set; } = null!;
        public int LocationId { get; set; }
        public string OperationId { get; set; } = null!;
        public string ScanId { get; set; } = null!;
        public string ActionId { get; set; } = null!;
        public int ActionOrder { get; set; }
        public string ActionStatus { get; set; } = null!;
        public string? ActionError { get; set; }
        public string? ScannedValue { get; set; }
        public string? ServerName { get; set; }
        public string? DatabaseName { get; set; }
        public string? UserName { get; set; }
        public string? StoredProcedure { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
        public virtual Scanner Scanner { get; set; } = null!;
        public virtual ICollection<ActionParameterLog> ActionParameterLogs { get; set; }
    }
}
