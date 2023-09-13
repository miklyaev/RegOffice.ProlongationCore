using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Doc
    {
        public Doc()
        {
            PersonDocs = new HashSet<PersonDoc>();
            ProductDocs = new HashSet<ProductDoc>();
            RegBankRequestDocs = new HashSet<RegBankRequestDoc>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
        }

        public int DocId { get; set; }
        public int? AbonentId { get; set; }
        public int DocTypeId { get; set; }
        public int? PassportTypeId { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime CreationTime { get; set; }
        public string Addon { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }
        public int? FileId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual PassportType PassportType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PersonDoc> PersonDocs { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<RegBankRequestDoc> RegBankRequestDocs { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
    }
}
