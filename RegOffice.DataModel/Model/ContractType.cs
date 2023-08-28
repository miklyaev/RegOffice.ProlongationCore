using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов договоров
    /// </summary>
    public partial class ContractType
    {
        public ContractType()
        {
            AgentContracts = new HashSet<AgentContract>();
            Contracts = new HashSet<Contract>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ContractTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractTypeName { get; set; }

        public virtual ICollection<AgentContract> AgentContracts { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
