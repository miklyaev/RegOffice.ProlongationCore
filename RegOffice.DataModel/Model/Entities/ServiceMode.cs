using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ServiceMode
    {
        public ServiceMode()
        {
            ServiceTypes = new HashSet<ServiceType>();
        }

        public int ServiceModeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ServiceType> ServiceTypes { get; set; }
    }
}
