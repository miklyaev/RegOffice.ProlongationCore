using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestRoute
    {
        public int RecipientId { get; set; }
        public string Kpp { get; set; }

        public virtual RegRequestRecipient Recipient { get; set; }
    }
}
