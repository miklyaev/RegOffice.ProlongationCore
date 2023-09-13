using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MonitoringAppView
    {
        public string ApplicationName { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool? IsWork { get; set; }
        public string Description { get; set; }
    }
}
