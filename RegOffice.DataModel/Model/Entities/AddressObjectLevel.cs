using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AddressObjectLevel
    {
        public AddressObjectLevel()
        {
            AddressObjectPrefixes = new HashSet<AddressObjectPrefix>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public string LevelNote { get; set; }

        public virtual ICollection<AddressObjectPrefix> AddressObjectPrefixes { get; set; }
    }
}
