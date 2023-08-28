using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица регистрации запросов на получение банковской гарантии
    /// </summary>
    public partial class RegBankRequest
    {
        public RegBankRequest()
        {
            PotentialAbonentWorkflows = new HashSet<PotentialAbonentWorkflow>();
            RegBankRequestSteps = new HashSet<RegBankRequestStep>();
            Docs = new HashSet<Doc>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegBankRequestId { get; set; }

        /// <summary>
        /// Тип абонента
        /// </summary>
        public int AbonentTypeId { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// ОГРН
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Мобильный
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Адрес эл. почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Вресия клиента
        /// </summary>
        public string ProgramVersion { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Данные
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Номер аукциона
        /// </summary>
        public string AuctionNumber { get; set; }

        /// <summary>
        /// Идентификатор заявления
        /// </summary>
        public int? BgRequestId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly? BgInitialDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? BgEndDate { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal? BgSum { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string BgUrl { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal? BgPrice { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Addr Address { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<PotentialAbonentWorkflow> PotentialAbonentWorkflows { get; set; }
        public virtual ICollection<RegBankRequestStep> RegBankRequestSteps { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
    }
}
