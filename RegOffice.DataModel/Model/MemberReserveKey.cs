using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица резервных ключей сотрудников
    /// </summary>
    public partial class MemberReserveKey
    {

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int? ProviderId { get; set; }

        /// <summary>
        /// Контейнер
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Ссылка на УЦ
        /// </summary>
        public int? CaId { get; set; }

        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string SubjectKeyId { get; set; }

        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual File CertRequest { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
