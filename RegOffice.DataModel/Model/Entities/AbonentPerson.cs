using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentPerson
    {
        public AbonentPerson()
        {
            ProductPeople = new HashSet<ProductPerson>();
        }

        public int AbonentPersonId { get; set; }
        public int AbonentId { get; set; }
        public int PersonId { get; set; }
        public int? PostId { get; set; }
        public int? OrgUnitId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PostName { get; set; }
        public string Document { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual OrgUnit OrgUnit { get; set; }
        public virtual Person Person { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
    }
}
