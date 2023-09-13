using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CryptoStorageKey
    {
        public int CryptoStorageKeyId { get; set; }
        public int KeyId { get; set; }
        public int CryptoStorageId { get; set; }
        public int? DssKeyStorageId { get; set; }

        public virtual CryptoStorage CryptoStorage { get; set; }
        public virtual DssStorageType DssKeyStorage { get; set; }
        public virtual Key Key { get; set; }
    }
}
