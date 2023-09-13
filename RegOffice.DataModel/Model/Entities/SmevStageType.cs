using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SmevStageType
    {
        public SmevStageType()
        {
            SmevRequestStages = new HashSet<SmevRequestStage>();
        }

        public int StageTypeId { get; set; }
        public string StageName { get; set; }

        public virtual ICollection<SmevRequestStage> SmevRequestStages { get; set; }
    }
}
