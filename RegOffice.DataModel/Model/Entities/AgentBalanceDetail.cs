using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceDetail
    {
        public AgentBalanceDetail()
        {
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            ServiceBalanceDetails = new HashSet<ServiceBalanceDetail>();
        }

        public int BalanceDetailId { get; set; }
        public int AbonentId { get; set; }
        public int? CompanyGroupId { get; set; }
        public bool IsIts { get; set; }
        public string RegistraionNumber { get; set; }
        public int BalanceId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public decimal? Cost { get; set; }
        public bool? IsPaid { get; set; }
        public bool IsBonus { get; set; }
        public int? TariffId { get; set; }
        public int? ContractTariffId { get; set; }
        public string SpecialNumber { get; set; }
        public int Number { get; set; }
        public int NumberNew { get; set; }
        public int? AccrRepresentId { get; set; }
        public string RegisteredName { get; set; }
        public string MainTariffRegisteredName { get; set; }
        public DateTime? MainTariffRegistrationDate { get; set; }
        public string AbonentTariffName { get; set; }
        public DateTime? MainTariffInitialDate { get; set; }
        public DateTime? AbonentTariffInitialDate { get; set; }
        public DateTime? AbonentTariffRegDate { get; set; }
        public decimal? CaServicePrice { get; set; }
        public decimal? ScCaServicePrice { get; set; }
        public int? CompanyGroup2Id { get; set; }
        public decimal? AgentCost { get; set; }
        public decimal? ScCost { get; set; }
        public int? DocumentId { get; set; }
        public int AgentBalanceGroupId { get; set; }
        public int? OfficeId { get; set; }
        public bool? IsPrimary { get; set; }
        public DateTime? InitialDate { get; set; }
        public decimal? AgentSumReward { get; set; }
        public decimal? ScSumReward { get; set; }
        public decimal? CcSumReward { get; set; }
        public string CompanyGroupName { get; set; }
        public string CompanyGroupInn { get; set; }
        public string CompanyGroupKpp { get; set; }
        public decimal? AgentPercentReward { get; set; }
        public decimal? ScPercentReward { get; set; }
        public decimal? CcPercentReward { get; set; }
        public bool? IsExtension { get; set; }
        public string PriceTariffArticle { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal? DiscountSum { get; set; }
        public int? DiscountId { get; set; }
        public string DiscountArticle { get; set; }
        public int? TariffZoneId { get; set; }
        public string OfficeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Deleted { get; set; }
        public string Uin1c { get; set; }
        public string ItsOptionId { get; set; }
        public decimal? Cost1c { get; set; }
        public DateTime? DeletionDate { get; set; }
        public int? DeletedUserId { get; set; }
        public bool? UpdateRequired { get; set; }
        public string SubscriberUin1c { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Abonent AccrRepresent { get; set; }
        public virtual AgentBalanceGroup AgentBalanceGroup { get; set; }
        public virtual AgentBalance Balance { get; set; }
        public virtual Abonent CompanyGroup { get; set; }
        public virtual CompanyGroup CompanyGroup2 { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
        public virtual User DeletedUser { get; set; }
        public virtual Office Office { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual TariffZone TariffZone { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequest> AgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<ServiceBalanceDetail> ServiceBalanceDetails { get; set; }
    }
}
