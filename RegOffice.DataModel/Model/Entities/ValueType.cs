using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ValueType
    {
        public ValueType()
        {
            Objects = new HashSet<Object>();
            Settings = new HashSet<Setting>();
        }

        public int ValueTypeId { get; set; }
        public string CodeName { get; set; }
        public string ValueTypeName { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
    }
}
