using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов продуктов
    /// </summary>
    public partial class ProductType
    {
        public ProductType()
        {
            AbonentCounts = new HashSet<AbonentCount>();
            AgentMerchandises = new HashSet<AgentMerchandise>();
            AgentSchemes = new HashSet<AgentScheme>();
            CaProductTypes = new HashSet<CaProductType>();
            CertTemplateProductTypes = new HashSet<CertTemplateProductType>();
            CheckingSchemes = new HashSet<CheckingScheme>();
            CompanyGroups = new HashSet<CompanyGroup>();
            GateProductTypes = new HashSet<GateProductType>();
            Modules = new HashSet<Module>();
            NewsVisibilities = new HashSet<NewsVisibility>();
            PriceSchemes = new HashSet<PriceScheme>();
            ProductPeople = new HashSet<ProductPerson>();
            Products = new HashSet<Product>();
            ReflexProductTypes = new HashSet<ReflexProductType>();
            ReflexRules = new HashSet<ReflexRule>();
            RegRequests = new HashSet<RegRequest>();
            RejectedRegRequests = new HashSet<RejectedRegRequest>();
            Reports = new HashSet<Report>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Кодовое имя
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ProductTypeName { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid ProductTypeGuid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual ICollection<AbonentCount> AbonentCounts { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandises { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<CaProductType> CaProductTypes { get; set; }
        public virtual ICollection<CertTemplateProductType> CertTemplateProductTypes { get; set; }
        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
        public virtual ICollection<CompanyGroup> CompanyGroups { get; set; }
        public virtual ICollection<GateProductType> GateProductTypes { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemes { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ReflexProductType> ReflexProductTypes { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<RejectedRegRequest> RejectedRegRequests { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
