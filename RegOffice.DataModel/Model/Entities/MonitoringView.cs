using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MonitoringView
    {
        public int? AbonentId { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string RnsPfr { get; set; }
        public string RnsFss { get; set; }
        public string KpFss { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string AbonentTypeName { get; set; }
        public int? OkopfId { get; set; }
        public Guid? ProductGuid { get; set; }
        public DateTime? DateFixed { get; set; }
        public int? TimeLimit { get; set; }
        public bool? HardCodeSos { get; set; }
        public string CodeName { get; set; }
        public string ProductTypeName { get; set; }
        public Guid? ProductTypeGuid { get; set; }
        public string OfficeName { get; set; }
        public Guid? OfficeGuid { get; set; }
        public string Ruid { get; set; }
        public string PfrSystemSender { get; set; }
        public string PfrSender { get; set; }
    }
}
