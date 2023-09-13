using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ReflexRule
    {
        public int ReflexRuleId { get; set; }
        public int ReflexId { get; set; }
        public int ReflexTypeId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? MessengerId { get; set; }
        public int? StorageTypeId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
        public virtual StorageType StorageType { get; set; }
    }
}
