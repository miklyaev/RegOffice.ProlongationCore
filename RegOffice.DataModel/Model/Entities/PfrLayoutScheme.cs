using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PfrLayoutScheme
    {
        public int RegionId { get; set; }
        public string AttachMask { get; set; }
        public int? AttachLimitFile { get; set; }
        public int? AttachLimit { get; set; }
        public int PfrSchemeTypeId { get; set; }
        public int? Seniority { get; set; }
        public int? FullSnils { get; set; }
        public int? AttachZip { get; set; }
        public int? Letter { get; set; }
        public int? LayoutType { get; set; }
        public int FileMaskId { get; set; }
        public int SubjectMaskId { get; set; }

        public virtual PfrSchemeFileMask FileMask { get; set; }
        public virtual PfrSchemeType PfrSchemeType { get; set; }
        public virtual Region Region { get; set; }
        public virtual PfrSchemeSubjectMask SubjectMask { get; set; }
    }
}
