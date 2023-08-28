using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Позиции в сверке между партнером и Центром продаж
    /// </summary>
    public partial class AgentBalanceDetail
    {
        public AgentBalanceDetail()
        {
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            ServiceBalanceDetails = new HashSet<ServiceBalanceDetail>();
        }


        /// <summary>
        /// Идентификатор позиции в сверке
        /// </summary>
        public int BalanceDetailId { get; set; }

        /// <summary>
        /// Сверяемый абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroupId { get; set; }

        /// <summary>
        /// Подключение в рамках подписки ИТС ПРОФ
        /// </summary>
        public bool IsIts { get; set; }

        /// <summary>
        /// Регистрационный номер продукта
        /// </summary>
        public string RegistraionNumber { get; set; }

        /// <summary>
        /// Сверка
        /// </summary>
        public int BalanceId { get; set; }
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal? Cost { get; set; }

        /// <summary>
        /// Платное подключение
        /// </summary>
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Бонусное подключение
        /// </summary>
        public bool IsBonus { get; set; }

        /// <summary>
        /// Текущий тариф
        /// </summary>
        public int? TariffId { get; set; }

        /// <summary>
        /// Контракт-тариф
        /// </summary>
        public int? ContractTariffId { get; set; }

        /// <summary>
        /// Специальное разрешение
        /// </summary>
        public string SpecialNumber { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Новое количество
        /// </summary>
        public int NumberNew { get; set; }

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? AccrRepresentId { get; set; }

        /// <summary>
        /// Наименование тарифа
        /// </summary>
        public string RegisteredName { get; set; }

        /// <summary>
        /// Наименование основного тарифа Астрал-Отчёт
        /// </summary>
        public string MainTariffRegisteredName { get; set; }

        /// <summary>
        /// Дата регистрации основного тарифа Астрал-Отчёт
        /// </summary>
        public DateTime? MainTariffRegistrationDate { get; set; }
        public string AbonentTariffName { get; set; }
        public DateOnly? MainTariffInitialDate { get; set; }
        public DateOnly? AbonentTariffInitialDate { get; set; }
        public DateTime? AbonentTariffRegDate { get; set; }

        /// <summary>
        /// Услуги УЦ
        /// </summary>
        public decimal? CaServicePrice { get; set; }

        /// <summary>
        /// Услуги УЦ ЦП
        /// </summary>
        public decimal? ScCaServicePrice { get; set; }

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroup2Id { get; set; }

        /// <summary>
        /// Стоимость для партнёра
        /// </summary>
        public decimal? AgentCost { get; set; }

        /// <summary>
        /// Стоимость для ЦП
        /// </summary>
        public decimal? ScCost { get; set; }

        /// <summary>
        /// документ, подтверждающий скидку
        /// </summary>
        public int? DocumentId { get; set; }

        /// <summary>
        /// Ид. группы
        /// </summary>
        public int AgentBalanceGroupId { get; set; }

        /// <summary>
        /// Ид. офиса
        /// </summary>
        public int? OfficeId { get; set; }

        /// <summary>
        /// Первичный тариф
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateOnly? InitialDate { get; set; }

        /// <summary>
        /// Сумма вознаграждения партнёра
        /// </summary>
        public decimal? AgentSumReward { get; set; }

        /// <summary>
        /// Сумма вознаграждения ЦП
        /// </summary>
        public decimal? ScSumReward { get; set; }

        /// <summary>
        /// Сумма вознаграждения ЦК
        /// </summary>
        public decimal? CcSumReward { get; set; }

        /// <summary>
        /// Наименование ГК
        /// </summary>
        public string CompanyGroupName { get; set; }

        /// <summary>
        /// ИНН головной организации ГК
        /// </summary>
        public string CompanyGroupInn { get; set; }

        /// <summary>
        /// КПП головной организации ГК
        /// </summary>
        public string CompanyGroupKpp { get; set; }

        /// <summary>
        /// % вознаграждения партнёра
        /// </summary>
        public decimal? AgentPercentReward { get; set; }

        /// <summary>
        /// % вознаграждения ЦП
        /// </summary>
        public decimal? ScPercentReward { get; set; }

        /// <summary>
        /// % вознаграждения ЦК
        /// </summary>
        public decimal? CcPercentReward { get; set; }

        /// <summary>
        /// Признак расширения тарифа
        /// </summary>
        public bool? IsExtension { get; set; }

        /// <summary>
        /// Номенклатура 1С
        /// </summary>
        public string PriceTariffArticle { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateOnly? EndDate { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// % скидки
        /// </summary>
        public decimal? PercentDiscount { get; set; }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal? DiscountSum { get; set; }

        /// <summary>
        /// Ид. скидки
        /// </summary>
        public int? DiscountId { get; set; }

        /// <summary>
        /// Артикул скидки
        /// </summary>
        public string DiscountArticle { get; set; }

        /// <summary>
        /// Тарифная зона
        /// </summary>
        public int? TariffZoneId { get; set; }

        /// <summary>
        /// Наименование офиса
        /// </summary>
        public string OfficeName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Удалено
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Ид. пользователя 1С
        /// </summary>
        public string Uin1c { get; set; }

        /// <summary>
        /// Ид. опции ИТС
        /// </summary>
        public string ItsOptionId { get; set; }

        /// <summary>
        /// Стоимость для 1С
        /// </summary>
        public decimal? Cost1c { get; set; }

        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTime? DeletionDate { get; set; }

        /// <summary>
        /// Удаливший пользователь
        /// </summary>
        public int? DeletedUserId { get; set; }

        /// <summary>
        /// Требуется обновить запись
        /// </summary>
        public bool? UpdateRequired { get; set; }

        /// <summary>
        /// Ид. подписчика 1С
        /// </summary>
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
