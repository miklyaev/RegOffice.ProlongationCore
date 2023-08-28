using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица режимов обработки
    /// </summary>
    public partial class ProcessingMode
    {
        public ProcessingMode()
        {
            ProcessingProducts = new HashSet<ProcessingProduct>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ModeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ModeName { get; set; }

        public virtual ICollection<ProcessingProduct> ProcessingProducts { get; set; }
    }
}
