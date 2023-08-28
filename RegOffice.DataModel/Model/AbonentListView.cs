using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
