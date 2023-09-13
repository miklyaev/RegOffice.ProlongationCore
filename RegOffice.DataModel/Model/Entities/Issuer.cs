using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Issuer
    {
        public Issuer()
        {
            Cas = new HashSet<Ca>();
            IssuerAccreditations = new HashSet<IssuerAccreditation>();
        }

        public int IssuerId { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }

        public virtual ICollection<Ca> Cas { get; set; }
        public virtual ICollection<IssuerAccreditation> IssuerAccreditations { get; set; }
    }
}
