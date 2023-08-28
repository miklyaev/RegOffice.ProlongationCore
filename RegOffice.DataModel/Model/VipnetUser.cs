using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица пользователей ViPNet
    /// </summary>
    public partial class VipnetUser
    {
        public VipnetUser()
        {
            Keys = new HashSet<Key>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public string VipnetUserId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string VipnetUserName { get; set; }

        /// <summary>
        /// Сетевой узел
        /// </summary>
        public string VipnetNodeId { get; set; }

        public virtual VipnetNode VipnetNode { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
    }
}
