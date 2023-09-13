using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class StatisticProvider
    {
        public int StatisticProviderId { get; set; }
        public int? AbonentId { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public decimal? MaxSum { get; set; }
        public int SumCountAuctions { get; set; }
        public int SumCountWin { get; set; }
        public int SumCountContract { get; set; }

        public virtual Abonent Abonent { get; set; }
    }
}
