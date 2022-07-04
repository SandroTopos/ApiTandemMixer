using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventArea
    {
        public EventArea()
        {
            EventAreaIds = new HashSet<EventAreaId>();
        }

        public short EventMixer { get; set; }
        public short EventArea1 { get; set; }
        public string EventAreaName { get; set; } = null!;

        public virtual EventMixer EventMixerNavigation { get; set; } = null!;
        public virtual ICollection<EventAreaId> EventAreaIds { get; set; }
    }
}
