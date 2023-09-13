using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Soun
    {
        public Soun()
        {
            InverseParentTaxNavigation = new HashSet<Soun>();
        }

        public string TaxCode { get; set; }
        public string ParentTax { get; set; }
        public string TaxName { get; set; }

        public virtual Soun ParentTaxNavigation { get; set; }
        public virtual ICollection<Soun> InverseParentTaxNavigation { get; set; }
    }
}
