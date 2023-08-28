using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица масок темы для ПФР
    /// </summary>
    public partial class PfrSchemeSubjectMask
    {
        public PfrSchemeSubjectMask()
        {
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
        }


        /// <summary>
        /// ИД маски
        /// </summary>
        public int SubjectMaskId { get; set; }

        /// <summary>
        /// Маска
        /// </summary>
        public string SubjectMask { get; set; }

        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
    }
}
