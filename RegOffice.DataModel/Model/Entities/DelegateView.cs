using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DelegateView
    {
        public Guid? Guid { get; set; }
        public string Registrator { get; set; }
        public string Office { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DelegateName { get; set; }
        public string AbonentName { get; set; }
        public int? CategoryId { get; set; }
        public string Ruid { get; set; }
    }
}
