using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class File
    {
        public File()
        {
            AgentBalanceDetailChangeRequestFiles = new HashSet<AgentBalanceDetailChangeRequestFile>();
            BulkSkziLicenseUploadTaskLicenseListFiles = new HashSet<BulkSkziLicenseUploadTask>();
            BulkSkziLicenseUploadTaskLicensesPdfFiles = new HashSet<BulkSkziLicenseUploadTask>();
            Certificates = new HashSet<Certificate>();
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuths = new HashSet<DssAuth>();
            DssUsers = new HashSet<DssUser>();
            Keys = new HashSet<Key>();
            MemberReserveKeys = new HashSet<MemberReserveKey>();
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            ProductCheckings = new HashSet<ProductChecking>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequests = new HashSet<RegRequest>();
            SkziLicenses = new HashSet<SkziLicense>();
            SmevRequestStages = new HashSet<SmevRequestStage>();
            UserTrusts = new HashSet<UserTrust>();
        }

        public int FileId { get; set; }
        public int FileTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime CreationTime { get; set; }
        public byte[] Data { get; set; }
        public int? UserId { get; set; }
        public Guid FileGuid { get; set; }
        public DateTime? CleaningTime { get; set; }

        public virtual FileType FileType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestFile> AgentBalanceDetailChangeRequestFiles { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTaskLicenseListFiles { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTaskLicensesPdfFiles { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MemberReserveKey> MemberReserveKeys { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
        public virtual ICollection<SmevRequestStage> SmevRequestStages { get; set; }
        public virtual ICollection<UserTrust> UserTrusts { get; set; }
    }
}
