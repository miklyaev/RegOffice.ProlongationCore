using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CompanyGroupAbonent
    {
        public int CompanyGroupId { get; set; }
        public int AbonentId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
    }
}
