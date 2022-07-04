using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Stage
    {
        public string CompoundName { get; set; } = null!;
        public int Stage1 { get; set; }
        public string EquipmentName { get; set; } = null!;
        public int MinimumTime { get; set; }
        public int MaximumTime { get; set; }

        public virtual Equipment EquipmentNameNavigation { get; set; } = null!;
    }
}
