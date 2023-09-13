using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentListView
    {
        public int? AbonentId { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public bool? IsIts { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? AgentId { get; set; }
        public string CompanyGroup { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
