using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ScanOption
    {
        public string ScanId { get; set; } = null!;
        public string OptionId { get; set; } = null!;
        public int OptionOrder { get; set; }

        public virtual Option Option { get; set; } = null!;
        public virtual Scan Scan { get; set; } = null!;
    }
}
