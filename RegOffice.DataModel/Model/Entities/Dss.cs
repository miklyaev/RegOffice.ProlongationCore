using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Dss
    {
        public Dss()
        {
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuthSystems = new HashSet<DssAuthSystem>();
            DssUserGroups = new HashSet<DssUserGroup>();
            DssUsers = new HashSet<DssUser>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int DssId { get; set; }
        public string CaName { get; set; }
        public string ClientId { get; set; }
        public string DssHost { get; set; }
        public int ProviderId { get; set; }
        public string TemplateOid { get; set; }
        public string SignAddress { get; set; }
        public string StsId { get; set; }
        public string SignId { get; set; }
        public string InnerId { get; set; }
        public string ConfirmTemplate { get; set; }
        public int? AuthMethod { get; set; }
        public int? ConfirmMethod { get; set; }
        public string AccountAddress { get; set; }
        public bool? Used { get; set; }
        public int? Timeout { get; set; }
        public string Comment { get; set; }
        public string ApiVer { get; set; }
        public string StsAddress { get; set; }
        public string SvsAddress { get; set; }
        public string EncryptUser { get; set; }
        public string CsAddress { get; set; }
        public string EncryptUserPassword { get; set; }
        public int CertificateId { get; set; }
        public string DssName { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual DssTariff DssTariff { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuthSystem> DssAuthSystems { get; set; }
        public virtual ICollection<DssUserGroup> DssUserGroups { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
