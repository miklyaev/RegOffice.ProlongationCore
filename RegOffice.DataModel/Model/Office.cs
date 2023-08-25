using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица офисов
    /// </summary>
    public partial class Office
    {
        public Office()
        {
            Abonents = new HashSet<Abonent>();
            Products = new HashSet<Product>();
        }

        public int OfficeId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OfficeName { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid OfficeGuid { get; set; }

        /// <summary>
        /// СУ
        /// </summary>
        public string Ruid { get; set; }

        /// <summary>
        /// ЦС
        /// </summary>
        public int DefaultCaId { get; set; }

        /// <summary>
        /// Оператор ИРУЦ
        /// </summary>
        public int? OperatorIrucId { get; set; }

        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int DefaultProviderId { get; set; }

        /// <summary>
        /// Дата подключения
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// СОС
        /// </summary>
        public int? DefaultSosId { get; set; }
        public string PfrSystemSender { get; set; }
        public string PfrSender { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        public int CertTemplateId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Пароль для работы с DSS
        /// </summary>
        public string Password { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
