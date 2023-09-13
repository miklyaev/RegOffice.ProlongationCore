using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class User
    {
        public User()
        {
            AbonentImportTasks = new HashSet<AbonentImportTask>();
            Abonents = new HashSet<Abonent>();
            AgentBalanceDetailChangeRequestComments = new HashSet<AgentBalanceDetailChangeRequestComment>();
            AgentBalanceDetailChangeRequestSteps = new HashSet<AgentBalanceDetailChangeRequestStep>();
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentSchemes = new HashSet<AgentScheme>();
            AgentSettings = new HashSet<AgentSetting>();
            BalanceBuildTasks = new HashSet<BalanceBuildTask>();
            BlockRequisiteTasks = new HashSet<BlockRequisiteTask>();
            BlockedRequisites = new HashSet<BlockedRequisite>();
            BulkSkziLicenseUploadTasks = new HashSet<BulkSkziLicenseUploadTask>();
            CertificateRevokeHistories = new HashSet<CertificateRevokeHistory>();
            ContractSteps = new HashSet<ContractStep>();
            ContractTariffDiscounts = new HashSet<ContractTariffDiscount>();
            ContractTariffSteps = new HashSet<ContractTariffStep>();
            ContractTariffs = new HashSet<ContractTariff>();
            Contracts = new HashSet<Contract>();
            Docs = new HashSet<Doc>();
            Files = new HashSet<File>();
            InterviewSteps = new HashSet<InterviewStep>();
            InterviewUsers = new HashSet<InterviewUser>();
            Interviews = new HashSet<Interview>();
            LicenseSteps = new HashSet<LicenseStep>();
            LogExtendeds = new HashSet<LogExtended>();
            MercuryRecipientSteps = new HashSet<MercuryRecipientStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            News = new HashSet<News>();
            NewsBrowsings = new HashSet<NewsBrowsing>();
            NewsReviews = new HashSet<NewsReviews>();
            OfdDevices = new HashSet<OfdDevice>();
            OfdPins = new HashSet<OfdPin>();
            OfficeUsers = new HashSet<OfficeUser>();
            OperationLogs = new HashSet<OperationLog>();
            Orders = new HashSet<Order>();
            People = new HashSet<Person>();
            PotentialAbonentCalls = new HashSet<PotentialAbonentCall>();
            PotentialAbonentComments = new HashSet<PotentialAbonentComment>();
            PotentialAbonentSteps = new HashSet<PotentialAbonentStep>();
            PotentialAbonentUcbs = new HashSet<PotentialAbonentUcb>();
            PotentialAbonentUserRegions = new HashSet<PotentialAbonentUserRegion>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            ProcessingProducts = new HashSet<ProcessingProduct>();
            ProductCheckingSteps = new HashSet<ProductCheckingStep>();
            ProductCheckings = new HashSet<ProductChecking>();
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
            ProductPersonSteps = new HashSet<ProductPersonStep>();
            ProductSteps = new HashSet<ProductStep>();
            ProductTransferLogs = new HashSet<ProductTransferLog>();
            Products = new HashSet<Product>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            RefreshTokens = new HashSet<RefreshToken>();
            RegBankRequestSteps = new HashSet<RegBankRequestStep>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegCertRequestSteps = new HashSet<RegCertRequestStep>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestCheckingSteps = new HashSet<RegRequestCheckingStep>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequestComments = new HashSet<RegRequestComment>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
            RegRequestServices = new HashSet<RegRequestService>();
            RegRequestSteps = new HashSet<RegRequestStep>();
            RegRequestTransferLogs = new HashSet<RegRequestTransferLog>();
            RegRequests = new HashSet<RegRequest>();
            Tokens = new HashSet<Token>();
            UserPromotionConfirmeds = new HashSet<UserPromotionConfirmed>();
            UserRoles = new HashSet<UserRole>();
            UserSettings = new HashSet<UserSetting>();
            UserTrusts = new HashSet<UserTrust>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AgentId { get; set; }
        public DateTime CreationTime { get; set; }
        public int OfficeWorkId { get; set; }
        public DateTime? OffTime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordPhrase { get; set; }
        public string Description { get; set; }
        public int? PostId { get; set; }
        public string Document { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string AuthorizationName { get; set; }
        public string Phone { get; set; }
        public Guid UserGuid { get; set; }
        public int? CertificateId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Office OfficeWork { get; set; }
        public virtual Post Post { get; set; }
        public virtual Role Role { get; set; }
        public virtual UserAgentTrusted UserAgentTrusted { get; set; }
        public virtual UserFintender UserFintender { get; set; }
        public virtual ICollection<AbonentImportTask> AbonentImportTasks { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestComment> AgentBalanceDetailChangeRequestComments { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestStep> AgentBalanceDetailChangeRequestSteps { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequest> AgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<AgentSetting> AgentSettings { get; set; }
        public virtual ICollection<BalanceBuildTask> BalanceBuildTasks { get; set; }
        public virtual ICollection<BlockRequisiteTask> BlockRequisiteTasks { get; set; }
        public virtual ICollection<BlockedRequisite> BlockedRequisites { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<CertificateRevokeHistory> CertificateRevokeHistories { get; set; }
        public virtual ICollection<ContractStep> ContractSteps { get; set; }
        public virtual ICollection<ContractTariffDiscount> ContractTariffDiscounts { get; set; }
        public virtual ICollection<ContractTariffStep> ContractTariffSteps { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<InterviewStep> InterviewSteps { get; set; }
        public virtual ICollection<InterviewUser> InterviewUsers { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<LicenseStep> LicenseSteps { get; set; }
        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
        public virtual ICollection<MercuryRecipientStep> MercuryRecipientSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<NewsBrowsing> NewsBrowsings { get; set; }
        public virtual ICollection<NewsReviews> NewsReviews { get; set; }
        public virtual ICollection<OfdDevice> OfdDevices { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<OfficeUser> OfficeUsers { get; set; }
        public virtual ICollection<OperationLog> OperationLogs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PotentialAbonentCall> PotentialAbonentCalls { get; set; }
        public virtual ICollection<PotentialAbonentComment> PotentialAbonentComments { get; set; }
        public virtual ICollection<PotentialAbonentStep> PotentialAbonentSteps { get; set; }
        public virtual ICollection<PotentialAbonentUcb> PotentialAbonentUcbs { get; set; }
        public virtual ICollection<PotentialAbonentUserRegion> PotentialAbonentUserRegions { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<ProcessingProduct> ProcessingProducts { get; set; }
        public virtual ICollection<ProductCheckingStep> ProductCheckingSteps { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
        public virtual ICollection<ProductPersonStep> ProductPersonSteps { get; set; }
        public virtual ICollection<ProductStep> ProductSteps { get; set; }
        public virtual ICollection<ProductTransferLog> ProductTransferLogs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<RegBankRequestStep> RegBankRequestSteps { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegCertRequestStep> RegCertRequestSteps { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestCheckingStep> RegRequestCheckingSteps { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequestComment> RegRequestComments { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
        public virtual ICollection<RegRequestStep> RegRequestSteps { get; set; }
        public virtual ICollection<RegRequestTransferLog> RegRequestTransferLogs { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<UserPromotionConfirmed> UserPromotionConfirmeds { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserSetting> UserSettings { get; set; }
        public virtual ICollection<UserTrust> UserTrusts { get; set; }
    }
}
