using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица DSS-приложений владельцев ЭП
    /// </summary>
    public partial class RegRequestMemberDssApp
    {

        /// <summary>
        /// Владелец ЭП
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Приложение DSS
        /// </summary>
        public int AppId { get; set; }
        public bool? ForceAuthUpdate { get; set; }

        public virtual DssApp App { get; set; }
        public virtual RegRequestMember Member { get; set; }
    }
}
