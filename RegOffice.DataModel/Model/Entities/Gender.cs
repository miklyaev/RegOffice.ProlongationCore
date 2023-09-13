using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
