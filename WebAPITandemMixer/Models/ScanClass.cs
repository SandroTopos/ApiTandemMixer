using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ScanClass
    {
        public ScanClass()
        {
            Scans = new HashSet<Scan>();
        }

        public string ScanClassId { get; set; } = null!;
        public string ScanClassName { get; set; } = null!;
        public string ScanClassDescription { get; set; } = null!;

        public virtual ICollection<Scan> Scans { get; set; }
    }
}
