using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ItsDistributor
    {
        public string ItsDistributorName { get; set; }
        public int? AgentId { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
