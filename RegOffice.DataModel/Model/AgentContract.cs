using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица договоров
    /// </summary>
    public partial class AgentContract
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentContractId { get; set; }

        /// <summary>
        /// Агент
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ContractTypeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Office Office { get; set; }
    }
}
