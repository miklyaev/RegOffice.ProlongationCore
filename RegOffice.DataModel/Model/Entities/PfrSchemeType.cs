using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PfrSchemeType
    {
        public PfrSchemeType()
        {
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
        }

        public int PfrSchemeTypeId { get; set; }
        public string PfrSchemeTypeName { get; set; }
        public string LetterCategory { get; set; }

        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
    }
}
