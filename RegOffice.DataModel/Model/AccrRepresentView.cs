using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
