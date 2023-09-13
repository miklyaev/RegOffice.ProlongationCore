using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaSetting
    {
        public int CaId { get; set; }
        public int SettingId { get; set; }
        public string SettingValue { get; set; }
        public int CaSettingId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
