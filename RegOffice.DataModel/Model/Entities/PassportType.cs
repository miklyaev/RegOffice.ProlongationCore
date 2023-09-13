using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PassportType
    {
        public PassportType()
        {
            Docs = new HashSet<Doc>();
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int PassportTypeId { get; set; }
        public string PassportTypeName { get; set; }
        public string PassportTypeCode { get; set; }
        public string PassportTypeNote { get; set; }

        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
