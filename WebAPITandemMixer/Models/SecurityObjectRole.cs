using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class SecurityObjectRole
    {
        public short SecurityObjectRoleId { get; set; }
        public short SecurityObjectId { get; set; }
        public short SecurityRoleId { get; set; }
        public bool IsViewable { get; set; }
        public bool IsEditEnabled { get; set; }

        public virtual SecurityObject SecurityObject { get; set; } = null!;
        public virtual SecurityRole SecurityRole { get; set; } = null!;
    }
}
