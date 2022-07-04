using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OperationResult
    {
        public long Id { get; set; }
        public DateTime? OperationStartTime { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public string? Operation { get; set; }
        public long? OperationInstance { get; set; }
        public string? Transfer { get; set; }
        public int? ServerIdbegin { get; set; }
        public int? ServerIdend { get; set; }
    }
}
