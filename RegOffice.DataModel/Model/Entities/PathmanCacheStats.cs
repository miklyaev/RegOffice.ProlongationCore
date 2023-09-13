using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PathmanCacheStats
    {
        public string Context { get; set; }
        public long? Size { get; set; }
        public long? Used { get; set; }
        public long? Entries { get; set; }
    }
}
