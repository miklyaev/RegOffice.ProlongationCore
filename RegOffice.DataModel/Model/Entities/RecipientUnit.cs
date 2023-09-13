using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RecipientUnit
    {
        public int RecipientId { get; set; }
        public int CertificateId { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
