using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица потенциальных пользователей в заявке
    /// </summary>
    public partial class RegRequestPotentialMember
    {
        public RegRequestPotentialMember()
        {
            RegRequestPotentialMemberProtocols = new HashSet<RegRequestPotentialMemberProtocol>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestPotentialMemberId { get; set; }

        /// <summary>
        /// Заявка
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Эл. адрес
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// СНИЛС
        /// </summary>
        public string Snils { get; set; }

        /// <summary>
        /// Признак администратора
        /// </summary>
        public bool? IsAdministrator { get; set; }
        public bool Unregister { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual ICollection<RegRequestPotentialMemberProtocol> RegRequestPotentialMemberProtocols { get; set; }
    }
}
