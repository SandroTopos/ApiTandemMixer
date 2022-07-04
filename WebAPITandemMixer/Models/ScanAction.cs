using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ScanAction
    {
        public string ScanId { get; set; } = null!;
        public string ActionId { get; set; } = null!;
        public int ActionOrder { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual Scan Scan { get; set; } = null!;
    }
}
