using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица приложений DSS
    /// </summary>
    public partial class DssApp
    {
        public DssApp()
        {
            RegRequestMemberDssApps = new HashSet<RegRequestMemberDssApp>();
            Systems = new HashSet<DssAuthSystem>();
            Users = new HashSet<DssUser>();
        }


        /// <summary>
        /// Идентификатор приложения
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Название приложения
        /// </summary>
        public string AppName { get; set; }

        public virtual ICollection<RegRequestMemberDssApp> RegRequestMemberDssApps { get; set; }
        public virtual ICollection<DssAuthSystem> Systems { get; set; }
        public virtual ICollection<DssUser> Users { get; set; }
    }
}
