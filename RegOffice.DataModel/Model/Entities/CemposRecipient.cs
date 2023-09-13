using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CemposRecipient
    {
        public Guid CemposRecipientId { get; set; }
        public string RegionCode { get; set; }
        public string RecipientCode { get; set; }
        public string RecipientCodeOld { get; set; }
        public string RecipientName { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
