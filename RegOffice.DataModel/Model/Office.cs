﻿using System;
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
            AbonentCounts = new HashSet<AbonentCount>();
            Abonents = new HashSet<Abonent>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentBalanceOffices = new HashSet<AgentBalanceOffice>();
            AgentContracts = new HashSet<AgentContract>();
            CheckingSchemes = new HashSet<CheckingScheme>();
            CompanyGroups = new HashSet<CompanyGroup>();
            Contracts = new HashSet<Contract>();
            GateProductTypes = new HashSet<GateProductType>();
            LicenseDetails = new HashSet<LicenseDetail>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            OfficeCertificates = new HashSet<OfficeCertificate>();
            OfficeDocTypes = new HashSet<OfficeDocType>();
            OfficeSettings = new HashSet<OfficeSetting>();
            OfficeTeams = new HashSet<OfficeTeam>();
            People = new HashSet<Person>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            PriceSchemeCompetenceCenters = new HashSet<PriceScheme>();
            PriceSchemeLeadOffices = new HashSet<PriceScheme>();
            ProductTransferLogOffices = new HashSet<ProductTransferLog>();
            ProductTransferLogPreviousOffices = new HashSet<ProductTransferLog>();
            Products = new HashSet<Product>();
            ProxyAgents = new HashSet<ProxyAgent>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            ReflexRules = new HashSet<ReflexRule>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestTransferLogOffices = new HashSet<RegRequestTransferLog>();
            RegRequestTransferLogPreviousOffices = new HashSet<RegRequestTransferLog>();
            RegRequests = new HashSet<RegRequest>();
            Regions = new HashSet<Region>();
            Users = new HashSet<User>();
            Schemes = new HashSet<AgentScheme>();
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
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Ca DefaultCa { get; set; }
        public virtual Provider DefaultProvider { get; set; }
        public virtual So DefaultSos { get; set; }
        public virtual OperatorIruc OperatorIruc { get; set; }
        public virtual VipnetNode Ru { get; set; }
        public virtual ICollection<AbonentCount> AbonentCounts { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<AgentBalanceOffice> AgentBalanceOffices { get; set; }
        public virtual ICollection<AgentContract> AgentContracts { get; set; }
        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
        public virtual ICollection<CompanyGroup> CompanyGroups { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<GateProductType> GateProductTypes { get; set; }
        public virtual ICollection<LicenseDetail> LicenseDetails { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<OfficeCertificate> OfficeCertificates { get; set; }
        public virtual ICollection<OfficeDocType> OfficeDocTypes { get; set; }
        public virtual ICollection<OfficeSetting> OfficeSettings { get; set; }
        public virtual ICollection<OfficeTeam> OfficeTeams { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemeCompetenceCenters { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemeLeadOffices { get; set; }
        public virtual ICollection<ProductTransferLog> ProductTransferLogOffices { get; set; }
        public virtual ICollection<ProductTransferLog> ProductTransferLogPreviousOffices { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProxyAgent> ProxyAgents { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestTransferLog> RegRequestTransferLogOffices { get; set; }
        public virtual ICollection<RegRequestTransferLog> RegRequestTransferLogPreviousOffices { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<AgentScheme> Schemes { get; set; }
    }
}
