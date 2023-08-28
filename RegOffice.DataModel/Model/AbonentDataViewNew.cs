using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
