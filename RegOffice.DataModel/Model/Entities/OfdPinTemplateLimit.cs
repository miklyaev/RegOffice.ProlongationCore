using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPinTemplateLimit
    {
        public Guid OfdPinTemplateId { get; set; }
        public int LimitId { get; set; }
        public int? LimitValueInt { get; set; }

        public virtual Limit Limit { get; set; }
        public virtual OfdPinTemplate OfdPinTemplate { get; set; }
    }
}
