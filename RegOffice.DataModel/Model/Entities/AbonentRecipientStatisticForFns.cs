using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentRecipientStatisticForFns
    {
        public int? RegionId { get; set; }
        public string RecipientCode { get; set; }
        public decimal? TotalAbonent { get; set; }
        public decimal? TotalJuridical { get; set; }
        public decimal? TotalIndividual { get; set; }
        public decimal? MonthAbonent { get; set; }
        public decimal? MonthJuridical { get; set; }
        public decimal? MonthIndividual { get; set; }
    }
}
