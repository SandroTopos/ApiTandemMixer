using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            SecurityObjectRoles = new HashSet<SecurityObjectRole>();
            Operators = new HashSet<SecurityOperator>();
        }

        public short SecurityRoleId { get; set; }
        public string SecurityRoleName { get; set; } = null!;
        public bool IsControlComputerRole { get; set; }
        public bool? IsMasterRole { get; set; }
        public string? SecurityRoleDescription { get; set; }

        public virtual ICollection<SecurityObjectRole> SecurityObjectRoles { get; set; }

        public virtual ICollection<SecurityOperator> Operators { get; set; }
    }
}
