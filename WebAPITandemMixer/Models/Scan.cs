using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Scan
    {
        public Scan()
        {
            OperationScans = new HashSet<OperationScan>();
            ScanActions = new HashSet<ScanAction>();
            ScanOptions = new HashSet<ScanOption>();
            ScannedValues = new HashSet<ScannedValue>();
            Validates = new HashSet<Validate>();
        }

        public string ScanId { get; set; } = null!;
        public string ScanName { get; set; } = null!;
        public string ScanDescription { get; set; } = null!;
        public string ScanClassId { get; set; } = null!;
        public int ScanValueRetention { get; set; }
        public bool ScanEnabled { get; set; }
        public bool ScanValueRelease { get; set; }

        public virtual ScanClass ScanClass { get; set; } = null!;
        public virtual ICollection<OperationScan> OperationScans { get; set; }
        public virtual ICollection<ScanAction> ScanActions { get; set; }
        public virtual ICollection<ScanOption> ScanOptions { get; set; }
        public virtual ICollection<ScannedValue> ScannedValues { get; set; }

        public virtual ICollection<Validate> Validates { get; set; }
    }
}
