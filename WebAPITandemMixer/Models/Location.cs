using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Location
    {
        public Location()
        {
            ActionLogs = new HashSet<ActionLog>();
            InverseParentLocation = new HashSet<Location>();
            LocationOperations = new HashSet<LocationOperation>();
            ScannedValues = new HashSet<ScannedValue>();
            Scanners = new HashSet<Scanner>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; } = null!;
        public string LocationDescription { get; set; } = null!;
        public int? ParentLocationId { get; set; }

        public virtual Location? ParentLocation { get; set; }
        public virtual ICollection<ActionLog> ActionLogs { get; set; }
        public virtual ICollection<Location> InverseParentLocation { get; set; }
        public virtual ICollection<LocationOperation> LocationOperations { get; set; }
        public virtual ICollection<ScannedValue> ScannedValues { get; set; }

        public virtual ICollection<Scanner> Scanners { get; set; }
    }
}
