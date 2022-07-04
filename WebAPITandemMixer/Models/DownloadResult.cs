using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class DownloadResult
    {
        public long DownloadResultsId { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public long? LotNumber { get; set; }
        public string? ErrorMessage { get; set; }
        public int? ErrorCode { get; set; }
    }
}
