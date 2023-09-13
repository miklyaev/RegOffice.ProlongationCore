using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CryptoStorage
    {
        public CryptoStorage()
        {
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
        }

        public int CryptoStorageId { get; set; }
        public string CryptoStorageName { get; set; }
        public string RemoteAddress { get; set; }
        public int ProviderId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
    }
}
