using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SecurityObject
    {
        public SecurityObject()
        {
            SecurityObjectRoles = new HashSet<SecurityObjectRole>();
        }

        public short SecurityObjectId { get; set; }
        public string SecurityObjectName { get; set; } = null!;
        public string? SecurityObjectDescription { get; set; }

        public virtual ICollection<SecurityObjectRole> SecurityObjectRoles { get; set; }
    }
}
