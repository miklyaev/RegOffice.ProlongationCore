using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductDoc
    {
        public int ProductId { get; set; }
        public int AbonentId { get; set; }
        public int DocId { get; set; }
        public int? ProductPersonId { get; set; }
        public int? KeyId { get; set; }
        public int ProductDocId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Doc Doc { get; set; }
        public virtual Key Key { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
    }
}
