using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuthKey
    {
        public DssAuthKey()
        {
            DssAuthKeySteps = new HashSet<DssAuthKeyStep>();
        }

        public int Id { get; set; }
        public string IdKey { get; set; }
        public DateTime Expired { get; set; }
        public int QrCodeId { get; set; }
        public int? DssUserId { get; set; }
        public int StepId { get; set; }
        public int? MemberId { get; set; }
        public int DssId { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual DssUser DssUser { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual File QrCode { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<DssAuthKeyStep> DssAuthKeySteps { get; set; }
    }
}
