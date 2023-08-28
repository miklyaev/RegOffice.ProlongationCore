using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица масок файлов для ПФР
    /// </summary>
    public partial class PfrSchemeFileMask
    {
        public PfrSchemeFileMask()
        {
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
        }


        /// <summary>
        /// ИД маски
        /// </summary>
        public int FileMaskId { get; set; }

        /// <summary>
        /// Маска
        /// </summary>
        public string FileMask { get; set; }

        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
    }
}
