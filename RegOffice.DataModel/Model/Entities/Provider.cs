using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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

        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int ProviderType { get; set; }
        public DateTime CreationTime { get; set; }
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
