using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Person
    {
        public Person()
        {
            AbonentPeople = new HashSet<AbonentPerson>();
            Keys = new HashSet<Key>();
            PersonDocs = new HashSet<PersonDoc>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Pseudonym { get; set; }
        public int PassportTypeId { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportAddon { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public DateTime? BirthDate { get; set; }
        public int OfficeId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? UserId { get; set; }
        public DateTime? PasportDate { get; set; }
        public string Snils { get; set; }
        public int GenderId { get; set; }
        public string BirthPlace { get; set; }
        public string CountryId { get; set; }
        public string PassportUnit { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public string Inn { get; set; }

        public virtual Country Country { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Office Office { get; set; }
        public virtual PassportType PassportType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AbonentPerson> AbonentPeople { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<PersonDoc> PersonDocs { get; set; }
    }
}
