using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MercuryRecipientStep
    {
        public int RecipientId { get; set; }
        public int MercuryId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public int? UserId { get; set; }
        public string PackId { get; set; }
        public int? FileId { get; set; }
        public string Message { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
