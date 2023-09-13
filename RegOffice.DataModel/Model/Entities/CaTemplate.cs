using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaTemplate
    {
        public CaTemplate()
        {
            CaTemplateAttributes = new HashSet<CaTemplateAttribute>();
            Keys = new HashSet<Key>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            TariffAttributeCas = new HashSet<TariffAttributeCa>();
        }

        public int TemplateId { get; set; }
        public int CaId { get; set; }
        public string TemplateOid { get; set; }
        public int TemplateTypeId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CaTemplateType TemplateType { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<TariffAttributeCa> TariffAttributeCas { get; set; }
    }
}
