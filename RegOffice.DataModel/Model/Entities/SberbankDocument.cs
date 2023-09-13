using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SberbankDocument
    {
        public int DocId { get; set; }
        public Guid DocGuid { get; set; }
        public byte[] Hash { get; set; }
        public int? SignId { get; set; }
    }
}
