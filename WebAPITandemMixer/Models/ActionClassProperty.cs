using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionClassProperty
    {
        public string ActionClassId { get; set; } = null!;
        public string ActionClassProperty1 { get; set; } = null!;
        public string ActionClassPropertyDescription { get; set; } = null!;

        public virtual ActionClass ActionClass { get; set; } = null!;
    }
}
