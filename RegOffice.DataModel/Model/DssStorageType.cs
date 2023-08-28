using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Справочник типов хранения ключей DSS
    /// </summary>
    public partial class DssStorageType
    {
        public DssStorageType()
        {
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор типа хранения
        /// </summary>
        public int StorageId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string StorageDescription { get; set; }

        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
