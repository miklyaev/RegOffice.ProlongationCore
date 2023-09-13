using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OneSAbonentContractTariffViewEx
    {
        public int? AbonentId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string ShortName { get; set; }
        public int? ContractTariffId { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TariffId { get; set; }
        public int? ContractId { get; set; }
        public int? AgentId { get; set; }
        public int? ParentId { get; set; }
        public bool? Prolongated { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
