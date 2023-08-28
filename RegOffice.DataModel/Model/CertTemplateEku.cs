using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица расширений для шаблонов сертификатов
    /// </summary>
    public partial class CertTemplateEku
    {

        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }

        /// <summary>
        /// Расширение
        /// </summary>
        public int EkuId { get; set; }

        /// <summary>
        /// Обязательное
        /// </summary>
        public bool Required { get; set; }

        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Eku Eku { get; set; }
    }
}
