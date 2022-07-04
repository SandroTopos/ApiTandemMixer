using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionType
    {
        public ActionType()
        {
            Actions = new HashSet<Action>();
        }

        public string ActionTypeId { get; set; } = null!;
        public string ActionTypeName { get; set; } = null!;
        public string ActionTypeDescription { get; set; } = null!;

        public virtual ICollection<Action> Actions { get; set; }
    }
}
