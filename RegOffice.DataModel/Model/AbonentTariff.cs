using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AbonentTariff
    {

        /// <summary>
        /// Гуид тарифа по договору
        /// </summary>
        public Guid ContractTariffGuid { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// Ид. опции
        /// </summary>
        public string OptionId { get; set; }

        /// <summary>
        /// Идентификационный номер пользователя 1С
        /// </summary>
        public string Uin { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateOnly InitialDate { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// Версия программы (конфигурации)
        /// </summary>
        public string ProgramVersion { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegisteredName { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Наименование агента
        /// </summary>
        public string AgentName { get; set; }

        /// <summary>
        /// ИНН агента
        /// </summary>
        public string AgentInn { get; set; }

        /// <summary>
        /// КПП агента
        /// </summary>
        public string AgentKpp { get; set; }

        /// <summary>
        /// Внешний код партнёра
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Дата синхронизации с порталом 1С
        /// </summary>
        public DateTime? SyncDate { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Контакты абонента
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// Гуид тарифа
        /// </summary>
        public Guid TariffGuid { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }
    }
}
