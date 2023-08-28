using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AbonentRegionView
    {
        public int? AbonentId { get; set; }
        public int? AbonentTypeId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string RnsPfr { get; set; }
        public string RnsFss { get; set; }
        public string KpFss { get; set; }
        public int? PostalAddressId { get; set; }
        public int? LocationAddressId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? OfficeId { get; set; }
        public int? OkopfId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string StRnsPfr { get; set; }
        public int? UserId { get; set; }
        public string AbonentLogin { get; set; }
        public string AbonentPassword { get; set; }
        public string ContactPeople { get; set; }
        public int? CompanyGroupId { get; set; }
        public int? RegionId { get; set; }
    }
}
