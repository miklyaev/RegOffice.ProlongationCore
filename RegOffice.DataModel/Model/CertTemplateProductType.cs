using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица разрешенных шаблонов сертификата для типа программы
    /// </summary>
    public partial class CertTemplateProductType
    {

        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }

        /// <summary>
        /// Тип программы
        /// </summary>
        public int ProductTypeId { get; set; }
        public bool IsDefault { get; set; }

        public virtual CertTemplate CertTemplate { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
