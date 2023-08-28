using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов документов
    /// </summary>
    public partial class DocumentType
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string DocumentTypeName { get; set; }
    }
}
