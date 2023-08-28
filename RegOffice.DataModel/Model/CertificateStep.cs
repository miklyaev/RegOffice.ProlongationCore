using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний сертификатов
    /// </summary>
    public partial class CertificateStep
    {

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Идентификатор действия
        /// </summary>
        public int? ActionId { get; set; }

        /// <summary>
        /// Идентификатор причины
        /// </summary>
        public int? ReasonId { get; set; }

        /// <summary>
        /// Дата и время начала действия
        /// </summary>
        public DateTime? ActionStartTime { get; set; }

        /// <summary>
        /// Дата и время окончания действия
        /// </summary>
        public DateTime? ActionEndTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual CaAction Action { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RevocationReason Reason { get; set; }
        public virtual Step Step { get; set; }
    }
}
