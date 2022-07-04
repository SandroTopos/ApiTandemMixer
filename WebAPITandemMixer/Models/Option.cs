using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Option
    {
        public Option()
        {
            OptionActions = new HashSet<OptionAction>();
            ScanOptions = new HashSet<ScanOption>();
        }

        public string OptionId { get; set; } = null!;
        public string OptionName { get; set; } = null!;
        public string OptionDescription { get; set; } = null!;
        public bool OptionEnabled { get; set; }
        public string OptionClass { get; set; } = null!;
        public string OptionColor { get; set; } = null!;

        public virtual OptionClass OptionClassNavigation { get; set; } = null!;
        public virtual ICollection<OptionAction> OptionActions { get; set; }
        public virtual ICollection<ScanOption> ScanOptions { get; set; }
    }
}
