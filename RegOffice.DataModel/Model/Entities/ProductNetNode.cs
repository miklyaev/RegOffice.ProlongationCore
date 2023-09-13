using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductNetNode
    {
        public ProductNetNode()
        {
            ProductNetNodeSteps = new HashSet<ProductNetNodeStep>();
        }

        public int ProductId { get; set; }
        public string NetNodeName { get; set; }
        public Guid GateGuid { get; set; }
        public int StepId { get; set; }

        public virtual Gate GateGu { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<ProductNetNodeStep> ProductNetNodeSteps { get; set; }
    }
}
