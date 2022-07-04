using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class OptionAction
    {
        public string OptionId { get; set; } = null!;
        public string ActionId { get; set; } = null!;
        public int ActionOrder { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual Option Option { get; set; } = null!;
    }
}
