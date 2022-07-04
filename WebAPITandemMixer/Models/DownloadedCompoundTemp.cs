using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class DownloadedCompoundTemp
    {
        public long Id { get; set; }
        public int? ServerBeginEnd { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public int? CompareServerBeginEnd { get; set; }
        public int? GlobalBeginEnd { get; set; }
    }
}
