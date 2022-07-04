using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OperationScanResult
    {
        public OperationScanResult()
        {
            OperationScans = new HashSet<OperationScan>();
            Operations = new HashSet<Operation>();
        }

        public string ResultId { get; set; } = null!;
        public string ResultName { get; set; } = null!;
        public string ResultDescription { get; set; } = null!;

        public virtual ICollection<OperationScan> OperationScans { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
