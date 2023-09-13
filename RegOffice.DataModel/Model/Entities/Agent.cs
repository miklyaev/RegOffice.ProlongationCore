using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Agent
    {
        public Agent()
        {
            AgentAgreements = new HashSet<AgentAgreement>();
            AgentBalances = new HashSet<AgentBalance>();
            AgentContracts = new HashSet<AgentContract>();
            AgentMerchandiseBillFromAgents = new HashSet<AgentMerchandise>();
            AgentMerchandiseBillToAgents = new HashSet<AgentMerchandise>();
            AgentRegions = new HashSet<AgentRegion>();
            AgentRewards = new HashSet<AgentReward>();
            AgentSchemeAgents = new HashSet<AgentScheme>();
            AgentSchemeParents = new HashSet<AgentScheme>();
            AgentSettings = new HashSet<AgentSetting>();
            CcItsBalances = new HashSet<CcItsBalance>();
            CertificateTariffs = new HashSet<CertificateTariff>();
            InterviewAgents = new HashSet<InterviewAgent>();
            InverseOldParent = new HashSet<Agent>();
            InverseParent = new HashSet<Agent>();
            Its = new HashSet<Its>();
            ItsDistributors = new HashSet<ItsDistributor>();
            MessengerAgents = new HashSet<MessengerAgent>();
            NewsVisibilities = new HashSet<NewsVisibility>();
            OfdDeviceAgents = new HashSet<OfdDevice>();
            OfdDeviceAstralKkts = new HashSet<OfdDevice>();
            OfdDeviceParents = new HashSet<OfdDevice>();
            OfdPinAgents = new HashSet<OfdPin>();
            OfdPinParents = new HashSet<OfdPin>();
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
            OfdPrefixes = new HashSet<OfdPrefix>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            Points = new HashSet<Point>();
            RegRequests = new HashSet<RegRequest>();
            Reports = new HashSet<Report>();
            SendedBillAgentFroms = new HashSet<SendedBill>();
            SendedBillAgentTos = new HashSet<SendedBill>();
            Servers = new HashSet<Server>();
            SkziLicenses = new HashSet<SkziLicense>();
            Sos = new HashSet<Sos>();
            UserAgentTrusteds = new HashSet<UserAgentTrusted>();
            Users = new HashSet<User>();
        }

        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public string Cuid { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? OffTime { get; set; }
        public int LevelId { get; set; }
        public int? ParentId { get; set; }
        public int? AbonentId { get; set; }
        public int? ContractId { get; set; }
        public string SupportPhone { get; set; }
        public string SupportEmail { get; set; }
        public string InvoicePrefix { get; set; }
        public int? OldParentId { get; set; }
        public bool? IsBit { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Code1c { get; set; }
        public string Comment { get; set; }
        public bool? Distributor1c { get; set; }
        public Guid AgentGuid { get; set; }
        public int? LevelAucId { get; set; }
        public int? BusinessRegionId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual AgentBusinessRegion BusinessRegion { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual VipnetNode Cu { get; set; }
        public virtual AgentLevel Level { get; set; }
        public virtual AgentLevelAuc LevelAuc { get; set; }
        public virtual Agent OldParent { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual ICollection<AgentAgreement> AgentAgreements { get; set; }
        public virtual ICollection<AgentBalance> AgentBalances { get; set; }
        public virtual ICollection<AgentContract> AgentContracts { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandiseBillFromAgents { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandiseBillToAgents { get; set; }
        public virtual ICollection<AgentRegion> AgentRegions { get; set; }
        public virtual ICollection<AgentReward> AgentRewards { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemeAgents { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemeParents { get; set; }
        public virtual ICollection<AgentSetting> AgentSettings { get; set; }
        public virtual ICollection<CcItsBalance> CcItsBalances { get; set; }
        public virtual ICollection<CertificateTariff> CertificateTariffs { get; set; }
        public virtual ICollection<InterviewAgent> InterviewAgents { get; set; }
        public virtual ICollection<Agent> InverseOldParent { get; set; }
        public virtual ICollection<Agent> InverseParent { get; set; }
        public virtual ICollection<Its> Its { get; set; }
        public virtual ICollection<ItsDistributor> ItsDistributors { get; set; }
        public virtual ICollection<MessengerAgent> MessengerAgents { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<OfdDevice> OfdDeviceAgents { get; set; }
        public virtual ICollection<OfdDevice> OfdDeviceAstralKkts { get; set; }
        public virtual ICollection<OfdDevice> OfdDeviceParents { get; set; }
        public virtual ICollection<OfdPin> OfdPinAgents { get; set; }
        public virtual ICollection<OfdPin> OfdPinParents { get; set; }
        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
        public virtual ICollection<OfdPrefix> OfdPrefixes { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<SendedBill> SendedBillAgentFroms { get; set; }
        public virtual ICollection<SendedBill> SendedBillAgentTos { get; set; }
        public virtual ICollection<Server> Servers { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
        public virtual ICollection<Sos> Sos { get; set; }
        public virtual ICollection<UserAgentTrusted> UserAgentTrusteds { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
