using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductLicenseView
    {
        public int? AgentId { get; set; }
        public string AgentName { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public Guid? ProductGuid { get; set; }
        public string ProductTypeName { get; set; }
        public string Registrator { get; set; }
        public string LicenseTypeName { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LicenseType { get; set; }
        public string AccrRepresent { get; set; }
        public string ProductStep { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}
