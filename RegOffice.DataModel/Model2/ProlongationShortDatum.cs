using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model2
{
    /// <summary>
    /// Таблица для вкладки &quot;Работа с продлениями&quot;
    /// </summary>
    public partial class ProlongationShortDatum
    {

        /// <summary>
        /// Идентификатор продления
        /// </summary>
        public int ProlongationId { get; set; }

        /// <summary>
        /// Идентификатор абонента
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Идентификатор договора
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// Дата окончания тарифа
        /// </summary>
        public DateOnly? TariffEndDate { get; set; }

        /// <summary>
        /// Дата окончания сертификата
        /// </summary>
        public DateOnly? CertificateEndDate { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public decimal TotalSum { get; set; }

        /// <summary>
        /// Флаг определяет факт отсутствия отправок в ФНС/ПФР при наличии соответсвующих направлений
        /// </summary>
        public bool NoDispatch { get; set; }

        /// <summary>
        /// Дата переноса
        /// </summary>
        public DateOnly? TransferDate { get; set; }

        /// <summary>
        /// Причина непродления абонента
        /// </summary>
        public int? ReasonId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Дата начала тарифа
        /// </summary>
        public DateOnly? TariffInitialDate { get; set; }

        /// <summary>
        /// Дата начала сертификата
        /// </summary>
        public DateOnly? CertificateInitialDate { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Флаг определяет необходимость проверки наличия отправок абонента
        /// </summary>
        public bool IgnoreDispatch { get; set; }

        /// <summary>
        /// Рег. номер продукта
        /// </summary>
        public string RegistrationNumber { get; set; }
    }
}
