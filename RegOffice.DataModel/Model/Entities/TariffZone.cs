using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffZone
    {
        public TariffZone()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            Contracts = new HashSet<Contract>();
            PriceSchemes = new HashSet<PriceScheme>();
        }

        public int TariffZoneId { get; set; }
        public string TariffZoneName { get; set; }
        public decimal Price { get; set; }
        public int PriceId { get; set; }

        public virtual Price PriceNavigation { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemes { get; set; }
    }
}
