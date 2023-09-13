using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentDataViewNew
    {
        public int? AbonentId { get; set; }
        public string AbonentName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string RnsPfr { get; set; }
        public string RnsFss { get; set; }
        public long? CompanyGroupCount { get; set; }
        public string CompanyGroupName { get; set; }
        public string CompanyGroupNameList { get; set; }
        public string ProductTypes { get; set; }
    }
}
