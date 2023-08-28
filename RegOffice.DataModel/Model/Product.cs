using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица продуктов
    /// </summary>
    public partial class Product
    {
        public Product()
        {
            CertificateIrudRegistrations = new HashSet<CertificateIrudRegistration>();
            CertificateTariffs = new HashSet<CertificateTariff>();
            Contacts = new HashSet<Contact>();
            Licenses = new HashSet<License>();
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengers = new HashSet<MercuryMessenger>();
            MercuryPlugins = new HashSet<MercuryPlugin>();
            MercuryRecipientSteps = new HashSet<MercuryRecipientStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MercuryRoutes = new HashSet<MercuryRoute>();
            NotificationTemplateRequests = new HashSet<NotificationTemplateRequest>();
            NotificationTemplates = new HashSet<NotificationTemplate>();
            OfdProducts = new HashSet<OfdProduct>();
            PortalAccounts = new HashSet<PortalAccount>();
            ProductCheckings = new HashSet<ProductChecking>();
            ProductNetNodes = new HashSet<ProductNetNode>();
            ProductPeople = new HashSet<ProductPerson>();
            ProductPotentialMembers = new HashSet<ProductPotentialMember>();
            ProductSteps = new HashSet<ProductStep>();
            ProductTransferLogs = new HashSet<ProductTransferLog>();
            ProlongationShortData = new HashSet<ProlongationShortDatum>();
            ProxyAgents = new HashSet<ProxyAgent>();
            ReflexProducts = new HashSet<ReflexProduct>();
            RegRequests = new HashSet<RegRequest>();
            Services = new HashSet<Service>();
            Sos = new HashSet<So>();
            Tokens = new HashSet<Token>();
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
            ContractTariffs = new HashSet<ContractTariff>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public Guid ProductGuid { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? DateFixed { get; set; }

        /// <summary>
        /// Крупнейший
        /// </summary>
        public bool? FirstRate { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Привязка к СОС
        /// </summary>
        public bool? HardCodeSos { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Зависимый
        /// </summary>
        public bool? AccrRepresent { get; set; }

        /// <summary>
        /// УП
        /// </summary>
        public int? AccrRepresentId { get; set; }

        /// <summary>
        /// Тип РНС ПФР
        /// </summary>
        public bool? StPfr { get; set; }

        /// <summary>
        /// Псевдоним
        /// </summary>
        public string Pseudonym { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Почтовый логин
        /// </summary>
        public string MailLogin { get; set; }

        /// <summary>
        /// Почтовый пароль
        /// </summary>
        public string MailPassword { get; set; }

        /// <summary>
        /// Дата обновления рег-пакета
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Рег. номер продукта
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Версия программы (конфигурации)
        /// </summary>
        public string ProgramVersion { get; set; }

        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        /// <summary>
        /// Флаг ИТС
        /// </summary>
        public bool? IsIts { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string AbonentShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string AbonentFullName { get; set; }

        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string AbonentRnsPfr { get; set; }

        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string AbonentRnsFss { get; set; }

        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string AbonentKpFss { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public int? AbonentPostalAddressId { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? AbonentLocationAddressId { get; set; }

        /// <summary>
        /// Эл. почта
        /// </summary>
        public string AbonentEmail { get; set; }

        /// <summary>
        /// Частичный рег-файл
        /// </summary>
        public bool IsPartial { get; set; }

        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }

        /// <summary>
        /// СМС подтверждение
        /// </summary>
        public bool SmsConfirmation { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Рег-файл
        /// </summary>
        public int? RegFileId { get; set; }

        /// <summary>
        /// Пакет обновления
        /// </summary>
        public int? PacketId { get; set; }

        /// <summary>
        /// Файл лицензии
        /// </summary>
        public int? LicFileId { get; set; }

        /// <summary>
        /// Отложенное обновление
        /// </summary>
        public bool LazyUpdate { get; set; }

        /// <summary>
        /// УП
        /// </summary>
        public int? ProxyAgentId { get; set; }

        /// <summary>
        /// Конфиденциальные данные
        /// </summary>
        public int? SafeId { get; set; }

        /// <summary>
        /// Идентификатор системы налогообложения
        /// </summary>
        public int? TaxSystemId { get; set; }

        /// <summary>
        /// Идентификатор типа абонента этого продукта
        /// </summary>
        public int? AbonentTypeId { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        public string Okpo { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Addr AbonentLocationAddress { get; set; }
        public virtual Addr AbonentPostalAddress { get; set; }
        public virtual AbonentType AbonentType { get; set; }
        public virtual Abonent AccrRepresentNavigation { get; set; }
        public virtual Category Category { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProxyAgent ProxyAgent { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual TaxSystem TaxSystem { get; set; }
        public virtual Point TransferPoint { get; set; }
        public virtual User User { get; set; }
        public virtual ProductNotice ProductNotice { get; set; }
        public virtual ProductSkrinInfo ProductSkrinInfo { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrations { get; set; }
        public virtual ICollection<CertificateTariff> CertificateTariffs { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<MercuryPlugin> MercuryPlugins { get; set; }
        public virtual ICollection<MercuryRecipientStep> MercuryRecipientSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MercuryRoute> MercuryRoutes { get; set; }
        public virtual ICollection<NotificationTemplateRequest> NotificationTemplateRequests { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
        public virtual ICollection<OfdProduct> OfdProducts { get; set; }
        public virtual ICollection<PortalAccount> PortalAccounts { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<ProductNetNode> ProductNetNodes { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPotentialMember> ProductPotentialMembers { get; set; }
        public virtual ICollection<ProductStep> ProductSteps { get; set; }
        public virtual ICollection<ProductTransferLog> ProductTransferLogs { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortData { get; set; }
        public virtual ICollection<ProxyAgent> ProxyAgents { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<So> Sos { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
    }
}
