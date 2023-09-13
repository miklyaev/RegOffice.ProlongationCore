using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AddressObjectPrefix
    {
        public AddressObjectPrefix()
        {
            AddressObjects = new HashSet<AddressObject>();
        }

        public int PrefixId { get; set; }
        public int LevelId { get; set; }
        public string PrefixName { get; set; }
        public string FullName { get; set; }

        public virtual AddressObjectLevel Level { get; set; }
        public virtual ICollection<AddressObject> AddressObjects { get; set; }
    }
}
