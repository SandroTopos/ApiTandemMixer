using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class TestTable
    {
        public DateTime Timestamp { get; set; }
        public string ScannerId { get; set; } = null!;
        public string TestValue { get; set; } = null!;
    }
}
