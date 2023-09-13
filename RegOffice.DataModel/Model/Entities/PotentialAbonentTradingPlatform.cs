using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentTradingPlatform
    {
        public int AbonentPlatformId { get; set; }
        public int PotentialAbonentId { get; set; }
        public int TradingPlatformTypeId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual PotentialAbonentTradingPlatformType TradingPlatformType { get; set; }
    }
}
