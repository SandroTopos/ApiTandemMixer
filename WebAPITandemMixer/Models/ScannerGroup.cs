using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ScannerGroup
    {
        public ScannerGroup()
        {
            Scanners = new HashSet<Scanner>();
        }

        public string ScannerGroupId { get; set; } = null!;
        public string ScannerGroupName { get; set; } = null!;
        public string ScannerGroupDescription { get; set; } = null!;

        public virtual ICollection<Scanner> Scanners { get; set; }
    }
}
