using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Validate
    {
        public Validate()
        {
            Scans = new HashSet<Scan>();
        }

        public string ValidateId { get; set; } = null!;
        public string ValidateName { get; set; } = null!;
        public string ValidateSproc { get; set; } = null!;

        public virtual ICollection<Scan> Scans { get; set; }
    }
}
