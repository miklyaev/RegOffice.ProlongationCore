using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Region
    {
        public Region()
        {
            Abonents = new HashSet<Abonent>();
            Addrs = new HashSet<Addr>();
            AgentRegions = new HashSet<AgentRegion>();
            AgentSchemes = new HashSet<AgentScheme>();
            Its = new HashSet<Its>();
            NewsVisibilities = new HashSet<NewsVisibility>();
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
            PointZones = new HashSet<PointZone>();
            PotentialAbonentUserRegions = new HashSet<PotentialAbonentUserRegion>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            PriceSchemes = new HashSet<PriceScheme>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            Recipients = new HashSet<Recipient>();
            RegionalAgents = new HashSet<RegionalAgent>();
            TariffCalcPrices = new HashSet<TariffCalcPrices>();
            TariffCalcTariffRegions = new HashSet<TariffCalcTariffRegion>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string RegionPfrCode { get; set; }
        public int OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual RegionTimeZone RegionTimeZone { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<Addr> Addrs { get; set; }
        public virtual ICollection<AgentRegion> AgentRegions { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<Its> Its { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
        public virtual ICollection<PointZone> PointZones { get; set; }
        public virtual ICollection<PotentialAbonentUserRegion> PotentialAbonentUserRegions { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemes { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
        public virtual ICollection<RegionalAgent> RegionalAgents { get; set; }
        public virtual ICollection<TariffCalcPrices> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcTariffRegion> TariffCalcTariffRegions { get; set; }
    }
}
