using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CaService
    {

        /// <summary>
        /// Тип услуги
        /// </summary>
        public int CaServiceTypeId { get; set; }

        /// <summary>
        /// Схема
        /// </summary>
        public int SchemeId { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        public virtual CaServiceType CaServiceType { get; set; }
        public virtual AgentScheme Scheme { get; set; }
    }
}
