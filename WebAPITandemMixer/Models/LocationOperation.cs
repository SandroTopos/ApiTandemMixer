using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class LocationOperation
    {
        public int LocationId { get; set; }
        public string OperationId { get; set; } = null!;
        public int OperationOrder { get; set; }

        public virtual Location Location { get; set; } = null!;
        public virtual Operation Operation { get; set; } = null!;
    }
}
