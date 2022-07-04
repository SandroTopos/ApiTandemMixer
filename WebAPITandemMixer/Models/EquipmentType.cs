using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            Equipment = new HashSet<Equipment>();
            EquipmentPhaseParameterTypes = new HashSet<EquipmentPhaseParameterType>();
            EquipmentPhaseTransitionTypes = new HashSet<EquipmentPhaseTransitionType>();
            EquipmentTypePhases = new HashSet<EquipmentTypePhase>();
            IngredientTypes = new HashSet<IngredientType>();
        }

        public string EquipmentType1 { get; set; } = null!;

        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<EquipmentPhaseParameterType> EquipmentPhaseParameterTypes { get; set; }
        public virtual ICollection<EquipmentPhaseTransitionType> EquipmentPhaseTransitionTypes { get; set; }
        public virtual ICollection<EquipmentTypePhase> EquipmentTypePhases { get; set; }

        public virtual ICollection<IngredientType> IngredientTypes { get; set; }
    }
}
