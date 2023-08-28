using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class IsExistRnsPfr
    {
        public int? AbonentId { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string RnsPfr { get; set; }
    }
}
