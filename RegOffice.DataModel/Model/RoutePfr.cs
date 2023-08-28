using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица роутинга ПФР
    /// </summary>
    public partial class RoutePfr
    {
        public RoutePfr()
        {
            InverseRoutePfrNavigation = new HashSet<RoutePfr>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public string PfrCode { get; set; }

        /// <summary>
        /// Код роутинга
        /// </summary>
        public string utePfr { get; set; }

        /// <summary>
        /// Код макета
        /// </summary>
        public string LayoutPfr { get; set; }

        /// <summary>
        /// Маска файла
        /// </summary>
        public int FileMaskId { get; set; }

        public virtual FileMask FileMask { get; set; }
        public virtual RoutePfr utePfrNavigation { get; set; }
        public virtual ICollection<RoutePfr> InverseRoutePfrNavigation { get; set; }
    }
}
