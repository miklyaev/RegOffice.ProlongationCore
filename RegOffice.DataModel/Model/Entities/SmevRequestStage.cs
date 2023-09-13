using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SmevRequestStage
    {
        public int RequestStageId { get; set; }
        public Guid OriginalRequestId { get; set; }
        public DateTime? StageTime { get; set; }
        public int StageTypeId { get; set; }
        public int FileId { get; set; }

        public virtual File File { get; set; }
        public virtual SmevStageType StageType { get; set; }
    }
}
