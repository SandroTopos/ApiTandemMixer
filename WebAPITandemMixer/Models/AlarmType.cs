using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class AlarmType
    {
        public short AlarmTypeId { get; set; }
        public string AlarmTypeDescription { get; set; } = null!;
    }
}
