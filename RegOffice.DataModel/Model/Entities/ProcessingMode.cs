using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProcessingMode
    {
        public ProcessingMode()
        {
            ProcessingProducts = new HashSet<ProcessingProduct>();
        }

        public int ModeId { get; set; }
        public string ModeName { get; set; }

        public virtual ICollection<ProcessingProduct> ProcessingProducts { get; set; }
    }
}
