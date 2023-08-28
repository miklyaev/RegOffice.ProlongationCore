using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица режимов аутентификации пользователей DSS
    /// </summary>
    public partial class DssAuthMode
    {
        public DssAuthMode()
        {
            DssUsers = new HashSet<DssUser>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ModeId { get; set; }

        /// <summary>
        /// Название режима
        /// </summary>
        public string ModeName { get; set; }

        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
