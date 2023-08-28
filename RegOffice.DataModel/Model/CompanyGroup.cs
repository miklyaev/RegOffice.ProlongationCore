using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп компаний
    /// </summary>
    public partial class CompanyGroup
    {
        public CompanyGroup()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            Contracts = new HashSet<Contract>();
            RegRequests = new HashSet<RegRequest>();
            Abonents = new HashSet<Abonent>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CompanyGroupId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CompanyGroupName { get; set; }

        /// <summary>
        /// Главная организация
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid CompanyGroupGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
    }
}
