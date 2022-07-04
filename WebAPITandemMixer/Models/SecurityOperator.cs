using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SecurityOperator
    {
        public SecurityOperator()
        {
            SecurityRoles = new HashSet<SecurityRole>();
        }

        public int OperatorId { get; set; }
        public string NetworkUserId { get; set; } = null!;
        public string OperatorLoginIdentifier { get; set; } = null!;
        public string OperatorName { get; set; } = null!;
        public string OperatorPassword { get; set; } = null!;
        public bool IsOperatorEnabled { get; set; }
        public DateTimeOffset? LastLoginTimeStamp { get; set; }
        public DateTimeOffset UpdatedTimeStamp { get; set; }

        public virtual ICollection<SecurityRole> SecurityRoles { get; set; }
    }
}
