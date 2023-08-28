using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Данные по продукту офд из заявки
    /// </summary>
    public partial class OfdProduct
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OfdProductId { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Название тарифа
        /// </summary>
        public string TariffName { get; set; }
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Дата начала действия лицензии
        /// </summary>
        public DateOnly? ContractTariffInitialDate { get; set; }

        /// <summary>
        /// Дата окончания действия лицензии
        /// </summary>
        public DateOnly? ContractTariffEndDate { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string ContractTariffRegnum { get; set; }

        /// <summary>
        /// Состояние тарифа
        /// </summary>
        public int? ContractTariffStepId { get; set; }

        /// <summary>
        /// Пин
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        /// Заводской номер ККТ
        /// </summary>
        public string SerialNumberKkt { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ
        /// </summary>
        public string RegistrationNumberKkt { get; set; }

        /// <summary>
        /// Модель ККТ
        /// </summary>
        public string ModelKkt { get; set; }

        /// <summary>
        /// Идентификатор личного кабинета ОФД
        /// </summary>
        public Guid? WalletGuid { get; set; }

        /// <summary>
        /// Срок действия фиксального накопителя
        /// </summary>
        public int? FiscalAcummValidityPeriod { get; set; }

        /// <summary>
        /// Дата активации фиксального накопителя
        /// </summary>
        public DateTime? FiscalAcummActivationDate { get; set; }

        /// <summary>
        /// Заводской номер фиксального накопителя
        /// </summary>
        public string FiscalAcummNumber { get; set; }

        /// <summary>
        /// Модель фиксального накопителя
        /// </summary>
        public string FiscalAcummModel { get; set; }

        /// <summary>
        /// Дата окончания фиксального накопителя
        /// </summary>
        public DateTime? FiscalAcummEnddate { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual Product Product { get; set; }
    }
}
