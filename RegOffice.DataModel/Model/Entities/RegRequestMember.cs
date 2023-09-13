using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestMember
    {
        public RegRequestMember()
        {
            DssAuthKeys = new HashSet<DssAuthKey>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
            RegRequestMemberAvailableProtocols = new HashSet<RegRequestMemberAvailableProtocol>();
            RegRequestMemberContacts = new HashSet<RegRequestMemberContact>();
            RegRequestMemberDssApps = new HashSet<RegRequestMemberDssApp>();
            RegRequestMemberEkus = new HashSet<RegRequestMemberEku>();
            RegRequestServices = new HashSet<RegRequestService>();
        }

        public int MemberId { get; set; }
        public int RegRequestId { get; set; }
        public Guid? MemberGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int? PassportTypeId { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PasportDate { get; set; }
        public string PassportAddon { get; set; }
        public int? PostId { get; set; }
        public bool? Signer { get; set; }
        public bool? Encrypt { get; set; }
        public int SignQualificationId { get; set; }
        public bool IonOnline { get; set; }
        public int? OrgUnitId { get; set; }
        public int? ProviderId { get; set; }
        public string ContainerName { get; set; }
        public int? ProductPersonId { get; set; }
        public int? CaId { get; set; }
        public string Snils { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CertTemplateId { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? RegFileTypeId { get; set; }
        public int GenderId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string CountryId { get; set; }
        public string SubjectKeyId { get; set; }
        public int? CertRequestId { get; set; }
        public int? CertId { get; set; }
        public string PassportUnit { get; set; }
        public int? StorageTypeId { get; set; }
        public bool ForceUpdate { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public int? TemplateId { get; set; }
        public int? DssAuthModeId { get; set; }
        public bool? ForceQrcodeGeneration { get; set; }
        public int? DssId { get; set; }
        public string DssLogin { get; set; }
        public string Inn { get; set; }
        public bool? IsTrusted { get; set; }
        public bool? IsAdministrator { get; set; }
        public bool? IsRequestSender { get; set; }
        public bool Unregister { get; set; }
        public int? DssKeyStorageId { get; set; }
        public int? DssUserId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Country Country { get; set; }
        public virtual Dss Dss { get; set; }
        public virtual DssAuthMode DssAuthMode { get; set; }
        public virtual DssStorageType DssKeyStorage { get; set; }
        public virtual DssUser DssUser { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual OrgUnit OrgUnit { get; set; }
        public virtual PassportType PassportType { get; set; }
        public virtual Post Post { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual RegFileType RegFileType { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual SignQualification SignQualification { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual CaTemplate Template { get; set; }
        public virtual MemberReserveKey MemberReserveKey { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
        public virtual ICollection<RegRequestMemberAvailableProtocol> RegRequestMemberAvailableProtocols { get; set; }
        public virtual ICollection<RegRequestMemberContact> RegRequestMemberContacts { get; set; }
        public virtual ICollection<RegRequestMemberDssApp> RegRequestMemberDssApps { get; set; }
        public virtual ICollection<RegRequestMemberEku> RegRequestMemberEkus { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
    }
}
