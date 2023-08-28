using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица услуг
    /// </summary>
    public partial class Service
    {

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Ссылка на продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Номер услуги
        /// </summary>
        public string ServiceNumber { get; set; }

        /// <summary>
        /// Владелец ЭП
        /// </summary>
        public int? ProductPersonId { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
