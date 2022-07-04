using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Operation
    {
        public Operation()
        {
            LocationOperations = new HashSet<LocationOperation>();
            OperationScans = new HashSet<OperationScan>();
            Scanners = new HashSet<Scanner>();
        }

        public string OperationId { get; set; } = null!;
        public string OperationName { get; set; } = null!;
        public string OperationDescription { get; set; } = null!;
        public string ResultIdEnd { get; set; } = null!;
        public bool OperationEnabled { get; set; }

        public virtual OperationScanResult ResultIdEndNavigation { get; set; } = null!;
        public virtual ICollection<LocationOperation> LocationOperations { get; set; }
        public virtual ICollection<OperationScan> OperationScans { get; set; }

        public virtual ICollection<Scanner> Scanners { get; set; }
    }
}
