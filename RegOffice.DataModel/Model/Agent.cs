using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица партнеров
    /// </summary>
    public partial class Agent
    {
        public Agent()
        {
            InverseOldParent = new HashSet<Agent>();
            InverseParent = new HashSet<Agent>();
            Offices = new HashSet<Office>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AgentName { get; set; }

        /// <summary>
        /// СМ
        /// </summary>
        public string Cuid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Владелец
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int? AbonentId { get; set; }

        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }

        /// <summary>
        /// Телефон горячей линии
        /// </summary>
        public string SupportPhone { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string SupportEmail { get; set; }
        public string InvoicePrefix { get; set; }
        public int? OldParentId { get; set; }

        /// <summary>
        /// Признак партнёра БИТ
        /// </summary>
        public bool? IsBit { get; set; }

        /// <summary>
        /// Электронная почта партнера
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон партнера
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Код партнера 1С
        /// </summary>
        public string Code1c { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Признак агента 1С
        /// </summary>
        public bool? Distributor1c { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid AgentGuid { get; set; }

        /// <summary>
        /// Уровень сертификации партнера
        /// </summary>
        public int? LevelAucId { get; set; }

        /// <summary>
        /// Идентификатор бизнес-региона
        /// </summary>
        public int? BusinessRegionId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Agent OldParent { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual ICollection<Agent> InverseOldParent { get; set; }
        public virtual ICollection<Agent> InverseParent { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
