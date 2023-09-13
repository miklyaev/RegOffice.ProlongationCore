using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Documents
    {
        public Documents()
        {
            DocumentRolesNavigation = new HashSet<DocumentRoles>();
            InverseParentGu = new HashSet<Documents>();
        }

        public Guid DocumentGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? FileGuid { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int DocumentTypeOption { get; set; }
        public int? SectionTypeOption { get; set; }
        public string Description { get; set; }
        public int[] ManagedRoles { get; set; }
        public int[] DocumentRoles { get; set; }

        public virtual DocumentTypes DocumentTypeOptionNavigation { get; set; }
        public virtual Files FileGu { get; set; }
        public virtual Documents ParentGu { get; set; }
        public virtual SectionTypes SectionTypeOptionNavigation { get; set; }
        public virtual ElectUserDocuments ElectUserDocuments { get; set; }
        public virtual ICollection<DocumentRoles> DocumentRolesNavigation { get; set; }
        public virtual ICollection<Documents> InverseParentGu { get; set; }
    }
}
