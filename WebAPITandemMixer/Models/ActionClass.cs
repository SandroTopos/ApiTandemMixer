using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionClass
    {
        public ActionClass()
        {
            ActionClassProperties = new HashSet<ActionClassProperty>();
            Actions = new HashSet<Action>();
        }

        public string ActionClassId { get; set; } = null!;
        public string ActionClassName { get; set; } = null!;
        public string ActionClassDescription { get; set; } = null!;

        public virtual ICollection<ActionClassProperty> ActionClassProperties { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
