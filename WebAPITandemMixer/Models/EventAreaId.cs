using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventAreaId
    {
        public short EventMixer { get; set; }
        public short EventArea { get; set; }
        public short EventId { get; set; }
        public string EventName { get; set; } = null!;
        public short AlarmTypeId { get; set; }

        public virtual EventArea Event { get; set; } = null!;
    }
}
