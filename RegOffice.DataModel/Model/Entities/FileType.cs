using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class FileType
    {
        public FileType()
        {
            Files = new HashSet<File>();
        }

        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string FileExtension { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
