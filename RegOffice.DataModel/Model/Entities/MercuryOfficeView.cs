using System;
using System.Collections.Generic;
using System.Net;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MercuryOfficeView
    {
        public Guid? MercuryGuid { get; set; }
        public string Ruid { get; set; }
        public string OfficeName { get; set; }
        public string AgentName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string RnsPfr { get; set; }
        public string ShortName { get; set; }
        public int? ProtocolId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Mobile { get; set; }
        public string DomainIn { get; set; }
        public IPAddress IpAddress { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DateFixed { get; set; }
        public string ProviderName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? TypeId { get; set; }
    }
}
