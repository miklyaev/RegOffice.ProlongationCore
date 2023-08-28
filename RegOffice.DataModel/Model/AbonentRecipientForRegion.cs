using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
