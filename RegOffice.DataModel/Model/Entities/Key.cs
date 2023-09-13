using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Key
    {
        public Key()
        {
            ContractTariffKeys = new HashSet<ContractTariffKey>();
            CryptoStorageKeys = new HashSet<CryptoStorageKey>();
            ProductDocs = new HashSet<ProductDoc>();
            ProductPersonKeys = new HashSet<ProductPerson>();
            ProductPersonKeysNavigation = new HashSet<ProductPersonKey>();
            ProductPersonReserveKeys = new HashSet<ProductPerson>();
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
        }

        public int KeyId { get; set; }
        public int PersonId { get; set; }
        public string ContainerName { get; set; }
        public int ProviderId { get; set; }
        public int CaId { get; set; }
        public int? CertificateId { get; set; }
        public string VipnetUserId { get; set; }
        public string KeyPassword { get; set; }
        public string PasswordPhrase { get; set; }
        public DateTime CreationTime { get; set; }
        public string PackId { get; set; }
        public string PublicKey { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? CertTemplateId { get; set; }
        public int? ProtectionClassId { get; set; }
        public int? CertRequestId { get; set; }
        public bool? Eхportable { get; set; }
        public int? TemplateId { get; set; }
        public int? WorkflowId { get; set; }
        public int? ContainerId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual File Container { get; set; }
        public virtual Person Person { get; set; }
        public virtual ProtectionClass ProtectionClass { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual CaTemplate Template { get; set; }
        public virtual VipnetUser VipnetUser { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<ContractTariffKey> ContractTariffKeys { get; set; }
        public virtual ICollection<CryptoStorageKey> CryptoStorageKeys { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeysNavigation { get; set; }
        public virtual ICollection<ProductPerson> ProductPersonReserveKeys { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
    }
}
