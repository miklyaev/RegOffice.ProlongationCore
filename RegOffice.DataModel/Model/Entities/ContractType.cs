using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContractType
    {
        public ContractType()
        {
            AgentContracts = new HashSet<AgentContract>();
            Contracts = new HashSet<Contract>();
        }

        public int ContractTypeId { get; set; }
        public string ContractTypeName { get; set; }

        public virtual ICollection<AgentContract> AgentContracts { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
