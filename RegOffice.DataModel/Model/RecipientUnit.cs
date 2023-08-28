using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица рабочих сертификатов получателей
    /// </summary>
    public partial class RecipientUnit
    {

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
