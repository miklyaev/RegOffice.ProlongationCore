using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentType
    {
        public AbonentType()
        {
            AbonentImportTasks = new HashSet<AbonentImportTask>();
            Abonents = new HashSet<Abonent>();
            KcrIssues = new HashSet<KcrIssue>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            Products = new HashSet<Product>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegRequests = new HashSet<RegRequest>();
            WorkflowDocTypes = new HashSet<WorkflowDocType>();
        }

        public int AbonentTypeId { get; set; }
        public string AbonentTypeName { get; set; }
        public string IrucTitle { get; set; }

        public virtual ICollection<AbonentImportTask> AbonentImportTasks { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
    }
}
