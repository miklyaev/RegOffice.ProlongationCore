using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuth
    {
        public DssAuth()
        {
            DssAuthSteps = new HashSet<DssAuthStep>();
        }

        public int AuthId { get; set; }
        public int UserId { get; set; }
        public int StepId { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? QrCodeId { get; set; }
        public string Serial { get; set; }
        public int? ProductPersonId { get; set; }
        public int AuthSystemId { get; set; }

        public virtual DssAuthSystem AuthSystem { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual File QrCode { get; set; }
        public virtual Step Step { get; set; }
        public virtual DssUser User { get; set; }
        public virtual ICollection<DssAuthStep> DssAuthSteps { get; set; }
    }
}
