using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Country
    {
        public Country()
        {
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public string CountryId { get; set; }
        public string Alpha3Id { get; set; }
        public string Alpha2Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
