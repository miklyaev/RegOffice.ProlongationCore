using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CompanyGroup
    {
        public CompanyGroup()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            CompanyGroupAbonents = new HashSet<CompanyGroupAbonent>();
            Contracts = new HashSet<Contract>();
            RegRequests = new HashSet<RegRequest>();
        }

        public int CompanyGroupId { get; set; }
        public string CompanyGroupName { get; set; }
        public int AbonentId { get; set; }
        public int? OfficeId { get; set; }
        public int? ProductTypeId { get; set; }
        public Guid CompanyGroupGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<CompanyGroupAbonent> CompanyGroupAbonents { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
