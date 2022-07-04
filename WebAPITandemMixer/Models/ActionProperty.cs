using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionProperty
    {
        public string ActionId { get; set; } = null!;
        public string ActionProperty1 { get; set; } = null!;
        public string ActionPropertyValue { get; set; } = null!;

        public virtual Action Action { get; set; } = null!;
    }
}
