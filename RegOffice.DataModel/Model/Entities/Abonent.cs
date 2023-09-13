using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Abonent
    {
        public Abonent()
        {
            AbonentPeople = new HashSet<AbonentPerson>();
            AgentBalanceDetailAbonents = new HashSet<AgentBalanceDetail>();
            AgentBalanceDetailAccrRepresents = new HashSet<AgentBalanceDetail>();
            AgentBalanceDetailCompanyGroups = new HashSet<AgentBalanceDetail>();
            Agents = new HashSet<Agent>();
            AstralWorkflowClients = new HashSet<AstralWorkflowClient>();
            CompanyGroupAbonents = new HashSet<CompanyGroupAbonent>();
            CompanyGroups = new HashSet<CompanyGroup>();
            Contracts = new HashSet<Contract>();
            Docs = new HashSet<Doc>();
            InverseCompanyGroup = new HashSet<Abonent>();
            ProductAbonents = new HashSet<Product>();
            ProductAccrRepresentNavigations = new HashSet<Product>();
            ProductDocs = new HashSet<ProductDoc>();
            ProlongationShortDatas = new HashSet<ProlongationShortDatum>();
            ProxyAgents = new HashSet<ProxyAgent>();
            RegRequests = new HashSet<RegRequest>();
            SendedBills = new HashSet<SendedBill>();
            StatisticProviders = new HashSet<StatisticProvider>();
        }

        public int AbonentId { get; set; }
        public int AbonentTypeId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string RnsPfr { get; set; }
        public string RnsFss { get; set; }
        public string KpFss { get; set; }
        public int? PostalAddressId { get; set; }
        public int? LocationAddressId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int OfficeId { get; set; }
        public int? OkopfId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string StRnsPfr { get; set; }
        public int? UserId { get; set; }
        public string AbonentLogin { get; set; }
        public string AbonentPassword { get; set; }
        public string ContactPeople { get; set; }
        public int? CompanyGroupId { get; set; }
        public string RawPostalAddress { get; set; }
        public string RawLocationAddress { get; set; }
        public string RawContacts { get; set; }
        public string PaymentAccount { get; set; }
        public string BankName { get; set; }
        public string Bic { get; set; }
        public string CorrespondentAccount { get; set; }
        public string Note { get; set; }
        public string PersonalAccount { get; set; }
        public int RegionId { get; set; }
        public Guid AbonentGuid { get; set; }
        public string EmplParentNo { get; set; }
        public string RnsFssSub { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Abonent CompanyGroup { get; set; }
        public virtual Addr LocationAddress { get; set; }
        public virtual Office Office { get; set; }
        public virtual Okopf Okopf { get; set; }
        public virtual Addr PostalAddress { get; set; }
        public virtual Region Region { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AbonentPerson> AbonentPeople { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetailAbonents { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetailAccrRepresents { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetailCompanyGroups { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<AstralWorkflowClient> AstralWorkflowClients { get; set; }
        public virtual ICollection<CompanyGroupAbonent> CompanyGroupAbonents { get; set; }
        public virtual ICollection<CompanyGroup> CompanyGroups { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<Abonent> InverseCompanyGroup { get; set; }
        public virtual ICollection<Product> ProductAbonents { get; set; }
        public virtual ICollection<Product> ProductAccrRepresentNavigations { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortDatas { get; set; }
        public virtual ICollection<ProxyAgent> ProxyAgents { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<SendedBill> SendedBills { get; set; }
        public virtual ICollection<StatisticProvider> StatisticProviders { get; set; }
    }
}
