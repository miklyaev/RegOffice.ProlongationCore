using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица дистрибьюторов ИТС
    /// </summary>
    public partial class ItsDistributor
    {

        /// <summary>
        /// Наименование дистрибьютора
        /// </summary>
        public string ItsDistributorName { get; set; }

        /// <summary>
        /// ЦП
        /// </summary>
        public int? AgentId { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
