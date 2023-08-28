using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний регистрации сертификатов в ИРУД
    /// </summary>
    public partial class CertificateIrudRegistration
    {

        /// <summary>
        /// Идентификатор регистрации сертификата
        /// </summary>
        public int CertificateRegistrationId { get; set; }

        /// <summary>
        /// Идентификатор сертификата
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Идентификатор спецоператора
        /// </summary>
        public int SosId { get; set; }

        /// <summary>
        /// Идентификатор состояния сертификата в ИРУД
        /// </summary>
        public int CertificateStateId { get; set; }

        /// <summary>
        /// Идентификатор статуса процесса регистрации сертификата
        /// </summary>
        public int CertificateRegistrationStepId { get; set; }

        /// <summary>
        /// Время регистрации сертификата
        /// </summary>
        public DateTime? RegistrationTime { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step CertificateRegistrationStep { get; set; }
        public virtual Step CertificateState { get; set; }
        public virtual Product Product { get; set; }
        public virtual So Sos { get; set; }
    }
}
