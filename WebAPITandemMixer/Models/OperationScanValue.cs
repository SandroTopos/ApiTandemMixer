using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OperationScanValue
    {
        public string OperationId { get; set; } = null!;
        public string ScanId { get; set; } = null!;
        public int ScanOrder { get; set; }
        public string ScanStatus { get; set; } = null!;
        public int ResultIdValueOrder { get; set; }
        public string ResultIdValue { get; set; } = null!;

        public virtual OperationScan OperationScan { get; set; } = null!;
    }
}
