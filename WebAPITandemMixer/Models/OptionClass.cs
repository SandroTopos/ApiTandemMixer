using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OptionClass
    {
        public OptionClass()
        {
            Options = new HashSet<Option>();
        }

        public string OptionClass1 { get; set; } = null!;
        public string OptionClassName { get; set; } = null!;
        public string OptionClassDescription { get; set; } = null!;

        public virtual ICollection<Option> Options { get; set; }
    }
}
