using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов личных кабинетов
    /// </summary>
    public partial class PortalType
    {
        public PortalType()
        {
            PortalAccounts = new HashSet<PortalAccount>();
            RegRequestAccounts = new HashSet<RegRequestAccount>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int PortalTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PortalTypeName { get; set; }

        public virtual ICollection<PortalAccount> PortalAccounts { get; set; }
        public virtual ICollection<RegRequestAccount> RegRequestAccounts { get; set; }
    }
}
