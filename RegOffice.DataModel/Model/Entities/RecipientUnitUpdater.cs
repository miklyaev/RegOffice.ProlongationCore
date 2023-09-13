using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RecipientUnitUpdater
    {
        public int RecipientUnitUpdaterId { get; set; }
        public int RecipientUpdaterId { get; set; }
        public int Index { get; set; }
        public int? CertId { get; set; }

        public virtual RecipientUpdater RecipientUpdater { get; set; }
    }
}
