using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentRegNum
    {
        public int RegId { get; set; }
        public int PotentialAbonentId { get; set; }
        public string RegNum { get; set; }
    }
}
