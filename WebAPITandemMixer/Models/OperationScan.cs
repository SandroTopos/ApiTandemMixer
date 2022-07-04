using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OperationScan
    {
        public OperationScan()
        {
            OperationScanValues = new HashSet<OperationScanValue>();
        }

        public string OperationId { get; set; } = null!;
        public string ScanId { get; set; } = null!;
        public int ScanOrder { get; set; }
        public string ResultIdFail { get; set; } = null!;

        public virtual Operation Operation { get; set; } = null!;
        public virtual OperationScanResult ResultIdFailNavigation { get; set; } = null!;
        public virtual Scan Scan { get; set; } = null!;
        public virtual ICollection<OperationScanValue> OperationScanValues { get; set; }
    }
}
