using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица потенциальных направлений для пользователей в продукте
    /// </summary>
    public partial class ProductPotentialMemberProtocol
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductPotentialMemberProtocolId { get; set; }

        /// <summary>
        /// Потенциальный пользователь
        /// </summary>
        public int ProductPotentialMemberId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Признак шифровальщика
        /// </summary>
        public bool? IsEncryptor { get; set; }

        public virtual ProductPotentialMember ProductPotentialMember { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
