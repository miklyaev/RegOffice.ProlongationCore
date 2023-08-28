using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица регионов
    /// </summary>
    public partial class Region
    {
        public Region()
        {
            Abonents = new HashSet<Abonent>();
            Addrs = new HashSet<Addr>();
            AgentSchemes = new HashSet<AgentScheme>();
            Its = new HashSet<It>();
            NewsVisibilities = new HashSet<NewsVisibility>();
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
            PointZones = new HashSet<PointZone>();
            PotentialAbonentUserRegions = new HashSet<PotentialAbonentUserRegion>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            PriceSchemes = new HashSet<PriceScheme>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            Recipients = new HashSet<Recipient>();
            TariffCalcPrices = new HashSet<TariffCalcPrice>();
            Agents = new HashSet<Agent>();
            Tariffs = new HashSet<TariffCalcTariff>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Код ФНС
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Код ПФР
        /// </summary>
        public string RegionPfrCode { get; set; }

        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual RegionTimeZone RegionTimeZone { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<Addr> Addrs { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<It> Its { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
        public virtual ICollection<PointZone> PointZones { get; set; }
        public virtual ICollection<PotentialAbonentUserRegion> PotentialAbonentUserRegions { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemes { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
        public virtual ICollection<TariffCalcPrice> TariffCalcPrices { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<TariffCalcTariff> Tariffs { get; set; }
    }
}
