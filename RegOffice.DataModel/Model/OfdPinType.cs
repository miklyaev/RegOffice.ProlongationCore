using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPinType
    {
        public OfdPinType()
        {
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OfdPinTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OfdPinTypeName { get; set; }

        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
