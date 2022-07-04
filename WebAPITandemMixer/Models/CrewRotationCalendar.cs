using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class CrewRotationCalendar
    {
        public DateTime CaldDate { get; set; }
        public string? WeekDay { get; set; }
        public string Crew { get; set; } = null!;
        public string Shift { get; set; } = null!;
        public int? SchedHrs { get; set; }
        public string ShiftDesc { get; set; } = null!;
        public string RotationGroup { get; set; } = null!;
        public byte RotationCycle { get; set; }
    }
}
