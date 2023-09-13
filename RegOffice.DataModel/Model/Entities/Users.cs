using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Users
    {
        public Users()
        {
            ElectUserDocuments = new HashSet<ElectUserDocuments>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public int AgentId { get; set; }
        public int[] ManagedRoles { get; set; }

        public virtual Agents Agent { get; set; }
        public virtual ICollection<ElectUserDocuments> ElectUserDocuments { get; set; }
    }
}
