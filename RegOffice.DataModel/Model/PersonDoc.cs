using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документов физических лиц
    /// </summary>
    public partial class PersonDoc
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PersonDocId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }

        public virtual Doc Doc { get; set; }
        public virtual Person Person { get; set; }
    }
}
