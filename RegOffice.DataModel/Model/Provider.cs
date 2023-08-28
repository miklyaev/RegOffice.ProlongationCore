using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица криптопровайдеров
    /// </summary>
    public partial class Provider
    {
        public Provider()
        {
            CryptoStorages = new HashSet<CryptoStorage>();
            Dsses = new HashSet<Dss>();
            KcrIssues = new HashSet<KcrIssue>();
            Keys = new HashSet<Key>();
            MemberReserveKeys = new HashSet<MemberReserveKey>();
            Offices = new HashSet<Office>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ProviderType { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Средство ЭП
        /// </summary>
        public string SignTool { get; set; }

        public virtual ICollection<CryptoStorage> CryptoStorages { get; set; }
        public virtual ICollection<Dss> Dsses { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MemberReserveKey> MemberReserveKeys { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
