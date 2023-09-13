using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ReflexType
    {
        public ReflexType()
        {
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexProductTypes = new HashSet<ReflexProductType>();
            ReflexProducts = new HashSet<ReflexProduct>();
            ReflexRules = new HashSet<ReflexRule>();
            ReflexTypeSystems = new HashSet<ReflexTypeSystem>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
        }

        public int ReflexTypeId { get; set; }
        public string ReflexTypeName { get; set; }

        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexProductType> ReflexProductTypes { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<ReflexTypeSystem> ReflexTypeSystems { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
    }
}
