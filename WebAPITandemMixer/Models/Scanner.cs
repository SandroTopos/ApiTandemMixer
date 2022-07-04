using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Scanner
    {
        public Scanner()
        {
            ActionLogs = new HashSet<ActionLog>();
            ScannedValues = new HashSet<ScannedValue>();
            Locations = new HashSet<Location>();
            Operations = new HashSet<Operation>();
        }

        public string ScannerId { get; set; } = null!;
        public string ScannerName { get; set; } = null!;
        public string ScannerDescription { get; set; } = null!;
        public DateTime ScannerHeartbeat { get; set; }
        public string ScannerGroupId { get; set; } = null!;
        public bool ScannerEnabled { get; set; }

        public virtual ScannerGroup ScannerGroup { get; set; } = null!;
        public virtual ICollection<ActionLog> ActionLogs { get; set; }
        public virtual ICollection<ScannedValue> ScannedValues { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
