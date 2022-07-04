using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Stages = new HashSet<Stage>();
        }

        public string EquipmentName { get; set; } = null!;
        public string EquipmentType { get; set; } = null!;
        public decimal EquipmentCapacity { get; set; }
        public short? EventMixer { get; set; }
        public string? EventMixerName { get; set; }
        public string? EventMixerAbbr { get; set; }
        public short? EventArea { get; set; }
        public int? Stage { get; set; }
        public bool IsActiveMixer { get; set; }

        public virtual EquipmentType EquipmentTypeNavigation { get; set; } = null!;
        public virtual ICollection<Stage> Stages { get; set; }
    }
}
