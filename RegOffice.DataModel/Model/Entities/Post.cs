using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Post
    {
        public Post()
        {
            AbonentPeople = new HashSet<AbonentPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            Users = new HashSet<User>();
        }

        public int PostId { get; set; }
        public string PostName { get; set; }
        public bool Display { get; set; }
        public string GenitiveName { get; set; }

        public virtual ICollection<AbonentPerson> AbonentPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
