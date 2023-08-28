using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AbonentTariffView1c
    {
        public Guid? ContractTariffGuid { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string OptionId { get; set; }
        public int? StepId { get; set; }
        public DateOnly? InitialDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string RegisteredName { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string AgentName { get; set; }
        public string AgentInn { get; set; }
        public string AgentKpp { get; set; }
        public string AgentCode { get; set; }
        public Guid? TariffGuid { get; set; }
        public string ContactsJson { get; set; }
    }
}
