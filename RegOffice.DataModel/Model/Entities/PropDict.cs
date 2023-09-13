using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PropDict
    {
        public int PropTypeId { get; set; }
        public string PropValue { get; set; }

        public virtual PropType PropType { get; set; }
    }
}
