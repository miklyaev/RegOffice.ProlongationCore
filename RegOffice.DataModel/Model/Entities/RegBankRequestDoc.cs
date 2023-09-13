using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegBankRequestDoc
    {
        public int RegBankRequestId { get; set; }
        public int DocId { get; set; }

        public virtual Doc Doc { get; set; }
        public virtual RegBankRequest RegBankRequest { get; set; }
    }
}
