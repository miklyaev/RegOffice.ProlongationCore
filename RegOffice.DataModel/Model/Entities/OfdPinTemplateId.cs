using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPinTemplateId
    {
        public int OfdPinId { get; set; }
        public Guid OfdPinTemplateId1 { get; set; }

        public virtual OfdPin OfdPin { get; set; }
        public virtual OfdPinTemplate OfdPinTemplateId1Navigation { get; set; }
    }
}
