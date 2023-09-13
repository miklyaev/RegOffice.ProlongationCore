using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentPerson
    {
        public int PotentialAbonentId { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonPhone { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPost { get; set; }
        public string PersonAddress { get; set; }
    }
}
