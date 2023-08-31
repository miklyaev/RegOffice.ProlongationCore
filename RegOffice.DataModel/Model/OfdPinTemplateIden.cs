using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPinTemplateIden
    {

        /// <summary>
        /// Ид. пин кода
        /// </summary>
        public int OfdPinId { get; set; }

        /// <summary>
        /// Ид. шаблона
        /// </summary>
        public Guid OfdPinTemplateId { get; set; }
    }
}
