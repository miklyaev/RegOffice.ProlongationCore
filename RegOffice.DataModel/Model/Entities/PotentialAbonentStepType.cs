using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentStepType
    {
        public PotentialAbonentStepType()
        {
            PotentialAbonents = new HashSet<PotentialAbonent>();
        }

        public int StepId { get; set; }
        public string StepName { get; set; }
        public int? ProductTypeId { get; set; }

        public virtual PotentialAbonentProductType ProductType { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
    }
}
