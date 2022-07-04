using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Action
    {
        public Action()
        {
            ActionLogs = new HashSet<ActionLog>();
            ActionParameters = new HashSet<ActionParameter>();
            ActionProperties = new HashSet<ActionProperty>();
            OptionActions = new HashSet<OptionAction>();
            ScanActions = new HashSet<ScanAction>();
        }

        public string ActionId { get; set; } = null!;
        public string ActionName { get; set; } = null!;
        public string ActionDescription { get; set; } = null!;
        public string ActionMessage { get; set; }
        public string ActionClassId { get; set; } = null!;
        public string ActionTypeId { get; set; } = null!;

        public virtual ActionClass ActionClass { get; set; } = null!;
        public virtual ActionType ActionType { get; set; } = null!;
        public virtual ICollection<ActionLog> ActionLogs { get; set; }
        public virtual ICollection<ActionParameter> ActionParameters { get; set; }
        public virtual ICollection<ActionProperty> ActionProperties { get; set; }
        public virtual ICollection<OptionAction> OptionActions { get; set; }
        public virtual ICollection<ScanAction> ScanActions { get; set; }
    }
}
