using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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
            ProductTariffs = new HashSet<ProductTariff>();
            ProductTransferLogs = new HashSet<ProductTransferLog>();
            ProlongationShortDatas = new HashSet<ProlongationShortDatum>();
            ProxyAgents = new HashSet<ProxyAgent>();
            ReflexProducts = new HashSet<ReflexProduct>();
            RegRequests = new HashSet<RegRequest>();
            Services = new HashSet<Service>();
            Sos = new HashSet<Sos>();
            Tokens = new HashSet<Token>();
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
        }

        public int ProductId { get; set; }
        public Guid ProductGuid { get; set; }
        public int AbonentId { get; set; }
        public int? ContractId { get; set; }
        public int OfficeId { get; set; }
        public DateTime? DateFixed { get; set; }
        public bool? FirstRate { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public bool? HardCodeSos { get; set; }
        public int? CategoryId { get; set; }
        public int ProductTypeId { get; set; }
        public bool? AccrRepresent { get; set; }
        public int? AccrRepresentId { get; set; }
        public bool? StPfr { get; set; }
        public string Pseudonym { get; set; }
        public int? UserId { get; set; }
        public string MailLogin { get; set; }
        public string MailPassword { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string RegistrationNumber { get; set; }
        public string ProgramVersion { get; set; }
        public int? StorageTypeId { get; set; }
        public bool? IsIts { get; set; }
        public string AbonentShortName { get; set; }
        public string AbonentFullName { get; set; }
        public string AbonentRnsPfr { get; set; }
        public string AbonentRnsFss { get; set; }
        public string AbonentKpFss { get; set; }
        public int? AbonentPostalAddressId { get; set; }
        public int? AbonentLocationAddressId { get; set; }
        public string AbonentEmail { get; set; }
        public bool IsPartial { get; set; }
        public int? TransferPointId { get; set; }
        public bool SmsConfirmation { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
        public int? RegFileId { get; set; }
        public int? PacketId { get; set; }
        public int? LicFileId { get; set; }
        public bool LazyUpdate { get; set; }
        public int? ProxyAgentId { get; set; }
        public int? SafeId { get; set; }
        public int? TaxSystemId { get; set; }
        public int? AbonentTypeId { get; set; }
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
        public virtual ICollection<ProductTariff> ProductTariffs { get; set; }
        public virtual ICollection<ProductTransferLog> ProductTransferLogs { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortDatas { get; set; }
        public virtual ICollection<ProxyAgent> ProxyAgents { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Sos> Sos { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
    }
}
