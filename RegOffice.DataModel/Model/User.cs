using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица пользователей
    /// </summary>
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
            Interviews = new HashSet<Interview>();
            LicenseSteps = new HashSet<LicenseStep>();
            LogExtendeds = new HashSet<LogExtended>();
            MercuryRecipientSteps = new HashSet<MercuryRecipientStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            News = new HashSet<News>();
            NewsBrowsings = new HashSet<NewsBrowsing>();
            NewsReviews = new HashSet<NewsReview>();
            OfdDevices = new HashSet<OfdDevice>();
            OfdPins = new HashSet<OfdPin>();
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
            RefreshTokens = new HashSet<RoRefreshToken>();
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
            Answers = new HashSet<InterviewAnswer>();
            Offices = new HashSet<Office>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        public int leId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeWorkId { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Эл почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Парольная фраза
        /// </summary>
        public string PasswordPhrase { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public int? PostId { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Дата документа
        /// </summary>
        public DateOnly? DocumentDate { get; set; }

        /// <summary>
        /// ФИО по доверенности
        /// </summary>
        public string AuthorizationName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid UserGuid { get; set; }

        /// <summary>
        /// Сертификат пользователя
        /// </summary>
        public int? CertificateId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Office OfficeWork { get; set; }
        public virtual Post Post { get; set; }
        public virtual Role le { get; set; }
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
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<LicenseStep> LicenseSteps { get; set; }
        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
        public virtual ICollection<MercuryRecipientStep> MercuryRecipientSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<NewsBrowsing> NewsBrowsings { get; set; }
        public virtual ICollection<NewsReview> NewsReviews { get; set; }
        public virtual ICollection<OfdDevice> OfdDevices { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
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
        public virtual ICollection<RoRefreshToken> RefreshTokens { get; set; }
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
        public virtual ICollection<InterviewAnswer> Answers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
