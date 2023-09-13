using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaRequestApi
    {
        public int CaRequestApiId { get; set; }
        public int CaId { get; set; }
        public DateTime? OffTime { get; set; }
        public Guid ExternalCaGuid { get; set; }
        public string EntrypointUrl { get; set; }
        public string CallbackUrl { get; set; }

        public virtual Ca Ca { get; set; }
    }
}
