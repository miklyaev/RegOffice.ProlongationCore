using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContractTariff
    {
        public ContractTariff()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentRewards = new HashSet<AgentReward>();
            ContractTariffDiscounts = new HashSet<ContractTariffDiscount>();
            ContractTariffExtensionContractTariffs = new HashSet<ContractTariffExtension>();
            ContractTariffKeys = new HashSet<ContractTariffKey>();
            ContractTariffSteps = new HashSet<ContractTariffStep>();
            OfdPins = new HashSet<OfdPin>();
            OfdProducts = new HashSet<OfdProduct>();
            ProductTariffs = new HashSet<ProductTariff>();
            TransferTariffLogContractTariffs = new HashSet<TransferTariffLog>();
            TransferTariffLogPreviousContractTariffs = new HashSet<TransferTariffLog>();
        }

        public int ContractTariffId { get; set; }
        public int ContractId { get; set; }
        public int TariffId { get; set; }
        public int StepId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Price { get; set; }
        public decimal PercentDiscount { get; set; }
        public decimal DiscountSum { get; set; }
        public decimal Sum { get; set; }
        public int? UserId { get; set; }
        public int? WaitingDays { get; set; }
        public string RegistrationNumber { get; set; }
        public bool IsPrimary { get; set; }
        public int Number { get; set; }
        public int SectionId { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public Guid ContractTariffGuid { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Step Step { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual User User { get; set; }
        public virtual ContractTariffExtension ContractTariffExtensionExtension { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<AgentReward> AgentRewards { get; set; }
        public virtual ICollection<ContractTariffDiscount> ContractTariffDiscounts { get; set; }
        public virtual ICollection<ContractTariffExtension> ContractTariffExtensionContractTariffs { get; set; }
        public virtual ICollection<ContractTariffKey> ContractTariffKeys { get; set; }
        public virtual ICollection<ContractTariffStep> ContractTariffSteps { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<OfdProduct> OfdProducts { get; set; }
        public virtual ICollection<ProductTariff> ProductTariffs { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogContractTariffs { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogPreviousContractTariffs { get; set; }
    }
}
