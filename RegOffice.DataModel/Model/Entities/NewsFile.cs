using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class NewsFile
    {
        public int NewsId { get; set; }
        public int FileId { get; set; }

        public virtual News News { get; set; }
    }
}
