using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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

        public int ProductTypeId { get; set; }
        public string CodeName { get; set; }
        public string ProductTypeName { get; set; }
        public Guid ProductTypeGuid { get; set; }
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
