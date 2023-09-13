using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentContract
    {
        public int AgentContractId { get; set; }
        public int AgentId { get; set; }
        public string ContractName { get; set; }
        public DateTime CreateTime { get; set; }
        public int ContractTypeId { get; set; }
        public int? OfficeId { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Office Office { get; set; }
    }
}
