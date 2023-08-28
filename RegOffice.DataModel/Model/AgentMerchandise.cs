using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Список номенклатур у партнера
    /// </summary>
    public partial class AgentMerchandise
    {

        /// <summary>
        /// Ид партнера которому выставляется счет
        /// </summary>
        public int BillToAgentId { get; set; }

        /// <summary>
        /// Ид номенклатуры
        /// </summary>
        public int MerchandiseId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        public int AgentMerchandiseId { get; set; }

        /// <summary>
        /// Агент от которого выставляется счет
        /// </summary>
        public int? BillFromAgentId { get; set; }

        public virtual Agent BillFromAgent { get; set; }
        public virtual Agent BillToAgent { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
