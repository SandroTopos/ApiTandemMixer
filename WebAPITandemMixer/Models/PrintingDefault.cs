using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class PrintingDefault
    {
        public int LabelPrinterId { get; set; }
        public string LabelPrinterIp { get; set; } = null!;
        public int LabelPrinterPort { get; set; }
        public string LabelPrinterLabelData { get; set; } = null!;
    }
}
