using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица маршрутов АстралОтчет
    /// </summary>
    public partial class MercuryRoute
    {

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual MercuryRecipient MercuryRecipient { get; set; }
    }
}
