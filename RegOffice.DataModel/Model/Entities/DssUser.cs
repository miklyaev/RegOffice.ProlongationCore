using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssUser
    {
        public DssUser()
        {
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuths = new HashSet<DssAuth>();
            DssUserApps = new HashSet<DssUserApp>();
            DssUserAuthSteps = new HashSet<DssUserAuthStep>();
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? ProductId { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int AuthModeId { get; set; }
        public int? AuthContactTypeId { get; set; }
        public int? QrcodeFileId { get; set; }
        public DateTime? QrcodeEndDate { get; set; }
        public string Password { get; set; }
        public int DssId { get; set; }
        public Guid? StsUserId { get; set; }
        public int? GroupId { get; set; }
        public int? AuthStepId { get; set; }
        public DateTime? LastInitialTime { get; set; }
        public DateTime? NextCheckTime { get; set; }
        public DateTime? InstallDate { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual ContactType AuthContactType { get; set; }
        public virtual DssAuthMode AuthMode { get; set; }
        public virtual Step AuthStep { get; set; }
        public virtual Dss Dss { get; set; }
        public virtual DssUserGroup Group { get; set; }
        public virtual File QrcodeFile { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssUserApp> DssUserApps { get; set; }
        public virtual ICollection<DssUserAuthStep> DssUserAuthSteps { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
