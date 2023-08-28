using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица спецоператоров
    /// </summary>
    public partial class So
    {
        public So()
        {
            CertificateIrudRegistrations = new HashSet<CertificateIrudRegistration>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            SosCertificates = new HashSet<SosCertificate>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SosId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public string PrefixSos { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string LoginSos { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Системное имя
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Наименование оператора ЭДО
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// Код получателя ФНС
        /// </summary>
        public string RecipientCode { get; set; }

        /// <summary>
        /// Учетная запись
        /// </summary>
        public int? ProductId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrations { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<SosCertificate> SosCertificates { get; set; }
    }
}
