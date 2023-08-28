using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица потенциальных направлений для пользователей в заявке
    /// </summary>
    public partial class RegRequestPotentialMemberProtocol
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestPotentialMemberProtocolId { get; set; }

        /// <summary>
        /// Потенциальный пользователь
        /// </summary>
        public int RegRequestPotentialMemberId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Признак шифровальщика
        /// </summary>
        public bool? IsEncryptor { get; set; }

        public virtual Protocol Protocol { get; set; }
        public virtual RegRequestPotentialMember RegRequestPotentialMember { get; set; }
    }
}
