using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonent
    {
        public PotentialAbonent()
        {
            PotentialAbonentEgais = new HashSet<PotentialAbonentEgais>();
        }

        public int PotentialAbonentId { get; set; }
        public int AbonentTypeId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public int OfficeId { get; set; }
        public int? UserId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? IsRead { get; set; }
        public int? FileId { get; set; }
        public int ProductTypeId { get; set; }
        public int StepId { get; set; }
        public string Message { get; set; }
        public string Ogrn { get; set; }
        public int RegionId { get; set; }
        public string CityName { get; set; }
        public int? DetachedUnitsCount { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Office Office { get; set; }
        public virtual Region Region { get; set; }
        public virtual PotentialAbonentStepType Step { get; set; }
        public virtual User User { get; set; }
        public virtual PotentialAbonentUcb PotentialAbonentUcb { get; set; }
        public virtual ICollection<PotentialAbonentEgais> PotentialAbonentEgais { get; set; }
    }
}
