using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица необходимых типов документов для офисов
    /// </summary>
    public partial class OfficeDocType
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OfficeDocTypeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public int DocTypeId { get; set; }

        /// <summary>
        /// Обязательный
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Код шаблона сертификата
        /// </summary>
        public int? CertTemplateId { get; set; }

        public virtual CertTemplate CertTemplate { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual Office Office { get; set; }
    }
}
