using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AccrRepresentView
    {
        public Guid? MercuryGuid { get; set; }
        public string AgentName { get; set; }
        public string OfficeName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string ShortName { get; set; }
        public int? CategoryId { get; set; }
        public string AccrRepr { get; set; }
        public string ArInn { get; set; }
        public int? ProtocolId { get; set; }
        public string DomainIn { get; set; }
        public string Pseudonym { get; set; }
        public string Ruid { get; set; }
        public string ArKpp { get; set; }
    }
}
