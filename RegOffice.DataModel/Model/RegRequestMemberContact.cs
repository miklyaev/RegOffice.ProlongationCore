using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Контактные данные сотрудника
    /// </summary>
    public partial class RegRequestMemberContact
    {
        public RegRequestMemberContact()
        {
            RegRequestMemberContactUses = new HashSet<RegRequestMemberContactUse>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int RegRequestMemberId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; }

        public virtual RegRequestMember RegRequestMember { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<RegRequestMemberContactUse> RegRequestMemberContactUses { get; set; }
    }
}
