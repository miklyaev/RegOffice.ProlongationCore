using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица для описания доп. услуг, указанных в заявке.
    /// </summary>
    public partial class RegRequestService
    {

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Ссылка на заявку
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Номер услуги
        /// </summary>
        public string ServiceNumber { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? MemberId { get; set; }

        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual User User { get; set; }
    }
}
