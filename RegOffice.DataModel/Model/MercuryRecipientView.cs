using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class MercuryRecipientView
    {
        public string Id { get; set; }
        public Guid? ProductGuid { get; set; }
        public string RecipientCode { get; set; }
        public int? ProtocolId { get; set; }
    }
}
