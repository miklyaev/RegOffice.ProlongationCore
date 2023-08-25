using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ключей
    /// </summary>
    public partial class Key
    {
        public Key()
        {
            ProductPersonKeys = new HashSet<ProductPerson>();
            ProductPersonReserveKeys = new HashSet<ProductPerson>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Физ. лицо
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Наименование контейнера
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// ЦС
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Пользователь ViPNet
        /// </summary>
        public string VipnetUserId { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string KeyPassword { get; set; }

        /// <summary>
        /// Парольная фраза
        /// </summary>
        public string PasswordPhrase { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Пакет
        /// </summary>
        public string PackId { get; set; }

        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int? CertTemplateId { get; set; }

        /// <summary>
        /// Класс защиты
        /// </summary>
        public int? ProtectionClassId { get; set; }

        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }

        /// <summary>
        /// Экспортируемый ключ
        /// </summary>
        public bool? Eхportable { get; set; }

        /// <summary>
        /// Шаблон УЦ
        /// </summary>
        public int? TemplateId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int? WorkflowId { get; set; }

        /// <summary>
        /// Контейнер
        /// </summary>
        public int? ContainerId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonReserveKeys { get; set; }
    }
}
