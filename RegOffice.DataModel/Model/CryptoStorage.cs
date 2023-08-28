using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица криптографических хранилищ
    /// </summary>
    public partial class CryptoStorage
    {
        public CryptoStorage()
        {
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CryptoStorageId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CryptoStorageName { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
    }
}
