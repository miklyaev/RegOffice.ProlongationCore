using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица получателей запроса на регистрацию
    /// </summary>
    public partial class RegRequestRecipient
    {
        public RegRequestRecipient()
        {
            RegRequestRoutes = new HashSet<RegRequestRoute>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Запрос
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; }

        /// <summary>
        /// Номер участка
        /// </summary>
        public int? Index { get; set; }

        public virtual Protocol Protocol { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual ICollection<RegRequestRoute> RegRequestRoutes { get; set; }
    }
}
