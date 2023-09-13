using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentEgais
    {
        public int PotentialAbonentEgaisId { get; set; }
        public int PotentialAbonentId { get; set; }
        public string Kpp { get; set; }
        public string RegionCode { get; set; }
        public string Adress { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual PotentialAbonent PotentialAbonent { get; set; }
    }
}
