using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CheckingType
    {
        public CheckingType()
        {
            CheckingSchemes = new HashSet<CheckingScheme>();
            ProductCheckings = new HashSet<ProductChecking>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
        }

        public int CheckingTypeId { get; set; }
        public string CheckingTypeName { get; set; }

        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
    }
}
