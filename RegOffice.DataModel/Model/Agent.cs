using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица партнеров
    /// </summary>
    public partial class Agent
    {
        public Agent()
        {
            InverseOldParent = new HashSet<Agent>();
            InverseParent = new HashSet<Agent>();
            AgentBalances = new HashSet<AgentBalance>();
            AgentContracts = new HashSet<AgentContract>();
            AgentMerchandiseBillFromAgents = new HashSet<AgentMerchandise>();
            AgentMerchandiseBillToAgents = new HashSet<AgentMerchandise>();
            AgentRewards = new HashSet<AgentReward>();
            AgentSchemeAgents = new HashSet<AgentScheme>();
            AgentSchemeParents = new HashSet<AgentScheme>();
            AgentSettings = new HashSet<AgentSetting>();
            CcItsBalances = new HashSet<CcItsBalance>();
            CertificateTariffs = new HashSet<CertificateTariff>();
            Its = new HashSet<It>();
            ItsDistributors = new HashSet<ItsDistributor>();
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
            Sos = new HashSet<So>();
            Users = new HashSet<User>();
            Answers = new HashSet<InterviewAnswer>();
            Messengers = new HashSet<Messenger>();
            Regions = new HashSet<Region>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AgentName { get; set; }

        /// <summary>
        /// СМ
        /// </summary>
        public string Cuid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Владелец
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int? AbonentId { get; set; }

        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }

        /// <summary>
        /// Телефон горячей линии
        /// </summary>
        public string SupportPhone { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string SupportEmail { get; set; }
        public string InvoicePrefix { get; set; }
        public int? OldParentId { get; set; }

        /// <summary>
        /// Признак партнёра БИТ
        /// </summary>
        public bool? IsBit { get; set; }

        /// <summary>
        /// Электронная почта партнера
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон партнера
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Код партнера 1С
        /// </summary>
        public string Code1c { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Признак агента 1С
        /// </summary>
        public bool? Distributor1c { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid AgentGuid { get; set; }

        /// <summary>
        /// Уровень сертификации партнера
        /// </summary>
        public int? LevelAucId { get; set; }

        /// <summary>
        /// Идентификатор бизнес-региона
        /// </summary>
        public int? BusinessRegionId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual AgentBusinessRegion BusinessRegion { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual VipnetNode Cu { get; set; }
        public virtual AgentLevel Level { get; set; }
        public virtual Agent OldParent { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual ICollection<Agent> InverseOldParent { get; set; }
        public virtual ICollection<Agent> InverseParent { get; set; }
        public virtual ICollection<AgentBalance> AgentBalances { get; set; }
        public virtual ICollection<AgentContract> AgentContracts { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandiseBillFromAgents { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandiseBillToAgents { get; set; }
        public virtual ICollection<AgentReward> AgentRewards { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemeAgents { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemeParents { get; set; }
        public virtual ICollection<AgentSetting> AgentSettings { get; set; }
        public virtual ICollection<CcItsBalance> CcItsBalances { get; set; }
        public virtual ICollection<CertificateTariff> CertificateTariffs { get; set; }
        public virtual ICollection<It> Its { get; set; }
        public virtual ICollection<ItsDistributor> ItsDistributors { get; set; }
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
        public virtual ICollection<So> Sos { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<InterviewAnswer> Answers { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
