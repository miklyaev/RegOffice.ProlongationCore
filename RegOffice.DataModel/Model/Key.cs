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
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
            ProductDocs = new HashSet<ProductDoc>();
            ProductPersonKeys = new HashSet<ProductPerson>();
            ProductPersonKeysNavigation = new HashSet<ProductPersonKey>();
            ProductPersonReserveKeys = new HashSet<ProductPerson>();
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
            ContractTariffs = new HashSet<ContractTariff>();
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

        public virtual Ca Ca { get; set; }
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual File Container { get; set; }
        public virtual Person Person { get; set; }
        public virtual ProtectionClass ProtectionClass { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual CaTemplate Template { get; set; }
        public virtual VipnetUser VipnetUser { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeysNavigation { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonReserveKeys { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
    }
}
