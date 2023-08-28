using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Шаблоны Крипто про
    /// </summary>
    public partial class CaTemplateType
    {
        public CaTemplateType()
        {
            CaTemplates = new HashSet<CaTemplate>();
        }


        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public int TemplateTypeId { get; set; }

        /// <summary>
        /// Наименование шаблона
        /// </summary>
        public string TemplateName { get; set; }

        public virtual ICollection<CaTemplate> CaTemplates { get; set; }
    }
}
