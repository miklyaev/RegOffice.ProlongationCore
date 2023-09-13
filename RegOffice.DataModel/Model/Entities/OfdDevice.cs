using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdDevice
    {
        public OfdDevice()
        {
            OfdPins = new HashSet<OfdPin>();
        }

        public int OfdDeviceId { get; set; }
        public string SerialNumber { get; set; }
        public int OfdDeviceTypeId { get; set; }
        public string Comment { get; set; }
        public int? AgentId { get; set; }
        public int? ParentId { get; set; }
        public int? AstralKktId { get; set; }
        public DateTime? AstralKktDate { get; set; }
        public DateTime? ParentDate { get; set; }
        public DateTime? AgentDate { get; set; }
        public int UserId { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int? ValidityLength { get; set; }
        public int? ValidityUnitId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Agent AstralKkt { get; set; }
        public virtual OfdDeviceType OfdDeviceType { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual User User { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
