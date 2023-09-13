using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequest
    {
        public RegRequest()
        {
            AstralWorkflowClients = new HashSet<AstralWorkflowClient>();
            KcrIssues = new HashSet<KcrIssue>();
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
            RegRequestAccounts = new HashSet<RegRequestAccount>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequestComments = new HashSet<RegRequestComment>();
            RegRequestContacts = new HashSet<RegRequestContact>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
            RegRequestFeedbacks = new HashSet<RegRequestFeedback>();
            RegRequestGates = new HashSet<RegRequestGate>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
            RegRequestPotentialMembers = new HashSet<RegRequestPotentialMember>();
            RegRequestRecipients = new HashSet<RegRequestRecipient>();
            RegRequestServices = new HashSet<RegRequestService>();
            RegRequestSteps = new HashSet<RegRequestStep>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            RegRequestTransferLogs = new HashSet<RegRequestTransferLog>();
        }

        public int RegRequestId { get; set; }
        public int RegRequestTypeId { get; set; }
        public int? AbonentTypeId { get; set; }
        public Guid? AbonentGuid { get; set; }
        public int? CategoryId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int? PostalAddressId { get; set; }
        public int? LocationAddressId { get; set; }
        public string Email { get; set; }
        public string ShortName { get; set; }
        public string RnsPfr { get; set; }
        public bool StPfr { get; set; }
        public string RnsFss { get; set; }
        public string KpFss { get; set; }
        public int StepId { get; set; }
        public int ProductTypeId { get; set; }
        public int? ProductId { get; set; }
        public int? OfficeId { get; set; }
        public DateTime CreationTime { get; set; }
        public int? UserId { get; set; }
        public int WorkflowId { get; set; }
        public int CenterId { get; set; }
        public int? CompanyGroupId { get; set; }
        public string RegistrationNumber { get; set; }
        public string ProgramVersion { get; set; }
        public int? StorageTypeId { get; set; }
        public bool? IsIts { get; set; }
        public string Ogrn { get; set; }
        public int? TransferPointId { get; set; }
        public bool SmsConfirmation { get; set; }
        public string Message { get; set; }
        public string FormatVersion { get; set; }
        public int? CompanyGroup2Id { get; set; }
        public int? ProxyAgentId { get; set; }
        public int? RequestId { get; set; }
        public string Okpo { get; set; }
        public int? IdentPointId { get; set; }
        public int? OkopfId { get; set; }
        public string RegistrationNumberOld { get; set; }
        public string EmplParentNo { get; set; }
        public string RnsFssSub { get; set; }
        public bool LkpBill { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Agent Center { get; set; }
        public virtual Abonent CompanyGroup { get; set; }
        public virtual CompanyGroup CompanyGroup2 { get; set; }
        public virtual Point IdentPoint { get; set; }
        public virtual Addr LocationAddress { get; set; }
        public virtual Office Office { get; set; }
        public virtual Okopf Okopf { get; set; }
        public virtual Addr PostalAddress { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProxyAgent ProxyAgent { get; set; }
        public virtual RegRequestType RegRequestType { get; set; }
        public virtual File Request { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual Point TransferPoint { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual RegRequestTeam RegRequestTeam { get; set; }
        public virtual ICollection<AstralWorkflowClient> AstralWorkflowClients { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
        public virtual ICollection<RegRequestAccount> RegRequestAccounts { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequestComment> RegRequestComments { get; set; }
        public virtual ICollection<RegRequestContact> RegRequestContacts { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
        public virtual ICollection<RegRequestFeedback> RegRequestFeedbacks { get; set; }
        public virtual ICollection<RegRequestGate> RegRequestGates { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
        public virtual ICollection<RegRequestPotentialMember> RegRequestPotentialMembers { get; set; }
        public virtual ICollection<RegRequestRecipient> RegRequestRecipients { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
        public virtual ICollection<RegRequestStep> RegRequestSteps { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<RegRequestTransferLog> RegRequestTransferLogs { get; set; }
    }
}
