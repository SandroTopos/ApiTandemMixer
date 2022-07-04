using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class DownloadedCompoundTrigger
    {
        public int DownloadId { get; set; }
        public int DownloadTransactionNumber { get; set; }
        public int ReceivedTransactionNumber { get; set; }
        public int TempTriggerForTimer { get; set; }
        public DateTime? CurrentDatetime { get; set; }
        public long? OperationInstance { get; set; }
        public long? LotNumber { get; set; }
    }
}
