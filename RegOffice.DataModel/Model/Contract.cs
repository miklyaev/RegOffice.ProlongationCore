using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица договоров
    /// </summary>
    public partial class Contract
    {
        public Contract()
        {
            Agents = new HashSet<Agent>();
            ContractSteps = new HashSet<ContractStep>();
            ContractTariffs = new HashSet<ContractTariff>();
            Products = new HashSet<Product>();
            ProlongationShortData = new HashSet<ProlongationShortDatum>();
            Licenses = new HashSet<LicensePool>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractName { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ContractTypeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Причина состояния
        /// </summary>
        public string StepReason { get; set; }

        /// <summary>
        /// Тарифная зона
        /// </summary>
        public int? TariffZoneId { get; set; }

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroupId { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid ContractGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual TariffZone TariffZone { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<ContractStep> ContractSteps { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortData { get; set; }
        public virtual ICollection<LicensePool> Licenses { get; set; }
    }
}
