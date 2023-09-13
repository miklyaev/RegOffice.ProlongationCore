using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Okopf
    {
        public Okopf()
        {
            Abonents = new HashSet<Abonent>();
            RegRequests = new HashSet<RegRequest>();
        }

        public int OkopfId { get; set; }
        public string OkopfName { get; set; }
        public string OkopfShortName { get; set; }
        public string Code99 { get; set; }
        public string Code2012 { get; set; }
        public bool Budget { get; set; }
        public int StepId { get; set; }

        public virtual Step Step { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
