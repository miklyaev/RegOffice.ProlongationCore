using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица масок файлов
    /// </summary>
    public partial class FileMask
    {
        public FileMask()
        {
            RoutePfrs = new HashSet<RoutePfr>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int FileMaskId { get; set; }

        /// <summary>
        /// Шаблон
        /// </summary>
        public string MaskTemplate { get; set; }

        public virtual ICollection<RoutePfr> RoutePfrs { get; set; }
    }
}
