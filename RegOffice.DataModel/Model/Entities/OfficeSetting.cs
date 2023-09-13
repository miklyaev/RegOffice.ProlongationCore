using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfficeSetting
    {
        public int OfficeId { get; set; }
        public int SettingId { get; set; }
        public string SettingValue { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Office Office { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
