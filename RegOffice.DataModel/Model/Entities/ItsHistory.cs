using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ItsHistory
    {
        public int ItsId { get; set; }
        public string ItsPublishName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreationTime { get; set; }
        public int ItsHistoryId { get; set; }

        public virtual Its Its { get; set; }
    }
}
