using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class CompoundBatchesProduced
    {
        public string? Compound { get; set; }
        public int? Batches { get; set; }
        public DateTime? Processed { get; set; }
    }
}
