using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Reflex
    {
        public Reflex()
        {
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexProductTypes = new HashSet<ReflexProductType>();
            ReflexProducts = new HashSet<ReflexProduct>();
            ReflexRules = new HashSet<ReflexRule>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
        }

        public int ReflexId { get; set; }
        public string DatabaseName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsTest { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexProductType> ReflexProductTypes { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
    }
}
