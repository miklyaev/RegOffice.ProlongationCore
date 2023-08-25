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
            ContractTariffExtensionContractTariffs = new HashSet<ContractTariffExtension>();
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

        public virtual ContractTariffExtension ContractTariffExtensionExtension { get; set; }
        public virtual ICollection<ContractTariffExtension> ContractTariffExtensionContractTariffs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
