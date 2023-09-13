using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Step
    {
        public Step()
        {
            AbonentImportTasks = new HashSet<AbonentImportTask>();
            AgentBalanceDetailChangeRequestSteps = new HashSet<AgentBalanceDetailChangeRequestStep>();
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            ApplicationSteps = new HashSet<ApplicationStep>();
            Applications = new HashSet<Application>();
            BalanceBuildTasks = new HashSet<BalanceBuildTask>();
            BlockRequisiteTasks = new HashSet<BlockRequisiteTask>();
            BulkSkziLicenseUploadTasks = new HashSet<BulkSkziLicenseUploadTask>();
            CertificateIrudRegistrationCertificateRegistrationSteps = new HashSet<CertificateIrudRegistration>();
            CertificateIrudRegistrationCertificateStates = new HashSet<CertificateIrudRegistration>();
            CertificateRequestStepNextSteps = new HashSet<CertificateRequestStep>();
            CertificateRequestStepPreviousSteps = new HashSet<CertificateRequestStep>();
            CertificateRequestStepSteps = new HashSet<CertificateRequestStep>();
            CertificateRequests = new HashSet<CertificateRequest>();
            CertificateRevokeRequests = new HashSet<CertificateRevokeRequest>();
            CertificateServices = new HashSet<CertificateService>();
            CertificateSteps = new HashSet<CertificateStep>();
            CertificateTariffSteps = new HashSet<CertificateTariffStep>();
            CertificateTariffs = new HashSet<CertificateTariff>();
            Certificates = new HashSet<Certificate>();
            ContractSteps = new HashSet<ContractStep>();
            ContractTariffSteps = new HashSet<ContractTariffStep>();
            ContractTariffs = new HashSet<ContractTariff>();
            Contracts = new HashSet<Contract>();
            DssAuthKeySteps = new HashSet<DssAuthKeyStep>();
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuthSteps = new HashSet<DssAuthStep>();
            DssAuths = new HashSet<DssAuth>();
            DssUserAuthSteps = new HashSet<DssUserAuthStep>();
            DssUsers = new HashSet<DssUser>();
            InterviewSteps = new HashSet<InterviewStep>();
            Interviews = new HashSet<Interview>();
            InverseNextStep = new HashSet<Step>();
            LicensePoolSteps = new HashSet<LicensePoolStep>();
            LicensePools = new HashSet<LicensePool>();
            LicenseSteps = new HashSet<LicenseStep>();
            Licenses = new HashSet<License>();
            MercuryMessengerStepNextSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengerStepPreviousSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengerStepSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengers = new HashSet<MercuryMessenger>();
            MercuryRecipientSteps = new HashSet<MercuryRecipientStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            OfdPins = new HashSet<OfdPin>();
            Okopfs = new HashSet<Okopf>();
            Orders = new HashSet<Order>();
            PointSteps = new HashSet<PointStep>();
            Points = new HashSet<Point>();
            PotentialAbonentSteps = new HashSet<PotentialAbonentStep>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            ProductCheckingSteps = new HashSet<ProductCheckingStep>();
            ProductCheckings = new HashSet<ProductChecking>();
            ProductNetNodeSteps = new HashSet<ProductNetNodeStep>();
            ProductNetNodes = new HashSet<ProductNetNode>();
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonKeySteps = new HashSet<ProductPersonKeyStep>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            ProductPersonSteps = new HashSet<ProductPersonStep>();
            ProductSteps = new HashSet<ProductStep>();
            Products = new HashSet<Product>();
            RaSteps = new HashSet<RaStep>();
            Ras = new HashSet<Ra>();
            RegBankRequestSteps = new HashSet<RegBankRequestStep>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegCertRequestSteps = new HashSet<RegCertRequestStep>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestCheckingSteps = new HashSet<RegRequestCheckingStep>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequestSteps = new HashSet<RegRequestStep>();
            RegRequests = new HashSet<RegRequest>();
            RejectedRegRequests = new HashSet<RejectedRegRequest>();
            Reports = new HashSet<Report>();
            Request1cs = new HashSet<Request1c>();
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
            TransitionNextSteps = new HashSet<Transition>();
            TransitionSteps = new HashSet<Transition>();
            WorkflowServiceSteps = new HashSet<WorkflowServiceStep>();
            WorkflowServices = new HashSet<WorkflowService>();
        }

        public int StepId { get; set; }
        public string StepName { get; set; }
        public Guid StepGuid { get; set; }
        public int? NextStepId { get; set; }
        public string Description { get; set; }

        public virtual Step NextStep { get; set; }
        public virtual ICollection<AbonentImportTask> AbonentImportTasks { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestStep> AgentBalanceDetailChangeRequestSteps { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequest> AgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<ApplicationStep> ApplicationSteps { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<BalanceBuildTask> BalanceBuildTasks { get; set; }
        public virtual ICollection<BlockRequisiteTask> BlockRequisiteTasks { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrationCertificateRegistrationSteps { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrationCertificateStates { get; set; }
        public virtual ICollection<CertificateRequestStep> CertificateRequestStepNextSteps { get; set; }
        public virtual ICollection<CertificateRequestStep> CertificateRequestStepPreviousSteps { get; set; }
        public virtual ICollection<CertificateRequestStep> CertificateRequestStepSteps { get; set; }
        public virtual ICollection<CertificateRequest> CertificateRequests { get; set; }
        public virtual ICollection<CertificateRevokeRequest> CertificateRevokeRequests { get; set; }
        public virtual ICollection<CertificateService> CertificateServices { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
        public virtual ICollection<CertificateTariffStep> CertificateTariffSteps { get; set; }
        public virtual ICollection<CertificateTariff> CertificateTariffs { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<ContractStep> ContractSteps { get; set; }
        public virtual ICollection<ContractTariffStep> ContractTariffSteps { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<DssAuthKeyStep> DssAuthKeySteps { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuthStep> DssAuthSteps { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssUserAuthStep> DssUserAuthSteps { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<InterviewStep> InterviewSteps { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<Step> InverseNextStep { get; set; }
        public virtual ICollection<LicensePoolStep> LicensePoolSteps { get; set; }
        public virtual ICollection<LicensePool> LicensePools { get; set; }
        public virtual ICollection<LicenseStep> LicenseSteps { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerStepNextSteps { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerStepPreviousSteps { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerStepSteps { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<MercuryRecipientStep> MercuryRecipientSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<Okopf> Okopfs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PointStep> PointSteps { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<PotentialAbonentStep> PotentialAbonentSteps { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<ProductCheckingStep> ProductCheckingSteps { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<ProductNetNodeStep> ProductNetNodeSteps { get; set; }
        public virtual ICollection<ProductNetNode> ProductNetNodes { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonKeyStep> ProductPersonKeySteps { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPersonStep> ProductPersonSteps { get; set; }
        public virtual ICollection<ProductStep> ProductSteps { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RaStep> RaSteps { get; set; }
        public virtual ICollection<Ra> Ras { get; set; }
        public virtual ICollection<RegBankRequestStep> RegBankRequestSteps { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegCertRequestStep> RegCertRequestSteps { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestCheckingStep> RegRequestCheckingSteps { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequestStep> RegRequestSteps { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<RejectedRegRequest> RejectedRegRequests { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Request1c> Request1cs { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
        public virtual ICollection<Transition> TransitionNextSteps { get; set; }
        public virtual ICollection<Transition> TransitionSteps { get; set; }
        public virtual ICollection<WorkflowServiceStep> WorkflowServiceSteps { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
