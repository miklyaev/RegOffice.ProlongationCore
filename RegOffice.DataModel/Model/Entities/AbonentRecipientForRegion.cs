using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentRecipientForRegion
    {
        public int? AbonentId { get; set; }
        public int? RegionId { get; set; }
        public string RecipientCode { get; set; }
        public int? IsIndividual { get; set; }
        public int? ProtocolId { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public int? ProductId { get; set; }
    }
}
