using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentImportTask
    {
        public int TaskId { get; set; }
        public string TaskFileName { get; set; }
        public byte[] InputFileData { get; set; }
        public byte[] OutputFileData { get; set; }
        public int StepId { get; set; }
        public int AbonentTypeId { get; set; }
        public int UserId { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
