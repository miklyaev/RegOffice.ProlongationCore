using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPersonKey
    {
        public ProductPersonKey()
        {
            KeyPermissions = new HashSet<KeyPermission>();
            ProductPersonKeySteps = new HashSet<ProductPersonKeyStep>();
        }

        public int ProductPersonId { get; set; }
        public int KeyId { get; set; }
        public DateTime LogTime { get; set; }
        public bool Reserve { get; set; }
        public int? DssUserId { get; set; }
        public int PersonKeyId { get; set; }
        public int? StorageTypeId { get; set; }
        public int? StepId { get; set; }

        public virtual DssUser DssUser { get; set; }
        public virtual Key Key { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual ICollection<KeyPermission> KeyPermissions { get; set; }
        public virtual ICollection<ProductPersonKeyStep> ProductPersonKeySteps { get; set; }
    }
}
