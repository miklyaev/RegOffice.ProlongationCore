using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ключей криптографического хранилища
    /// </summary>
    public partial class CryptoStorageKey
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CryptoStorageKeyId { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Хранилище
        /// </summary>
        public int CryptoStorageId { get; set; }
        public int? DssKeyStorageId { get; set; }

        public virtual CryptoStorage CryptoStorage { get; set; }
        public virtual DssStorageType DssKeyStorage { get; set; }
        public virtual Key Key { get; set; }
    }
}
