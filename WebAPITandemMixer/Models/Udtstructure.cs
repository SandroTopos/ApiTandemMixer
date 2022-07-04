using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Udtstructure
    {
        public string UdtSection { get; set; } = null!;
        public int UdtMinimum { get; set; }
        public int UdtMaximum { get; set; }
    }
}
