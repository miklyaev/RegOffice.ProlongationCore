using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaTemplateType
    {
        public CaTemplateType()
        {
            CaTemplates = new HashSet<CaTemplate>();
        }

        public int TemplateTypeId { get; set; }
        public string TemplateName { get; set; }

        public virtual ICollection<CaTemplate> CaTemplates { get; set; }
    }
}
