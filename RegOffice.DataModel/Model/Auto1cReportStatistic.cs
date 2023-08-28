using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица для формирования автоматических отчётов по 1СО и 1С-ЭТП
    /// </summary>
    public partial class Auto1cReportStatistic
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        /// Дата отчёта
        /// </summary>
        public DateOnly ReportDate { get; set; }

        /// <summary>
        /// Количество поступивших заявок
        /// </summary>
        public int? RecievedRegRequests { get; set; }

        /// <summary>
        /// Количество принятых, но не отправленных в обработку заявок
        /// </summary>
        public int? UnprocRegRequests { get; set; }

        /// <summary>
        /// Срок от 0 до 2 дней
        /// </summary>
        public int? TwoDaysCount { get; set; }

        /// <summary>
        /// Срок от 2 до 4 дней
        /// </summary>
        public int? FourDaysCount { get; set; }

        /// <summary>
        /// Срок от 4 до 6 дней
        /// </summary>
        public int? SixDaysCount { get; set; }

        /// <summary>
        /// Срок от 8 дней
        /// </summary>
        public int? MoreDaysCount { get; set; }

        /// <summary>
        /// Количество зарегистрированных пользователей
        /// </summary>
        public int? RegisteredAbonents { get; set; }

        /// <summary>
        /// Платные
        /// </summary>
        public int? Paid { get; set; }

        /// <summary>
        /// Льготные
        /// </summary>
        public int? Exclusive { get; set; }

        /// <summary>
        /// Поступившие заявки за неделю
        /// </summary>
        public int? RegRequest { get; set; }

        /// <summary>
        /// Количество активных пользователей
        /// </summary>
        public int? ActiveAbonents { get; set; }

        /// <summary>
        /// Количество партнеров
        /// </summary>
        public int? Partners { get; set; }

        /// <summary>
        /// Количество заявок 1С-ЭТП на подключение и продление
        /// </summary>
        public int? EtpRequests { get; set; }

        /// <summary>
        /// Количество активных пользователей 1С-ЭТП
        /// </summary>
        public int? EtpActiveAbonents { get; set; }

        /// <summary>
        /// Количество партнеров 1С-ЭТП
        /// </summary>
        public int? EtpPartners { get; set; }

        /// <summary>
        /// Действующие платные лицензии
        /// </summary>
        public int? TotalPaid { get; set; }

        /// <summary>
        /// Действующие льготные лицензии
        /// </summary>
        public int? TotalExclusive { get; set; }

        /// <summary>
        /// Действующие бонусные лицензии
        /// </summary>
        public int? TotalBonus { get; set; }

        /// <summary>
        /// Отвал платных лицензий
        /// </summary>
        public int? UnactivePaid { get; set; }

        /// <summary>
        /// Отвал льготных лицензий
        /// </summary>
        public int? UnactiveExclusive { get; set; }

        /// <summary>
        /// ЭТП количество поступивших заявок
        /// </summary>
        public int? EtpRecievedRegRequests { get; set; }

        /// <summary>
        /// ЭТП количество принятых, но неотправленных в обработку заявок
        /// </summary>
        public int? EtpUnprocRegRequests { get; set; }

        /// <summary>
        /// ЭТП Срок от 0 до 2 дней
        /// </summary>
        public int? EtpTwoDaysCount { get; set; }

        /// <summary>
        /// ЭТП Срок от 2 до 7 дней
        /// </summary>
        public int? EtpSevenDaysCount { get; set; }

        /// <summary>
        /// ЭТП Срок от 7 до 28 дней
        /// </summary>
        public int? EtpTwentyEightDaysCount { get; set; }

        /// <summary>
        /// ЭТП Срок от 28 дней
        /// </summary>
        public int? EtpMoreDaysCount { get; set; }

        /// <summary>
        /// Количество зарегистрированных заявок 1С-ЭТП
        /// </summary>
        public int? EtpRegRequests { get; set; }

        /// <summary>
        /// Количество зарегистрированных заявок 1С-ЭТП(ПА)
        /// </summary>
        public int? EtpPaRegRequests { get; set; }

        /// <summary>
        /// Количество отвала абонентов
        /// </summary>
        public int? EtpUnactiveAbonents { get; set; }

        /// <summary>
        /// Срок от 6 до 8 дней
        /// </summary>
        public int? EightDaysCount { get; set; }

        /// <summary>
        /// Ответ сервиса статистики работы ТП(инциденты)
        /// </summary>
        public string SupportStatDataIncidentsEtsJson { get; set; }

        /// <summary>
        /// Ответ сервиса статистики работы ТП по 1C(инциденты)
        /// </summary>
        public string SupportStatDataIncidentsJson { get; set; }

        /// <summary>
        /// Ответ сервиса статистики работы ТП по ЭТП(звонки)
        /// </summary>
        public string SupportStatDataCallsEtsJson { get; set; }

        /// <summary>
        /// Ответ сервиса статистики работы ТП по 1С(звонки)
        /// </summary>
        public string SupportStatDataCallsJson { get; set; }
    }
}
