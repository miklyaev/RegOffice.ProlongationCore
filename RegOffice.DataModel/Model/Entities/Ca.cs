using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Ca
    {
        public Ca()
        {
            CaAccreditations = new HashSet<CaAccreditation>();
            CaCertificates = new HashSet<CaCertificate>();
            CaMessengers = new HashSet<CaMessenger>();
            CaProductTypes = new HashSet<CaProductType>();
            CaSettings = new HashSet<CaSetting>();
            CaTemplates = new HashSet<CaTemplate>();
            Keys = new HashSet<Key>();
            MemberReserveKeys = new HashSet<MemberReserveKey>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            Ras = new HashSet<Ra>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            TariffAttributeCas = new HashSet<TariffAttributeCa>();
        }

        public int CaId { get; set; }
        public string CaName { get; set; }
        public int CertificateId { get; set; }
        public string PrefixDuc { get; set; }
        public string NetNumber { get; set; }
        public string DefaultCuid { get; set; }
        public string PolicyOid { get; set; }
        public string PolicyUrl { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime? OffTime { get; set; }
        public string SystemNameDuc { get; set; }
        public string CaShortName { get; set; }
        public bool IsQualified { get; set; }
        public bool IsCryptopro { get; set; }
        public bool IsSolid { get; set; }
        public string Mnemonic { get; set; }
        public string Inn { get; set; }
        public int? IssuerId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual VipnetNode DefaultCu { get; set; }
        public virtual Issuer Issuer { get; set; }
        public virtual CaRequestApi CaRequestApi { get; set; }
        public virtual ICollection<CaAccreditation> CaAccreditations { get; set; }
        public virtual ICollection<CaCertificate> CaCertificates { get; set; }
        public virtual ICollection<CaMessenger> CaMessengers { get; set; }
        public virtual ICollection<CaProductType> CaProductTypes { get; set; }
        public virtual ICollection<CaSetting> CaSettings { get; set; }
        public virtual ICollection<CaTemplate> CaTemplates { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MemberReserveKey> MemberReserveKeys { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<Ra> Ras { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<TariffAttributeCa> TariffAttributeCas { get; set; }
    }
}
