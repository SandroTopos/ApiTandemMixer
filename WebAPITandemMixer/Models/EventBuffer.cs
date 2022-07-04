using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EventBuffer
    {
        public long EventId { get; set; }
        public long? PlceventTime { get; set; }
        public short? EventIndexNumber { get; set; }
        public int? EventIdnumber { get; set; }
        public double? EventValue { get; set; }
        public int? EventStatus { get; set; }
        public short? EventArea { get; set; }
        public short? EventBatch { get; set; }
        public short? EventPhase { get; set; }
        public DateTimeOffset? SqleventTime { get; set; }
        public int? EventCompound { get; set; }
        public short? EventMixer { get; set; }
        public short? EventPriority { get; set; }
        public short? EventIngredientIndex { get; set; }
        public bool? EventProcessed { get; set; }
        public bool? EventAlarmProcessed { get; set; }
    }
}
