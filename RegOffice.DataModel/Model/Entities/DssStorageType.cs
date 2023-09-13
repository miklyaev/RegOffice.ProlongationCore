using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssStorageType
    {
        public DssStorageType()
        {
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int StorageId { get; set; }
        public string StorageDescription { get; set; }

        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
