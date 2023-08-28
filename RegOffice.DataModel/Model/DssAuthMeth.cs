using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица методов аутентификации DSS
    /// </summary>
    public partial class DssAuthMeth
    {
        public DssAuthMeth()
        {
            DssAuthSystems = new HashSet<DssAuthSystem>();
        }


        /// <summary>
        /// Флаг метода
        /// </summary>
        public int MethId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Порядок метода
        /// </summary>
        public int? AuthOrder { get; set; }

        public virtual ICollection<DssAuthSystem> DssAuthSystems { get; set; }
    }
}
