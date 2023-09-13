using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentRts
    {
        public string PurchaseNumber { get; set; }
        public int PotentialAbonentId { get; set; }
        public decimal DealSum { get; set; }
        public int PurchaseTypeId { get; set; }
        public DateTime? ProtocolDate { get; set; }
        public string PlaceName { get; set; }
        public string PlaceAddress { get; set; }
        public DateTime GuarantyBeginDate { get; set; }
        public DateTime GuarantyEndDate { get; set; }
        public decimal DealReward { get; set; }

        public virtual PurchaseType PurchaseType { get; set; }
    }
}
