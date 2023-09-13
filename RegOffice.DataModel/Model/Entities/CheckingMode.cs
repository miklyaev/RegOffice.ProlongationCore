using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CheckingMode
    {
        public CheckingMode()
        {
            CheckingSchemes = new HashSet<CheckingScheme>();
        }

        public int CheckingModeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
    }
}
