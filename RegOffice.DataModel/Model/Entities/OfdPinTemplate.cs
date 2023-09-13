using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPinTemplate
    {
        public OfdPinTemplate()
        {
            OfdPinTemplateIds = new HashSet<OfdPinTemplateId>();
            OfdPinTemplateLimits = new HashSet<OfdPinTemplateLimit>();
            OfdPins = new HashSet<OfdPin>();
        }

        public Guid OfdPinTemplateId { get; set; }
        public int? Validity { get; set; }
        public int? ValidityUnitId { get; set; }
        public decimal Price { get; set; }
        public decimal AgentPrice { get; set; }
        public decimal ScPrice { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? OffTime { get; set; }
        public string Article { get; set; }
        public int? SaleCenterId { get; set; }
        public string SecretId { get; set; }
        public string Comment { get; set; }
        public string TemplateName { get; set; }
        public decimal? Cost1c { get; set; }
        public int OfdPinTypeId { get; set; }

        public virtual OfdPinType OfdPinType { get; set; }
        public virtual Agent SaleCenter { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPinTemplateId> OfdPinTemplateIds { get; set; }
        public virtual ICollection<OfdPinTemplateLimit> OfdPinTemplateLimits { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
