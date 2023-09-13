using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentProvider
    {
        public int PotentialAbonentId { get; set; }
        public decimal MaxSum { get; set; }
        public int SumCountAuctions { get; set; }
        public int SumCountWin { get; set; }
        public int SumCountContract { get; set; }
    }
}
