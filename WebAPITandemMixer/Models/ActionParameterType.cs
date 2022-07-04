using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ActionParameterType
    {
        public ActionParameterType()
        {
            ActionParameters = new HashSet<ActionParameter>();
        }

        public string ParameterValueType { get; set; } = null!;
        public string ParameterValueTypeDescription { get; set; } = null!;

        public virtual ICollection<ActionParameter> ActionParameters { get; set; }
    }
}
