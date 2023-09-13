using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPin
    {
        public OfdPin()
        {
            OfdPinSettings = new HashSet<OfdPinSetting>();
            OfdPinTemplateIds = new HashSet<OfdPinTemplateId>();
        }

        public int PinId { get; set; }
        public int PrefixId { get; set; }
        public string Pin { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public int? BillId { get; set; }
        public DateTime? ActivationTime { get; set; }
        public int? ContractTariffId { get; set; }
        public int? CommentId { get; set; }
        public int? Validity { get; set; }
        public int? ValidityUnitId { get; set; }
        public int? OfdDiscountId { get; set; }
        public string ConfigJson { get; set; }
        public string PinFull { get; set; }
        public int AgentId { get; set; }
        public int? ParentId { get; set; }
        public decimal Price { get; set; }
        public int? WaitingDays { get; set; }
        public decimal? AgentPrice { get; set; }
        public decimal? ScPrice { get; set; }
        public string Article { get; set; }
        public Guid? PinTemplateId { get; set; }
        public bool? IsPrivate { get; set; }
        public string Inn { get; set; }
        public int? OfdDeviceId { get; set; }
        public int OfdPinTypeId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
        public virtual OfdDevice OfdDevice { get; set; }
        public virtual OfdDiscount OfdDiscount { get; set; }
        public virtual OfdPinType OfdPinType { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual OfdPinTemplate PinTemplate { get; set; }
        public virtual OfdPrefix Prefix { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPinSetting> OfdPinSettings { get; set; }
        public virtual ICollection<OfdPinTemplateId> OfdPinTemplateIds { get; set; }
    }
}
