using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица услуг по договору
    /// </summary>
    public partial class ContractTariff
    {
        public ContractTariff()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentRewards = new HashSet<AgentReward>();
            ContractTariffDiscounts = new HashSet<ContractTariffDiscount>();
            ContractTariffExtensionContractTariffs = new HashSet<ContractTariffExtension>();
            ContractTariffSteps = new HashSet<ContractTariffStep>();
            OfdPins = new HashSet<OfdPin>();
            OfdProducts = new HashSet<OfdProduct>();
            TransferTariffLogContractTariffs = new HashSet<TransferTariffLog>();
            TransferTariffLogPreviousContractTariffs = new HashSet<TransferTariffLog>();
            Keys = new HashSet<Key>();
            Products = new HashSet<Product>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Договор
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly InitialDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? EndDate { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Первичный
        /// </summary>
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Затраты
        /// </summary>
        public decimal? Cost { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
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
        public virtual ICollection<ContractTariffStep> ContractTariffSteps { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<OfdProduct> OfdProducts { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogContractTariffs { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogPreviousContractTariffs { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
