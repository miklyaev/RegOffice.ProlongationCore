using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegBankRequest
    {
        public RegBankRequest()
        {
            PotentialAbonentWorkflows = new HashSet<PotentialAbonentWorkflow>();
            RegBankRequestDocs = new HashSet<RegBankRequestDoc>();
            RegBankRequestSteps = new HashSet<RegBankRequestStep>();
        }

        public int RegBankRequestId { get; set; }
        public int AbonentTypeId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string ProgramVersion { get; set; }
        public int OfficeId { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public int RequestId { get; set; }
        public int WorkflowId { get; set; }
        public string Message { get; set; }
        public string AuctionNumber { get; set; }
        public int? BgRequestId { get; set; }
        public DateTime? BgInitialDate { get; set; }
        public DateTime? BgEndDate { get; set; }
        public decimal? BgSum { get; set; }
        public string BgUrl { get; set; }
        public decimal? BgPrice { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Addr Address { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<PotentialAbonentWorkflow> PotentialAbonentWorkflows { get; set; }
        public virtual ICollection<RegBankRequestDoc> RegBankRequestDocs { get; set; }
        public virtual ICollection<RegBankRequestStep> RegBankRequestSteps { get; set; }
    }
}
