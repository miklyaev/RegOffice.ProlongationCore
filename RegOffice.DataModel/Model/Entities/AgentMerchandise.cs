using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentMerchandise
    {
        public int BillToAgentId { get; set; }
        public int MerchandiseId { get; set; }
        public int? ProductTypeId { get; set; }
        public int AgentMerchandiseId { get; set; }
        public int? BillFromAgentId { get; set; }

        public virtual Agent BillFromAgent { get; set; }
        public virtual Agent BillToAgent { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
