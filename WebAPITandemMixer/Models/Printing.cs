using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Printing
    {
        public long LabelId { get; set; }
        public int? LabelPrinterId { get; set; }
        public DateTime? LabelPrinterSentTime { get; set; }
        public DateTime? LabelPrinterPrintedTime { get; set; }
        public string? SerialNumber { get; set; }
        public string? ProductionDate { get; set; }
        public string? LotNumber { get; set; }
        public string? Quantity { get; set; }
        public string? WU { get; set; }
        public string? AgeLimit { get; set; }
    }
}
