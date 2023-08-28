using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица шаблонов для УЦ
    /// </summary>
    public partial class CaTemplate
    {
        public CaTemplate()
        {
            CaTemplateAttributes = new HashSet<CaTemplateAttribute>();
            Keys = new HashSet<Key>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            TariffAttributeCas = new HashSet<TariffAttributeCa>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TemplateId { get; set; }

        /// <summary>
        /// Удостоверяющий центр
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public string TemplateOid { get; set; }

        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public int TemplateTypeId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CaTemplateType TemplateType { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<TariffAttributeCa> TariffAttributeCas { get; set; }
    }
}
