using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица маршрутов запроса на регистрацию
    /// </summary>
    public partial class RegRequestRoute
    {

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        public virtual RegRequestRecipient Recipient { get; set; }
    }
}
