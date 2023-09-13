using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPerson
    {
        public ProductPerson()
        {
            ContactPeople = new HashSet<ContactPerson>();
            DssAuths = new HashSet<DssAuth>();
            ProductCheckings = new HashSet<ProductChecking>();
            ProductDocs = new HashSet<ProductDoc>();
            ProductPersonAvailableProtocols = new HashSet<ProductPersonAvailableProtocol>();
            ProductPersonEkus = new HashSet<ProductPersonEku>();
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            ProductPersonSteps = new HashSet<ProductPersonStep>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            Services = new HashSet<Service>();
        }

        public int ProductPersonId { get; set; }
        public int AbonentPersonId { get; set; }
        public int ProductId { get; set; }
        public int? KeyId { get; set; }
        public int? SignQualificationId { get; set; }
        public bool? Encrypt { get; set; }
        public bool? IonOnline { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public int ProductTypeId { get; set; }
        public bool? Signer { get; set; }
        public DateTime? OffTime { get; set; }
        public int? RegFileTypeId { get; set; }
        public string Message { get; set; }
        public int? UserId { get; set; }
        public int? StorageTypeId { get; set; }
        public int? ReserveKeyId { get; set; }
        public int? DssUserId { get; set; }
        public Guid ProductPersonGuid { get; set; }
        public bool? IsTrusted { get; set; }
        public bool? IsAdministrator { get; set; }

        public virtual AbonentPerson AbonentPerson { get; set; }
        public virtual DssUser DssUser { get; set; }
        public virtual Key Key { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual RegFileType RegFileType { get; set; }
        public virtual Key ReserveKey { get; set; }
        public virtual SignQualification SignQualification { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<ProductPersonAvailableProtocol> ProductPersonAvailableProtocols { get; set; }
        public virtual ICollection<ProductPersonEku> ProductPersonEkus { get; set; }
        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPersonStep> ProductPersonSteps { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
