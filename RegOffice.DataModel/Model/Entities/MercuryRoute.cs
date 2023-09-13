using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MercuryRoute
    {
        public string Kpp { get; set; }
        public int MercuryId { get; set; }
        public int RecipientId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual MercuryRecipient MercuryRecipient { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
