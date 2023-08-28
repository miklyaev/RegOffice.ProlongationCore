using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Система аутентификации DSS
    /// </summary>
    public partial class DssAuthSystem
    {
        public DssAuthSystem()
        {
            DssAuths = new HashSet<DssAuth>();
            Apps = new HashSet<DssApp>();
        }


        /// <summary>
        /// Идентификатор системы
        /// </summary>
        public int AuthSystemId { get; set; }

        /// <summary>
        /// Метод аутентификации
        /// </summary>
        public int MethId { get; set; }

        /// <summary>
        /// Псевдоним системы
        /// </summary>
        public string SystemAlias { get; set; }

        /// <summary>
        /// Идентификатор системы в DSS
        /// </summary>
        public string SystemId { get; set; }

        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }

        /// <summary>
        /// Используется по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual DssAuthMeth Meth { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssApp> Apps { get; set; }
    }
}
