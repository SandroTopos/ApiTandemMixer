using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventMixer
    {
        public EventMixer()
        {
            EventAreas = new HashSet<EventArea>();
        }

        public short EventMixer1 { get; set; }
        public string EventMixerName { get; set; } = null!;
        public string? EquipmentName { get; set; }

        public virtual ICollection<EventArea> EventAreas { get; set; }
    }
}
