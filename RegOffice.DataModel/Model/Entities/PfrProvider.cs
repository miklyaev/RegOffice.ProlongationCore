using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PfrProvider
    {
        public PfrProvider()
        {
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
        }

        public int PfrProviderId { get; set; }
        public string PfrProviderName { get; set; }
        public string PfrProviderSystem { get; set; }
        public int CertificateId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
